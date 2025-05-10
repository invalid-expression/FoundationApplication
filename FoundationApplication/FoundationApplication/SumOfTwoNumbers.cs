using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationApplication
{
	public class SumOfTwoNumbers
	{
		public void SumofTwoNumber()
		{
			Console.Write("ENTER THE FIRST NUMBER:");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("ENTER THE SECOND NUMBER:");
			int num2 = Convert.ToInt32(Console.ReadLine());

			int total = num1 + num2;
			Console.WriteLine($"TOTAL:{total}");
		}
	}
}
