using System;

namespace W3CSchool
{
	class Rectangle
	{
		// 封装
		private double length;
		private double width;

		// 属性
		public double Length
		{
			get => length;
			set
			{
				if (length >= 0)
				{
					length = value;	
				}
			}
		}

		public double Width
		{
			get => width;
			set
			{
				if (length >= 0)
				{
					width = value;
				}
			}
		}

		// 构造方法
		public Rectangle(double length, double width)
		{
			Length = length;
			Width = width;
		}

		public void Acceptdetails()
		{
			Console.WriteLine("Please enter the Length:");
			Length = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Please enter the Width:");
			Width = Convert.ToDouble(Console.ReadLine());

		}

		public double GetArea()
		{
			return Length * Width;
		}

		public void Display()
		{
			Console.WriteLine("Length: {0}", Length);
			Console.WriteLine("Width: {0}", Width);
			Console.WriteLine("Area: {0}", GetArea());
		}

		public static void UnitTest()
		{
			Console.WriteLine("For example:");
			Rectangle r = new Rectangle(4.0, 3.8);
			r.Display();
			Console.WriteLine();
			r.Acceptdetails();
			r.Display();
			Console.WriteLine();
		}
	}
}