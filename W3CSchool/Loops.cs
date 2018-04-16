using System;

namespace W3CSchool
{
	class Loops
	{
		public static void UnitTest()
		{
			//L_While();
			//L_For();
			//L_Foreach();
			//L_DoWhile();
			L_Nesting();
		}

		static void L_While()   // while 循环
		{
			int a = 10;

			while (a < 20)
			{
				Console.WriteLine("a 的值：{0}", a);
				a++;
			}
		}

		static void L_For() // for 循环
		{
			for (int a = 10; a < 20; a += 1)
			{
				Console.WriteLine("a 的值：{0}", a);
			}
		}

		static void L_Foreach() //foreach 循环
		{
			// 通过 foreach 循环输出整型数组中的元素。
			int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };

			Console.WriteLine("使用 foreach 循环输出整型数组中的元素:");

			foreach (int element in fibarray)
			{
				Console.WriteLine(element);
			}
			Console.WriteLine();

			// 类似 foreach 循环
			Console.WriteLine("类似 foreach 的 for 循环:");

			for (int i = 0; i < fibarray.Length; i++)
			{
				Console.WriteLine(fibarray[i]);
			}
			Console.WriteLine();

			// 设置集合中元素的计算器
			int count = 0;

			Console.WriteLine("设置集合中元素的计算器");

			foreach (int element in fibarray)
			{
				count += 1;
				Console.WriteLine("Element #{0}: {1}", count, element);
			}
		}

		static void L_DoWhile() // do...while循环
		{
			int a = 10;

			do
			{
				Console.WriteLine("a 的值：{0}", a);
				a += 1;
			} while (a < 20);
		}

		static void L_Nesting() // 嵌套循环
		{
			// 寻找 2-100 内的质数
			int i, j;

			for (i = 2; i < 100; i++)
			{
				for (j = 2; j <= (i / j); j++)
				{
					if ((i % j) == 0) break;	// 若能整除，则不是质数
				}
				if (j > (i / j))
				{
					Console.WriteLine("{0} 是质数", i);
				}
			}

		}
	}
}
