using System;
namespace ConsoleAppForDelegates{
   
public delegate T Transformer<T>(T arg);

public class Util{
    public static void Transform<T>(T[] values, Transformer<T> t)
    {
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = t(values[i]);
        }
    }
}

public class Test
{
    static void Main(){
        int[] values = {1,2,3};
        Util.Transform(values,Square); //Hook in Square
        foreach (int i in values)
            System.Console.WriteLine(i + "  ");     
        
    }
    static int Square(int x)=>x*x;
}






}
