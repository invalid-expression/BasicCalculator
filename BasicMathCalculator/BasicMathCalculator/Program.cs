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
				$"\n\n   Choose The Option: " );
			char option = Console.ReadLine()[0];

			Console.WriteLine("");

			option = char.ToUpper(option);

			if(option == 'A')
			{
				Console.WriteLine("Addition Here");
			}
			else if(option == 'B')
			{
				Console.WriteLine("Substraction Here");
			}
			else if(option == 'C')
			{
				Console.WriteLine("Mulltipication Here");
			}
			else if(option == 'D')
			{
				Console.WriteLine("Division Here");
			}
			else if (option == 'E')
			{
				Console.WriteLine("Percentage Here");
			}
			else if(option == 'Q')
			{
				Environment.Exit(0); 
			}
			Console.ReadKey();

		}
	}
}
