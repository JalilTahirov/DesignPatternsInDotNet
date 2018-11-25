using System;

namespace ConsoleAppForDelegates
{
    delegate int Transformer(int x);

    class Util
    {
        public static void Transform (int[] values, Transformer t)
        {

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t (values[i]);   
            }
        }

        static void Main(string[] args)
        {
            int[] values = {1,2,3};
            Util.Transform(values,Square);
            foreach (int i in values)
            {
                System.Console.WriteLine(i+"  "); //1 4 9
            }
        }

        static int Square(int x)=> x * x; 
    }
}
