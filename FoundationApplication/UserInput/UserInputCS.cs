using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationApplication.UserInput
{
	public class UserInputCS
	{
		public void Example1()
		{
			Console.Write("Enter The Username: ");
			string Username = Console.ReadLine();

			Console.WriteLine($"Your Username is: {Username}");
		}

		public void Example2() 
		{
			Console.Write("Enter Your 4 Digit PIN: ");
			int MobileNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"Your 4 Digit PIN: {MobileNumber}");
		}

	}
}