using System;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var myInt = InvokeTwoPlusOne(2);

            var userInput1 = Console.ReadLine();
            //Console.WriteLine(userInput1);

            var list = new List<int>();

            list.Add(myInt);

            Console.WriteLine(list[0]);

        }

        static int InvokeTwo()
        {
            return 2;
        }

        static int InvokeTwoPlusOne(int myInt)
        {
            return myInt + 1;
        }
    }
}
