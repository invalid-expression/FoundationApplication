using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationApplication.Variables
{
	public class ConstantCS
	{
		public void Example1()
		{
			const int MyNum = 15;

			// MyNum = 20 (MyNum IS CONST SO YOU CANT ASSIGN ANOTHER VALUE TO THE MyNum)
			
			Console.WriteLine(MyNum);
		}
	}
}
