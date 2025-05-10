
using FoundationApplication.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FoundationApplication
{
	public class Program
	{
        public static void Main(string[] args)
		{
			// DECLARING THE PATH STRING
			string VariablesPath = "C# Variables - Variables";

			// CREATING THE OBJECT TO CALL THE METHODS
			VariablesCS variables = new VariablesCS();

			Console.Write("\n 1. Variables " +
						  "\n 2. Data Types " +
						  "\n 3. TYpe Casting " +
						  "\n 4. User Input " +
						  "\n 5. Operators " +
						  "\n 6. Math " +
						  "\n 7. Strings " +
						  "\n 8. Booleans " +
						  "\n 9. If-Else " +
						  "\n 10. Switch Statement " +
						  "\n 11. While Loop " +
						  "\n 12. For Loop " +
						  "\n 13. Break & Continue" +
						  "\n 14. Array" +
						  "\n\n What Are You Looking For: ");

			int Value = Convert.ToInt32(Console.ReadLine());

			switch (Value)
			{
				case 1:
					Console.Write("\n C# Variables " +
									  "\n 1. Variables " +
									  "\n 2. Constants " +
									  "\n 3. Display Variables " +
									  "\n 4. Multiple Variables " +
									  "\n 5. Identifiers" +
									  "\n\n What Are You Looking For: ");

					int AnotherValue = Convert.ToInt32(Console.ReadLine());

					switch (AnotherValue)
					{
						case 1:
							Console.WriteLine($"\n{VariablesPath}\n");
							variables.Example1();
							break;

						case 2:
							Console.WriteLine($"\n{VariablesPath}\n");
							variables.Example2();
							break;
					}

					break;


			}

			Console.ReadKey();
		}
	}
}
