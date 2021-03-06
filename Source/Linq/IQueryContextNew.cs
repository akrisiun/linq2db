﻿using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace LinqToDB.Linq
{
	using Data;

	public interface IQueryContextNew : IDisposable
	{
		int                   ExecuteNonQuery   ();
		object                ExecuteScalar     ();
		IDataReader           ExecuteReader     ();
		Task<DataReaderAsync> ExecuteReaderAsync(CancellationToken cancellationToken);
	}
}
