using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Conversions 
{
	 internal static void Dec2Bin (int number)
	{
		int Binary = 0;
		List<int> list = new List<int>();
		while (num1 >= 1)

		{
			int div = num1 / 2;
			Binary = num1 % 2;
			list.Add(Binary);
		}
		Console.Write($"Decimal to Binary: ");
		for (int i -list.Count - 1; i >= 0; i--)
		{
			Console.Write($"{list[i]}");
		}
		Console.WriteLine();
	}
}
