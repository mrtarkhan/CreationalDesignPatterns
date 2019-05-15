using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	public interface IAbstractFactory
	{
		IInMemoryService CreateInMemoryServiceInstance ();
		ISqlServerService CreateSqlServiceServiceInstance ();

	}
}
