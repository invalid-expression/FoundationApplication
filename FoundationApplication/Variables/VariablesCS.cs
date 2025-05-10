using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationApplication.Variables
{
	public class VariablesCS
	{
		public void Example1()
		{
			Console.WriteLine("EX.1) Create a variable called name of type string and assign it the value \"John\":");
			string Name = "John";
			Console.WriteLine(Name);
		}

		public void Example2()
		{
			Console.WriteLine("EX.2) Create a variable called myNum of type int and assign it the value 15:");
			int myNum = 15;
			Console.WriteLine(myNum);
		}

		public void Example3()
		{
			Console.WriteLine("EX.3) Change the value of myNum to 20:");
			int myNum = 15;
			myNum = 20;
			Console.WriteLine(myNum);
		}
	}
}
