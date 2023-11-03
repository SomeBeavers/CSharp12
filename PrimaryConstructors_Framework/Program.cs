using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructors_Framework
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		class MyClass(string name)
		{
			public string GetName() =>  name;
		}
	}
}
