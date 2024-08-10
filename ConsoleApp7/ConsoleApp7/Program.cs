using System;
class Unboxing
{
    public static void Main(string[] args)
    {
        //assigned int value
        //25 to n
        int n = 25;

        //Boxing
        object obj = n;

        //Unboxing
        int i = (int)obj;

        //value of n to be change 500
        n = 500;

        System.Console.WriteLine("Value of obj object is : {0}", obj);
        System.Console.WriteLine("Value of i  is : {0}", i);
    }
}