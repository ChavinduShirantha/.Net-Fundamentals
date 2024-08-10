using System;
namespace ITC
{
    class SampleTC
    {
        public static void Main(string[] args)
        {
            int i = 57;

            //implicit type conversion
            long l = i;

            //implicit type conversion
            float f = l;

            //Final Result
            Console.WriteLine("Integer Value" + i);
            Console.WriteLine("Long Value" + l);
            Console.WriteLine("Float Value" + f);
        }
    }
}