using System;


namespace W3CSchool
{
	class DecisionMaking
	{
		public static void UnitTest()
		{
			//Switch();
			//Console.WriteLine();
			//Nesting_Switch();
			Nesting_if();
		}

		static void Switch()    // switch 语句
		{
			Console.WriteLine("Please enter your grade in A, B, C, D, or E:");

			char grade = Convert.ToChar(Console.ReadLine());
			//Console.WriteLine("{0}", grade);

			switch (grade)
			{
				case 'A':
					Console.WriteLine("Excellent! You got A!");
					break;
				case 'B':
					Console.WriteLine("Very good! You got B!");
					break;
				case 'C':
					Console.WriteLine("Good! You got C!");
					break;
				case 'D':
					Console.WriteLine("Pass! You got D!");
					break;
				case 'E':
					Console.WriteLine("You'd better try again! You got F!");
					break;
				default:
					Console.WriteLine("INVAILD RESULT!");
					break;
			}
		}

		static void Nesting_Switch()
		{
			int a = 100;
			int b = 200;

			switch (a)
			{
				case 100:
					Console.WriteLine("这是外部 switch 的一部分");
					switch (b)
					{
						case 200:
							Console.WriteLine("这是内部 switch 的一部分");
							break;
					}
					break;
			}
			Console.WriteLine("a 的准确值是 {0}", a);
			Console.WriteLine("b 的准确值是 {0}", b);
		}	// 嵌套 switch 语句

		static void Nesting_if()	// 嵌套 if 语句
		{
			int a = 100;
			int b = 200;

			if(a ==100)
			{
				// 如果条件为真，则检查下面的条件
				if (a == 100)
				{
					if (b == 200)
					{
						Console.WriteLine("a 的值是100，且 b 的值是 200");
					}
				}
			}
			Console.WriteLine("a 的准确值是 {0}", a);
			Console.WriteLine("b 的准确值是 {0}", b);
		}
	}
}