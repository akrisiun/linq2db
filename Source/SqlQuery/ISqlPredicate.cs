using System;

namespace LinqToDB.SqlQuery
{
    public interface ISqlPredicate : IQueryElement, ISqlExpressionWalkable, ICloneableElement
    {
        bool CanBeNull { get; }
        PrecedenceLevel Precedence { get; }
    }
}
