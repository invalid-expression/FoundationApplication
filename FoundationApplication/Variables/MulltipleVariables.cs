using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationApplication.Variables
{
	public class MulltipleVariables
	{
		public void Example1()
		{
			int x = 5, y = 6, z = 50;
			Console.WriteLine($"{x+y+z}");
		}

		public void Example2()
		{
			int x, y, z;
			x = y = z = 50;
			Console.WriteLine($"{x+y+z}");
		}
	}
}
