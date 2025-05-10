using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationApplication.DataTypes
{
	public class DataTypesCS
	{
		public void Inti()
		{
			int MyNum = 124;
			Console.WriteLine(MyNum);
		}

		public void Longer()
		{
			long MyNum = 9223372036854775807;
			Console.WriteLine(MyNum);
		}

		public void Floating()
		{
			float MyNum = 5.75F;
			Console.WriteLine(MyNum);
		}

		public void Double()
		{
			double MyNum = 19.990;
			Console.WriteLine(MyNum);
		}

		public void Scientific()
		{
			float f1 = 134e3F;
			double f2 = 134e5D;

			Console.WriteLine($"Float: {f1}");
			Console.WriteLine($"Double: {f2}");
		}

		public void Boolean()
		{
			bool PhoneCharged = true;
			bool PhoneNotCharged = false;

			Console.WriteLine(PhoneCharged);
			Console.WriteLine(PhoneNotCharged);
		}

		public void Character()
		{
			char MyChar = 'A';
			Console.WriteLine(MyChar);
		}

		public void Strings() 
		{
			string Greeting = "Good Moarnning!";
			Console.WriteLine(Greeting);
		}
	}
}