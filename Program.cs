using System;
namespace MyApplication
{
    public class Program
    {
static void Main()
{
    int valueOne;
    int valueTwo;
    Console.WriteLine("Please Enter Number valueOne");
    valueOne = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("Please Enter Number valurTwo");
    valueTwo = Convert.ToInt32(Console.ReadLine());
    int Result = valueOne+valueTwo;
    //Console.WriteLine(Result); 
    Console.WriteLine("Result is two value are add" +Result);
}
    }
    
}
