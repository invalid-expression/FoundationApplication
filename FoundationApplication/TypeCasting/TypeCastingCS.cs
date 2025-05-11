using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationApplication.TypeCasting
{
	public class TypeCastingCS
	{
		public void Implicit()
		{
			int MyNum = 10;
			double MyDouble = MyNum;
			Console.WriteLine(MyDouble);
		}

		public void Explicit()
		{
			double MyDouble = 10.235;
			int MyInt = (int) MyDouble;

			Console.WriteLine(MyInt);
		}
	}
}
