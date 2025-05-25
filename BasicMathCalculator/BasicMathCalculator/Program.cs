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
			Multipication multipication = new Multipication();
			Substraction substraction = new Substraction();
			Division division = new Division();
			Percentage percentage = new Percentage();

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
				substraction.Subtract();
			}
			else if(option == 'C' || option == '3')
			{
				multipication.Multi();
			}
			else if(option == 'D' || option == '4')
			{
				division.Div();
			}
			else if (option == 'E' || option == '5')
			{
				percentage.Perc();
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
