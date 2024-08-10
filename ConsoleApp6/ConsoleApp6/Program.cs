using System;
class Boxing
{
    public static void Main(string[] args)
    {
        //assigned int value
        //2021 to n
        int n = 2021;

        //Boxing
        object obj = n;

        //value of n to be change 500
        n = 500;

        System.Console.WriteLine("Value type of is n is : {0}", n);
        System.Console.WriteLine("Object/Reference type of is obj is : {0}",obj);
    }
}