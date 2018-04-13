using System;

namespace W3CSchool
{
	class DeclaringConstants
	{
		public static void UnitTest()
		{
			const double pi = 3.14159;  // 常量声明
			double r;

			Console.Write("Enter Radius: ");
			r = Convert.ToDouble(Console.ReadLine());
			double areaCricle = pi * r * r;
			Console.WriteLine("Radius: {0}, Area: {1}", r, areaCricle);
			Console.WriteLine();
		}
	}
}