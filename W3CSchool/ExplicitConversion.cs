using System;

namespace W3CSchool
{
	class ExplicitConversion
	{
		public static void UnitTest()
		{
			double d = 5673.74;
			int i;
			int i1 = 75;
			float f = 53.005f;
			double d1 = 2345.7652;
			bool b = true;

			i = (int)d; // 强制转换double为int，直接截断

			Console.WriteLine(i); // 5673
			Console.WriteLine(i1.ToString()); // 75
			Console.WriteLine(f.ToString()); // 53.005
			Console.WriteLine(d1.ToString()); // 2345.6752
			Console.WriteLine(b.ToString()); // Ture
			Console.WriteLine();
		}
	}
}