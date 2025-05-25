using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathCalculator.Basic
{
	public class Percentage
	{
		double Int1, Int2, Total;
		public void Perc()
		{
			Console.Write("Enter The First Number: ");
			Int1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter The Second Number: ");
			Int2 = Convert.ToInt32(Console.ReadLine());

			Total = Int1 / Int2;
			Total = Total * 100;

			Console.WriteLine($"Your Percentage: {Total}");
		}
	}
}
