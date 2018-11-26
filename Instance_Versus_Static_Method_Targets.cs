using System;

namespace ConsoleAppForDelegates
{
    public delegate void ProgressReporter(int percentComplete);
    class Test
    {
        static void Main()
        {
            X x = new X();
            ProgressReporter p = x.InstanceProgress;
            p(99);                            //99
            Console.WriteLine(p.Target == x); //True
            Console.WriteLine(p.Method);      //Void InstanceProgress(Int32)
        }
    }
    class X
    {
        public void InstanceProgress(int percentComplete) =>
            Console.WriteLine(percentComplete);
    }

}
