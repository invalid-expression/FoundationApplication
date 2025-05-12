using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationApplication.Operators
{
	public class AssignmentCS
	{
		public int x;
		public int y;
		public void Assignment()
		{
			x = 5;

			Console.WriteLine($"Assingment (=): {x}");
		}

		public void AddAssign()
		{
			x = 5;
			x += 2;

			Console.WriteLine(x);
		}

		public void SubstractAssign()
		{
			x = 5;
			x -= 2;

			Console.WriteLine(x);
		}

		public void MultiplyAssign() 
		{
			x = 5;
			x *= 2;

			Console.WriteLine(x);
		}

		public void DivideAssign()
		{
			x = 5;
			x /= 2;

			Console.WriteLine(x);
		}

		public void ModulusAssign()
		{
			x = 5;
			x %= 2;

			Console.WriteLine(x);
		}

	}
}