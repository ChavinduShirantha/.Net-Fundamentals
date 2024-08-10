using System;
namespace VCSample
{
    public class Circle
    {
        public static void Main(string[] args)
        {
            const double pi = 3.14159;      //constant declaration
            double r;                       //variable declaration
            r = 10.5;
            double area = pi * r * r;       //Area of Circle Formula
            double circumference = 2 * pi * r;  //Circumference of Circle Formula
            Console.WriteLine("Area of Circle is: {0}", area);
            Console.WriteLine("Circumference of Circle is: {0}", circumference);
        }
    }
}