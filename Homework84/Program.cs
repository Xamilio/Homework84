using System;
//1
//class Program
//{
//	static void Main()
//	{
//		double[] sides = new double[5];
//		Console.WriteLine("Введите длины сторон пятиугольника:");
//		for (int i = 0; i < sides.Length; i++)
//		{
//			Console.Write($"Сторона {i + 1}: ");
//			sides[i] = Convert.ToDouble(Console.ReadLine());
//
//		}
//		double perimeterArrayMethod = CalculatePerimeterUsingArrayMethod(sides);
//		Console.WriteLine($"Периметр (System.Array): {perimeterArrayMethod}");
//		double perimeterManual = CalculatePerimeterManually(sides);
//		Console.WriteLine($"Периметр (вручную): {perimeterManual}");
//	}
//
//	static double CalculatePerimeterUsingArrayMethod(double[] sides)
//	{
//		return sides.Sum();
//	}
//	static double CalculatePerimeterManually(double[] sides)
//	{
//		double sum = 0;
//		for (int i = 0; i < sides.Length; i++)
//		{
//			sum += sides[i];
//		}
//		return sum;
//	}
//}

//2
//class Program
//{
//	static void Main()
//	{
//		double[] profits = new double[12];
//		Console.WriteLine("Введите прибыль фирмы за 12 месяцев:");
//		for (int i = 0; i < profits.Length; i++)
//		{
//			Console.Write($"Месяц {i + 1}: ");
//			profits[i] = Convert.ToDouble(Console.ReadLine());
//		}
//		int maxProfitMonth = FindMaxProfitMonth(profits);
//		Console.WriteLine($"Месяц с максимальной прибылью: {maxProfitMonth + 1}, Прибыль: {profits[maxProfitMonth]}");
//		int minProfitMonth = FindMinProfitMonth(profits);
//		Console.WriteLine($"Месяц с минимальной прибылью: {minProfitMonth + 1}, Прибыль: {profits[minProfitMonth]}");
//	}
//	static int FindMaxProfitMonth(double[] profits)
//	{
//		int maxIndex = 0;
//		for (int i = 1; i < profits.Length; i++)
//		{
//			if (profits[i] > profits[maxIndex])
//			{
//				maxIndex = i;
//			}
//		}
//		return maxIndex;
//	}
//	static int FindMinProfitMonth(double[] profits)
//	{
//		int minIndex = 0;
//		for (int i = 1; i < profits.Length; i++)
//		{
//			if (profits[i] < profits[minIndex])
//			{
//				minIndex = i;
//			}
//		}
//		return minIndex;
//	}
//}


//3

class Program
{
	static void Main()
	{
		int[] numbers = new int[10];
		Random rand = new Random();
		for (int i = 0; i < numbers.Length; i++)
		{
			numbers[i] = rand.Next(-9, 10);
		}
	}
	static int FindSumOfOddElements(int[] numbers)
	{
		int sum = 0;
		foreach (var num in numbers)
		{
			if (num % 2 != 0)
			{
				sum += num;
			}
		}
		return sum;
	}

	static int FindSumOfElementsWithOddIndices(int[] numbers)
	{
		int sum = 0;
		for (int i = 1; i < numbers.Length; i += 2)
		{
			sum += numbers[i];
		}
		return sum;
	}
}