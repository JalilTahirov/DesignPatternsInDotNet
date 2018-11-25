using System;

namespace ConsoleAppForDelegates
{
    delegate int Transformer(int x);

    class Program
    {
        static void Main(string[] args)
        {
            Transformer t = Square;
            int result =t(3);
            
            Console.WriteLine(result);
        }

        static int Square(int x){return x*x;}
    }
}
