using System;
namespace ExpressionOperatorsSample
{
    class EOSample
    {
        static void Main(string[] args)
        {
            int result;
            int x = 10, y = 5;
            int a = 20, b;
            int res3;
            int r = 5, s = 10;
            int k = 15;

            //Division
            result = (x / y);
            Console.WriteLine("Division Operator : " + result);

            //Modulus
            result = (x % y);
            Console.WriteLine("Modulus Operator : " + result);

            //post-increment example:
            //b is assigned only 20
            b = a++;
            //a becomes 21 now
            Console.WriteLine("a is {0} and res is {1}", a, b);

            //Bitwise AND Operator
            res3 = r & s;
            Console.WriteLine("Bitwise AND : " + res3);

            //it means k = k + 10
            k += 10;
            Console.WriteLine("Add Assignment Operator : " + k);
        }
    }
}