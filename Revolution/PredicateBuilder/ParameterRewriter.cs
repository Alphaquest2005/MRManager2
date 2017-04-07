using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace PredicateBuilder
{
    public class ParameterRewriter : ExpressionVisitor
    {

        readonly ParameterExpression candidate;
        readonly ParameterExpression replacement;

        public ParameterRewriter(ParameterExpression candidate, ParameterExpression replacement)
        {
            this.candidate = candidate;
            this.replacement = replacement;
        }

        protected override Expression VisitParameter(ParameterExpression expression)
        {
            return ReferenceEquals(expression, candidate) ? replacement : expression;
        }
    } 
}
