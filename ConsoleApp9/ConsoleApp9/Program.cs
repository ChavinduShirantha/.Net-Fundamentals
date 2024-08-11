using System;
namespace Conditional
{
	class IfStatement
	{
		public static void Main(string[] args)
		{
			int num = 15;
			if (num < 10)
			{
				Console.WriteLine("{0} is Less than 10", num);
			}
            Console.WriteLine("This statement is always executed");
        }
	}
}