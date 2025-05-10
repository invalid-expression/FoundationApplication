using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationApplication.Variables
{
	public class DisplayVariables
	{
		public void Example1()
		{
			string Name = "John";
			Console.WriteLine($"{Name}");
		}

		public void Example2()
		{
			string FirstName = "John";
			string LastName = "Deccan";

			Console.WriteLine($"{FirstName} {LastName}");
		}

		public void Example3()
		{
			int x = 5;
			int y = 10;

			Console.Write($"Total of {x} and {y} is {x + y}");
		}
	}
}
