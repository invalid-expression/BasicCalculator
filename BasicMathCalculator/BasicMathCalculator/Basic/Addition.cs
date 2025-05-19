using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathCalculator.Basic
{
	public class Addition
	{
		double num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, Total;
        public void Add()
		{
			Console.Write("Are You Want To Do More Then 2-Number's Addition? (Y-N): ");
			char Response = Console.ReadLine()[0];

			Response = char.ToUpper(Response);
			if (Response == 'Y')
			{
				Console.Write("Enter How Many Numbers Addition You Want To Do? (3-5): ");
				int Number = Convert.ToInt32(Console.ReadLine());

				switch (Number)
				{
					case 3:
						Console.Clear();
						Console.WriteLine("******************************************************************************");
						Console.WriteLine("\nAddition");

						Console.Write(Global.Global.FIRN);
						num1 = Convert.ToInt32(Console.ReadLine());

						Console.Write(Global.Global.SECN);
						num2 = Convert.ToInt32(Console.ReadLine());

						Console.Write(Global.Global.THRN);
						num3 = Convert.ToInt32(Console.ReadLine());

						Total = num1 + num2 + num3;
						Console.WriteLine($"Your Total: {Total}");
					break;

					case 4:
						Console.Clear();
						Console.WriteLine("******************************************************************************");
						Console.WriteLine("\nAddition");

						Console.Write(Global.Global.FIRN);
						num1 = Convert.ToInt32(Console.ReadLine());

						Console.Write(Global.Global.SECN);
						num2 = Convert.ToInt32(Console.ReadLine());

						Console.Write(Global.Global.THRN);
						num3 = Convert.ToInt32(Console.ReadLine());

						Console.Write(Global.Global.FORN);
						num4 = Convert.ToInt32(Console.ReadLine());

						Total = num1 + num2 + num3 + num4;
						Console.WriteLine($"Your Total: {Total}");
					break;

					case 5:
						Console.Clear();
						Console.WriteLine();
						Console.WriteLine("\nAddition");

						Console.WriteLine("******************************************************************************");

						Console.Write(Global.Global.FIRN);
						num1 = Convert.ToInt32(Console.ReadLine());

						Console.Write(Global.Global.SECN);
						num2 = Convert.ToInt32(Console.ReadLine());

						Console.Write(Global.Global.THRN);
						num3 = Convert.ToInt32(Console.ReadLine());

						Console.Write(Global.Global.FORN);
						num4 = Convert.ToInt32(Console.ReadLine());

						Console.Write(Global.Global.FIFN);
						num4 = Convert.ToInt32(Console.ReadLine());

						Total = num1 + num2 + num3 + num4 + num5;
						Console.WriteLine($"Your Total: {Total}");
					break;
				}
			}
		}
	}
}
