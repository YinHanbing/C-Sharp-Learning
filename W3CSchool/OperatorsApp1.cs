using System;

namespace W3CSchool
{
	class OperatorsApp1
	{
		public static void UnitTest()
		{
			Arithmrtic();
			Relation();
			Logic();
			Bit();
			Assignment();
			Size();
			Ternary();
			Priority();
			Console.WriteLine();
		}

		static void Arithmrtic()
		{
			int a = 21;
			int b = 10;
			int c;

			Console.WriteLine("These are Arithmrtic Operators: \nWhen a = 21, b = 10:");
			c = a + b;
			Console.WriteLine("a + b = {0}", c);
			c = a - b;
			Console.WriteLine("a - b = {0}", c);
			c = a * b;
			Console.WriteLine("a * b = {0}", c);
			c = a / b;
			Console.WriteLine("a / b = {0}", c);
			c = a % b;
			Console.WriteLine("a % b = {0}", c);
			c = a++;
			Console.WriteLine("a ++ = {0}", c);
			c = a--;
			Console.WriteLine("a -- = {0}", c);
		}

		static void Relation()
		{
			int a = 21;
			int b = 10;

			Console.WriteLine("\nThese are Operation Operators: \nWhen a = 21, b = 10:");
			if (a == b)
			{
				Console.WriteLine("a == b -- a 等于 b");
			}
			else
			{
				Console.WriteLine("a != b -- a 不等于 b");
			}
			if (a < b)
			{
				Console.WriteLine("a < b -- a 小于 b");
			}
			else
			{
				Console.WriteLine("a >= b -- a 不小于 b");
			}
			if (a > b)
			{
				Console.WriteLine("a > b -- a 大于 b");
			}
			else
			{
				Console.WriteLine("a <= b -- a 不大于 b");
			}
			/* change the value of a and b */
			Console.WriteLine("\nWhen a = 5, b = 20:");
			a = 5;
			b = 20;
			if (a <= b)
			{
				Console.WriteLine("a <= b -- a 小于或等于 b");
			}
			if (b >= a)
			{
				Console.WriteLine("b >= a -- b 大于或等于 a");
			}
		}

		static void Logic()
		{

			bool d = true;
			bool e = true;

			Console.WriteLine("\nThese are Logic Operators: \nWhen d and e are both ture:");

			if (d && e)
			{
				Console.WriteLine("d && e -- 条件为真");
			}
			if (d || e)
			{
				Console.WriteLine("d || e -- 条件为真");
			}
			/* change the value of d and e */
			d = false;
			e = true;
			Console.WriteLine("\nWhen d is false and e is ture:");
			if (d && e)
			{
				Console.WriteLine("d && e -- 条件为真");
			}
			else
			{
				Console.WriteLine("d && e -- 条件不为真");
			}
			if (!(d && e))
			{
				Console.WriteLine("!(d && e) -- 条件为真");
			}
		}

		static void Bit()	// 位操作符
		{
			Console.WriteLine("\nThese are Bit Operators: \nWhen a = 60, b = 13:");

			int a = 60;             /* 60 = 0011 1100 */
			int b = 13;             /* 13 = 0000 1101 */
			int c = 0;

			c = a & b;           /* 12 = 0000 1100 */
			Console.WriteLine("c = a & b -- c 的值是 {0}", c);

			c = a | b;           /* 61 = 0011 1101 */
			Console.WriteLine("c = a | b -- c 的值是 {0}", c);

			c = a ^ b;           /* 49 = 0011 0001 */
			Console.WriteLine("c = a ^ b -- c 的值是 {0}", c);

			c = ~a;               /*-61 = 1100 0011 */
			Console.WriteLine("c = ~a -- c 的值是 {0}", c);

			c = a << 2;     /* 240 = 1111 0000 */
			Console.WriteLine("a << 2 -- c 的值是 {0}", c);

			c = a >> 2;     /* 15 = 0000 1111 */
			Console.WriteLine("a >> 2 -- c 的值是 {0}", c);
		}

		static void Assignment()
		{
			int a = 21;
			//int b = 10;
			int c;

			a = 21;
			Console.WriteLine("\nThese are Assignment Operators: \nWhen a = 21:");

			c = a;
			Console.WriteLine("c = a 的值 = {0}", c);

			c += a;
			Console.WriteLine("c += a 的值 = {0}", c);

			c -= a;
			Console.WriteLine("c -= a 的值 = {0}", c);

			c *= a;
			Console.WriteLine("c *= a 的值 = {0}", c);

			c /= a;
			Console.WriteLine("c /= a 的值 = {0}", c);

			Console.WriteLine("\nWhen c = 200:");

			c = 200;
			c %= a;
			Console.WriteLine("c %= a 的值 = {0}", c);

			c <<= 2;
			Console.WriteLine("c <<= 2 的值 = {0}", c);   // 左移并赋值

			c >>= 2;
			Console.WriteLine("c >>= 2 的值 = {0}", c);   // 右移并赋值

			c &= 2;
			Console.WriteLine("c &= 2 的值 = {0}", c);

			c ^= 2;
			Console.WriteLine("c ^= 2 的值 = {0}", c);

			c |= 2;
			Console.WriteLine("c |= 2 的值 = {0}", c);
		}

		static void Size()	//	sizeof 运算符
		{
			Console.WriteLine("\nThese are Sizeof Operators:");

			Console.WriteLine("int 的大小是 {0}", sizeof(int));
			Console.WriteLine("short的大小是 {0}", sizeof(short));
			Console.WriteLine("double的大小是 {0}", sizeof(double));
		}

		static void Ternary()	// 三元运算符
		{
			int a, b;
			a = 10;
			
			Console.WriteLine("\nThese are Ternary Operators:");

			b = (a == 1) ? 20 : 30;
			Console.WriteLine("b 的值是 {0}", b);

			b = (a == 10) ? 20 : 30;
			Console.WriteLine("b 的值是 {0}", b);
		}

		static void Priority()	// 运算符优先级
		{
			int a = 20;
			int b = 10;
			int c = 15;
			int d = 5;
			int e;

			Console.WriteLine("\nThese are some example of priority of operators:");
			Console.WriteLine("a = 20, b = 10, c = 15, d = 5");

			e = (a + b) * c / d;    // (30 * 15) / 5
			Console.WriteLine("(a + b) * c / d 的值是 {0}", e);

			e = ((a + b) * c) / d;	// (30 * 15) / 5
			Console.WriteLine("((a + b) * c) / d 的值是 {0}", e);

			e = (a + b) * (c / d);	// (30 * 15) / (15 / 5) 
			Console.WriteLine("(a + b) * (c / d) 的值是 {0}", e);

			e = a + (b * c) / d;	// 20 + (150 / 5)
			Console.WriteLine("a + (b * c) / d 的值是 {0}", e);
			
		}
	}
}