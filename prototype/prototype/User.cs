using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace prototype
{
	[Serializable]
	public class User
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public Address Address { get; set; }


		public User ShallowCopy ()
		{
			return (User) this.MemberwiseClone();
		}

		public User DeepCopy ()
		{
			var memoryStream = new MemoryStream();
			var binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream, this);
			memoryStream.Position = 0;
			return (User) binaryFormatter.Deserialize(memoryStream);
		}


	}
}
