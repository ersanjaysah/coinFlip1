using System;

namespace CoinFlip
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number you want to flip");
            int tossnumber = int.Parse(Console.ReadLine());
            Class1.flip(tossnumber);
        }
    }
}
