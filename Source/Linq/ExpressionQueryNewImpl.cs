using System;
using System.Linq.Expressions;

namespace LinqToDB.Linq
{
	class ExpressionQueryImplNew<T> : ExpressionQueryNew<T>, IExpressionQuery
	{
		public ExpressionQueryImplNew(IDataContext dataContext, Expression expression)
			: base(dataContext, expression)
		{
		}

		public override string ToString()
		{
			return SqlText;
		}

        public override IDataContextInfo DataContextInfo { get { return null; } }
	}
}

//Error	1	Source file 'SqlQuery\Precedence.cs' could not be found	d:\webstack\WPF\linq2db\Source\CSC	LinqToDB.WindowsStore
