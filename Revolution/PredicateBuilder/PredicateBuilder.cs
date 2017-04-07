using System;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace PredicateBuilder
{
    public enum OperatorType
    {
        Greater,
        GreaterEqual,
        Less,
        LessEqual,        
        Equal,
        NotEqual,
        Between,
        CompareTo,
        Like,
        StartsWith,
        Blank
    }

    public static class Instance
    {

        #region Main Public Methods 

        /// <summary>
        /// Creates a predicate that evaluates to true.
        /// </summary>
        public static Expression<Func<T, bool>> True<T>()
        {
            return param => true;
        }

        /// <summary>
        /// Creates a predicate that evaluates to false.
        /// </summary>
        public static Expression<Func<T, bool>> False<T>()
        {
            return param => false;
        }

        /// <summary>
        /// Creates a predicate expression from the specified lamda expression.
        /// </summary>
        public static Expression<Func<T, bool>> Create<T>(Expression<Func<T, bool>> predicate)
        {
            return predicate;
        }

        /// <summary>
        /// Combines the first predicate with the second using the logical "and".
        /// </summary>
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
        {
            return first.Compose(second, Expression.AndAlso);
        }

        /// <summary>
        /// Combines the first predicate with the second using the logical "or".
        /// </summary>
        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
        {
            return first.Compose(second, Expression.OrElse);
        }

        /// <summary>
        /// Combines the first predicate with the second using the logical "and".
        /// </summary>
        public static Expression<Func<T, bool>> Except<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second)
        {
            return first.Compose(second.Not(), Expression.AndAlso);
        }

        public static Expression<Func<T, bool>> Not<T> (this Expression<Func<T, bool>> self)
        {
            CheckSelf (self);

            var parameter = Expression.Parameter (self.Parameters[0].Type, self.Parameters[0].Name);

            return Expression.Lambda<Func<T, bool>> (
                Expression.Not (RewriteLambdaBody (self, parameter)),
                parameter);
        }

        /// <summary>
        /// Build a simple lamda x => x._fieldname_
        /// </summary>
        public static Expression<Func<TEntity, TResult>> SelectorPredicate<TEntity, TResult>( List<string> links )
        {
            // root parameter and type
            ParameterExpression rootExp = Expression.Parameter( typeof( TEntity ), typeof( TEntity ).Name.Substring( 0, 1 ) );
            Type dataType = typeof( TEntity );

            // set property, expression, type for each link
            PropertyInfo pi = null;
            Expression expr = rootExp;
            foreach( string prop in links )
            {
                pi = dataType.GetProperty( prop );
                expr = Expression.Property( expr, pi );
                if( pi.PropertyType.Name == "IList`1" )
                {
                    // stop here. can't get individual properties of a collection
                    break;
                }
                dataType = pi.PropertyType;
            }

            return Expression.Lambda<Func<TEntity, TResult>>( expr, rootExp );
        }

        /// <summary>
        /// Returns a list of lambda expressions ({x => x.Prop}) for all properties for
        /// given type
        /// </summary>
        public static List<LambdaExpression> FieldList<TEntity>() where TEntity : class
        {
            List<LambdaExpression> list = new List<LambdaExpression>();

            // root parameter and type
            ParameterExpression rootExp = Expression.Parameter( typeof( TEntity ), typeof( TEntity ).Name.Substring( 0, 1 ) );
            Type dataType = typeof( TEntity );

            // set property, expression, type for each link
            PropertyInfo pi = null;
            Expression expr = rootExp;
            foreach( PropertyInfo prop in dataType.GetProperties() )
            {
                if( prop.PropertyType.GetProperties().Count() > 0 )
                {
                    Type collectionType = prop.PropertyType.GetGenericArguments().ElementAt( 0 );
                    MethodInfo genericMethod = typeof( Instance ).GetMethod( "FieldList", BindingFlags.Public | BindingFlags.Static );
                    MethodInfo genericChildPredicate = genericMethod.MakeGenericMethod( collectionType );
                    list.AddRange( (List<LambdaExpression>)genericChildPredicate.Invoke( null, null ) );
                }
                else
                {
                    Expression bodyExp = Expression.PropertyOrField( rootExp, prop.Name );
                    list.Add( Expression.Lambda( bodyExp, rootExp ) );
                }
            }

            return list;
        }


        //public static Expression<Func<TEntity, bool>> Build<TEntity>(TEntity type, List<string> typeChain, OperatorType operation, object value1, object value2)
        //{
        //    return (Expression<Func<TEntity, bool>>)typeof(PredicateBuilder.Instance)
        //        .GetMethod("Build")
        //        .MakeGenericMethod(typeof(TEntity))
        //        .Invoke(null, new object[] { typeChain, operation, value1, value2 });

        //}


        /// <summary>
        /// This gets called recusively until a scalar property is found.
        /// It then completes building the predicate
        /// </summary>
        /// <returns>{x=>x.Child.Toy.Manufacturer.Name == "Hasbro" } where x is of type Parent
        /// or, for collections, {x=>Parent.Children.Any(z=>z.Toy.Manufacturer.Name == "Hasbro" ) }</returns>
        public static Expression<Func<TEntity, bool>> Build<TEntity>(List<string> typeChain, OperatorType operation, object value1, object value2 )
        {
            // root parameter and type
            ParameterExpression rootExp = Expression.Parameter( typeof( TEntity ), typeof( TEntity ).Name.Substring(0,1));
            Type dataType = typeof( TEntity );

            // set property, expression, type for each link
            PropertyInfo pi = null;
            Expression expr = rootExp;
            for(int counter = 0; counter < typeChain.Count(); counter ++ )
            {                
                pi = dataType.GetProperty( typeChain.ElementAt(counter) );

                if(pi == null)
                {
                    // possible if original list consists of collection and collection's 
                    // parameters (i.e. Parents.Any(x=>x.Child.Name == 'Tony') )
                    // if so, entire links list consumed by recursive call. 
                    // Return using that inner predicate, which is in expr
                    return Expression.Lambda<Func<TEntity, bool>>( expr, rootExp );
                }
                else if(pi.PropertyType.Name == "IList`1")
                {
                    // call back into this function, but return is parameter for 'Any'
                    Type collectionType = pi.PropertyType.GetGenericArguments().ElementAt( 0 );

                    // any method
                    MethodInfo anyMethod
                        = typeof( Enumerable ).GetMethods()
                                              .Where( m => m.Name == "Any" && m.GetParameters().Length == 2 )
                                              .Single()
                                              .MakeGenericMethod( collectionType );

                    // generic version of this method
                    MethodInfo genericMethod = typeof( Instance ).GetMethod( "Build", BindingFlags.Public | BindingFlags.Static );
                    MethodInfo genericBuild = genericMethod.MakeGenericMethod( collectionType );

                    List<string> newLinks = typeChain;
                    // may arrive here after several iterations
                    for(int r = 0; r <= counter; r++)
                    {
                        newLinks.RemoveAt( 0 );
                    }
                    Expression innerExpression = (Expression)genericBuild.Invoke( null, new object[] { newLinks, operation, value1, value2 } );

                    Expression collectionExpression = Expression.Property( expr, pi );
                    expr = Expression.Call( anyMethod, collectionExpression, innerExpression );
                }
                else
                {
                    expr = Expression.Property( expr, pi );
                }
                dataType = pi.PropertyType;
            }

            // values
            ConstantExpression constExp1 = Expression.Constant( ProperType( pi, value1 ) );
            ConstantExpression constExp2 = Expression.Constant( ProperType( pi, value2 ) );

            // put together
            Expression compareExp = CompareExpression( expr, constExp1, constExp2, operation );
            return Expression.Lambda<Func<TEntity, bool>>( compareExp, rootExp );
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Combines the first expression with the second using the specified merge function.
        /// </summary>
        static Expression<T> Compose<T>(this Expression<T> first, Expression<T> second, Func<Expression, Expression, Expression> merge)
        {
            // build parameter map (from parameters of second to parameters of first)
            var map = first.Parameters
                .Select((f, i) => new
                {
                    f,
                    s = second.Parameters[i]
                })
                .ToDictionary(p => p.s, p => p.f);

            // replace parameters in the second lambda expression with parameters from the first
            var secondBody = ParameterRebinder.ReplaceParameters(map, second.Body);

            // apply composition of lambda expression bodies to parameters from the first expression
            return Expression.Lambda<T>(merge(first.Body, secondBody), first.Parameters);
        }

        static Expression RewriteLambdaBody(LambdaExpression expression, ParameterExpression parameter)
        {
            return new ParameterRewriter(expression.Parameters[0], parameter).Visit(expression.Body);
        }

        static void CheckSelf<T>(Expression<Func<T, bool>> self)
        {
            if(self == null)
                throw new ArgumentNullException("self");
        }

        static void CheckSelfAndExpression<T>(Expression<Func<T, bool>> self, Expression<Func<T, bool>> expression)
        {
            if(self == null)
                throw new ArgumentNullException("self");
            if(expression == null)
                throw new ArgumentNullException("expression");
        }

        /// <summary>
        /// Assumes paramExp and ConstExp are same base type
        /// </summary>
        /// <param name="paramExp"></param>
        /// <param name="constExp1"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        static Expression CompareExpression(Expression paramExp, Expression constExp1, Expression constExp2, OperatorType operation)
        {
            // this deals with nullables of same type. i.e. converts int to int? and verse vica
            if(IsNullableType(paramExp.Type) && !IsNullableType(constExp1.Type))
            {
                constExp1 = Expression.Convert(constExp1, paramExp.Type);
            }
            else if(!IsNullableType(paramExp.Type) && IsNullableType(constExp1.Type))
            {
                paramExp = Expression.Convert(paramExp, constExp1.Type);
            }

            if (IsNullableType(paramExp.Type) && !IsNullableType(constExp2.Type))
            {
                constExp2 = Expression.Convert(constExp2, paramExp.Type);
            }
            else if (!IsNullableType(paramExp.Type) && IsNullableType(constExp2.Type))
            {
                paramExp = Expression.Convert(paramExp, constExp2.Type);
            }

            switch(operation)
            {
                case OperatorType.Greater:
                    return Expression.GreaterThan(paramExp, constExp1);
                case OperatorType.GreaterEqual:
                    return Expression.GreaterThanOrEqual(paramExp, constExp1);
                case OperatorType.Less:
                    return Expression.LessThan(paramExp, constExp1);
                case OperatorType.LessEqual:
                    return Expression.LessThanOrEqual(paramExp, constExp1);
                case OperatorType.NotEqual:
                    return Expression.NotEqual(paramExp, constExp1);
                case OperatorType.Between:
                    Expression expGT = Expression.GreaterThanOrEqual(paramExp, constExp1);
                    Expression expLT = Expression.LessThanOrEqual(paramExp, constExp2);
                    return Expression.AndAlso( expGT, expLT );
                case OperatorType.CompareTo:
                    // working, but not a bool - it returns int
                    MethodInfo c = typeof(string).GetMethods().Where(x=>x.Name == "Compare")
                                                              .Where(x=>x.GetParameters().Length == 2)
                                                              .First();
                    return Expression.Call(c, paramExp, constExp1);
                case OperatorType.Like:
                    MethodInfo m = typeof(string).GetMethod("Contains", new Type[] { typeof(string) });
                    return Expression.Call(paramExp, m, constExp1);
                case OperatorType.StartsWith:
                    MethodInfo s = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });
                    return Expression.Call(paramExp, s, constExp1);
                case OperatorType.Blank:
                    if(paramExp.Type.Name == "Int32")
                    {
                         return Expression.Equal( paramExp, Expression.Constant(0) );
                    }
                    return Expression.Equal( paramExp, constExp2 );
                default:
                    return Expression.Equal(paramExp, constExp1);
            }
        }

        /// <summary>
        /// Returns true if type T is a nullable type
        /// </summary>
        static bool IsNullableType(Type t)
        {
            return t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        /// <summary>
        /// Returns an object that has been cast to the type given in pi. The value is set
        /// to criteria, or the default for the given type
        /// </summary>        
        static object ProperType(PropertyInfo pi, object criteria)
        {
            if(criteria == null)
            {
                return null;
            }

            object buffer = null;

            // check data type
            switch(pi.PropertyType.FullName)
            {
                case "System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                case "System.Int32":
                    int intVal;
                    if(Int32.TryParse(criteria.ToString(), out intVal))
                    {
                        buffer = intVal;
                    }
                    else
                    {
                        buffer = 0;
                    }
                    break;
                case "System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":                
                case "System.Int64":
                    long longVal;
                    if(Int64.TryParse(criteria.ToString(), out longVal))
                    {
                        buffer = longVal;
                    }
                    else
                    {
                        buffer = 0;
                    }
                    break;
                case "System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                case "System.Single":
                    float singVal;
                    if(Single.TryParse(criteria.ToString(), out singVal))
                    {
                        buffer = singVal;
                    }
                    else
                    {
                        buffer = 0;
                    }
                    break;
                case "System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                case "System.Decimal":
                    decimal decimalVal;
                    if(Decimal.TryParse(criteria.ToString(), System.Globalization.NumberStyles.Currency, null, out decimalVal))
                    {
                        buffer = decimalVal;
                    }
                    else
                    {
                        buffer = 0;
                    }
                    break;
                case "System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                case "System.Double":
                    double doubleVal;
                    if(Double.TryParse(criteria.ToString(), out doubleVal))
                    {
                        buffer = doubleVal;
                    }
                    else
                    {
                        buffer = 0;
                    }
                    break;
                case "System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                case "System.Boolean":
                    // need to manually convert numbers
                    if(criteria.ToString() == "0")
                    {
                        buffer = false;
                    }
                    else if(criteria.ToString() == "-1")
                    {
                        buffer = true;
                    }

                    bool boolVal;
                    if(buffer == null && Boolean.TryParse(criteria.ToString(), out boolVal))
                    {
                        buffer = boolVal;
                    }
                    break;
                case "System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                case "System.DateTime":
                    DateTime dateVal;
                    if(DateTime.TryParse(criteria.ToString(), out dateVal))
                    {
                        buffer = dateVal;
                    }
                    else
                    {
                        buffer = DateTime.Now;
                    }
                    break;
                default:
                    // string
                    buffer = criteria.ToString();
                    break;
            }

            return buffer;

        }

        #endregion

    }
}
