using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace SalarApp.Framework
{
    public  class ExperssionHandler:ExpressionVisitor
    {
        List<string> propertyNames=new List<string>();

        public string GetPropertyName(Expression exp)
        {
            propertyNames.Clear();
            Visit(exp);
            propertyNames.Reverse();
            return string.Join(".", propertyNames);
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            propertyNames.Add(node.Member.Name);
            return base.VisitMember(node);
        }
    }
}