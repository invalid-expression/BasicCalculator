using BasicMathCalculator.Basic;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathCalculator
{
	public class Program
	{
		static void Main(string[] args)
		{
			Addition addition = new Addition();

			Console.Write("Hey There! May I know your name?: ");
			var Name = Console.ReadLine();

			Console.WriteLine("\n");

			var PreviewName = Name.Trim();
			var Date = DateTime.UtcNow;
			PreviewName = char.ToUpper(PreviewName[0]) + PreviewName.Substring(1).ToLower().Trim();

			Console.WriteLine("******************************************************************************");
			Console.Write($"Good Moarnning {PreviewName}, Its {Date} And What You Are Looking For: \n" +
				$"\nA. Addition" +
				$"\nB. Substraction" +
				$"\nC. Multipication" +
				$"\nD. Division" +
				$"\nE. Percentage" +
				$"\nQ. Quit The Programme" +
				$"\n\n   Choose The Option: ");
			char option = Console.ReadLine()[0];

			Console.WriteLine("");

			option = char.ToUpper(option);

			if (option == 'A' || option == '1')
			{
				addition.Add();
			}
			else if(option == 'B' || option == '2')
			{
				Console.WriteLine("Substraction Here");
			}
			else if(option == 'C' || option == '3')
			{
				Console.WriteLine("Mulltipication Here");
			}
			else if(option == 'D' || option == '4')
			{
				Console.WriteLine("Division Here");
			}
			else if (option == 'E' || option == '5')
			{
				Console.WriteLine("Percentage Here");
			}
			else if(option == 'Q' || option == '6')
			{
				Environment.Exit(0); 
			}
			else
			{
				Console.WriteLine("Invalid Selection, Please Try Again!");
			}
			Console.ReadKey();

		}
	}
}
