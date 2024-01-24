using System;
using System.Linq;

class Linqexpmpl
{
    public static void Main(string[] args)
    {
        List<int> lst=new List<int>() { 1,2,3,4,5,6,7,8,9,10};
        //linq query to select odd number
        var oddnumber=from num in lst
                      where num%2 != 0 && num>1
                      select num;
        Console.WriteLine("oddnumber are:");
        foreach(var num in oddnumber)
        {
            Console.WriteLine(num+" ");//o/p:3,5,7,9
        }

    }
}