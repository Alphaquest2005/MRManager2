using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PredicateBuilder;

namespace Utilities
{
    public static class Predicate
    {
        public static Expression<Func<T, bool>> GetTypePredicate<T>(GenSoft.Interface.IPredicate predicate)
        {
            var typeChain = new List<string>(predicate.Path.Split('.')) {predicate.Operation};
            return GetTypePredicate<T>(typeChain, predicate.Value);
        }
        private static Expression<Func<T, bool>> GetTypePredicate<T>(List<string> typeChain, string valueCheck)
        {
            return
                (Expression<Func<T, bool>>)typeof(Instance)
                    .GetMethod("Build", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                    .MakeGenericMethod(typeof(T))
                    .Invoke(null, new object[] { typeChain, OperatorType.Equal, valueCheck, null });
        }
    }
}
