using FoundationApplication.DataTypes;
using FoundationApplication.TypeCasting;
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
			// VARIABLE DECLARATIONS
			int SelectExample;
			int AnotherValue;
			int Value;

			// DECLARING THE PATH STRING
			string VariablesPath = "C# Variables - Variables";

			// CREATING THE OBJECT TO CALL THE METHODS
			VariablesCS variables = new VariablesCS();
			ConstantCS constant = new ConstantCS();
			DisplayVariables displayVariables = new DisplayVariables();
			MulltipleVariables mulltipleVariables = new MulltipleVariables();
			DataTypesCS dataTypes = new DataTypesCS();
			TypeCastingCS typeCasting = new TypeCastingCS();

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

			Value = Convert.ToInt32(Console.ReadLine());

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

					AnotherValue = Convert.ToInt32(Console.ReadLine());

					switch (AnotherValue)
					{

						case 1:
							Console.Write("\n 1. Example 1 " +
											  "\n 2. Examplen 2 " +
											  "\n 3. Example 3" +
											  "\n\n What Are You Looking For: ");

							 SelectExample = Convert.ToInt32(Console.ReadLine());

							switch (SelectExample)
							{
								case 1:
									Console.WriteLine($"\n{VariablesPath}\n");
									variables.Example1();
									break;

								case 2:
									Console.WriteLine($"\n{VariablesPath}\n");
									variables.Example2();
									break;

								case 3:
									Console.WriteLine($"\n{VariablesPath}\n");
									variables.Example3();
									break;
							}
							break;

						case 2:
							Console.Write("1. Example 1" +
								"\n\nWhat Are You Looking For: ");

							SelectExample = Convert.ToInt32(Console.ReadLine());

							switch (SelectExample)
							{
								case 1:
									constant.Example1();
									break;
							}
							break;

						case 3:
							Console.Write("1. Example 1" +
								         "\n2. Example 2" +
										 "\n3. Example 3" +
								"\n\nWhat Are You Looking For: ");
							SelectExample = Convert.ToInt32(Console.ReadLine());

							switch (SelectExample)
							{
								case 1:
									displayVariables.Example1();
									break;

								case 2:
									displayVariables.Example2();
									break;

								case 3:
									displayVariables.Example3();
									break;
							}

							break;

						case 4:
							Console.Write("1. Example 1 \n" +
											  "2. Example 2" +
											  "\n\n What Are You Looking For: ");
							SelectExample = Convert.ToInt32(Console.ReadLine());

							switch (SelectExample)
							{
								case 1:
									mulltipleVariables.Example1();
									break;

								case 2:
									mulltipleVariables.Example2();
									break;
							}
							break;
					}
					break;






				case 2:
					Console.Write("1. Integer" +
								 "\n2. Long" +
								 "\n3. Float" +
								 "\n4. Double" +
								 "\n5. Scientific" +
								 "\n6. Boolean" +
								 "\n7. Charecter" +
								 "\n8. Strings" +
								 "\n\n What Are You Looking For: ");

					SelectExample = Convert.ToInt32(Console.ReadLine());

					switch (SelectExample)
					{
						case 1:
							dataTypes.Inti();
							break;

						case 2:
							dataTypes.Longer();
							break;

						case 3:
							dataTypes.Floating();
							break;

						case 4:
							dataTypes.Double();
							break;

						case 5:
							dataTypes.Scientific();
							break;

						case 6:
							dataTypes.Boolean();
							break;

						case 7:
							dataTypes.Character();
							break;

						case 8:
							dataTypes.Strings();
							break;
					}

					break;





				case 3:
					Console.WriteLine("1. Implicit \n" +
									  "2. Explicit" +
									  "\n\n What Are You Looking For: ");

					SelectExample = Convert.ToInt32(Console.ReadLine());

						switch (SelectExample)
						{
							case 1:
								typeCasting.Implicit();
								break;

							case 2:
								typeCasting.Explicit();
								break;
						}

					break;
			}
			Console.ReadKey();
		}
	}
}