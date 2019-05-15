using System;
using System.Collections.Generic;
using System.Text;

namespace dependencyInjection
{
	public static class Container
	{
		static Dictionary<Type, object> _registeredTypes = new Dictionary<Type, object>();

		public static void Register<T> (T toRegister)
		{
			_registeredTypes.Add(typeof(T), toRegister);
		}

		public static T Resolve<T> ()
		{
			return (T) _registeredTypes[typeof(T)];
		}
	}
}
