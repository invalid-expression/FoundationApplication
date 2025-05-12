using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationApplication.Operators
{
	public class ArithmeticCS
	{
		public int FirstNum;
		public int SecondNum;
		public int Total;
		public void Addition()
		{
			Console.Write("Enter The First Number: ");
			FirstNum = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter The Second Number: ");
			SecondNum = Convert.ToInt32(Console.ReadLine());

			Total = FirstNum + SecondNum;
			Console.WriteLine($"Your Total is: {Total}");
		}

		public void Subtraction()
		{
			Console.Write("Enter The First Number: ");
			FirstNum = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter The Second Number: ");
			SecondNum = Convert.ToInt32(Console.ReadLine());

			Total = FirstNum - SecondNum;
			Console.WriteLine($"Your Total is: {Total}");
		}

		public void Multiplication() 
		{
			Console.Write("Enter The First Number: ");
			FirstNum = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter The Second Number: ");
			SecondNum = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"Your Total is: {Total}");
		}

		public void Divison()
		{
			Console.Write("Enter The First Number: ");
			FirstNum = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter The Second Number: ");
			SecondNum = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"Your Total is: {Total}");
		}

		public void Modulus()
		{
			Console.Write("Enter The First Number: ");
			FirstNum = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter The Second Number: ");
			SecondNum = Convert.ToInt32(Console.ReadLine());

			Total = FirstNum % SecondNum;
			
			Console.WriteLine($"Your Total is: {Total}");
		}

		public void Increment()
		{
			Console.Write("Enter The Number To Increament: ");
			FirstNum = Convert.ToInt32(Console.ReadLine());

			FirstNum++;
			Console.WriteLine($"Your Increament Value is: {FirstNum}");
		}

		public void Decreament()
		{
			Console.Write("Enter The Value To Decreament: ");
			FirstNum = Convert.ToInt32(Console.ReadLine());

			FirstNum--;
			Console.WriteLine($"Your Deacreament Value is: {FirstNum}");
		}
	}
}
