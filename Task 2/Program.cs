using System;
using System.Threading;

class Program
{
    /// <summary>
    /// Used to print "C# threading is easy" 10 times
    /// </summary>
    static void ThreadMethod()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("C#-tårdning er nemt!");
            Thread.Sleep(1000);

            // **** Threads sleep answer 
            // Thread sleep can be used in any thread if it makes sense.
            // But you should definitely avoid to use it in the main thread 
            // to avoid your program locking up
        }
    }

    static void Main(string[] args)
    {
        // Adds the ThreadMethod to both of the threads delegate
        Thread threadProgram1 = new Thread(ThreadMethod);
        Thread threadProgram2 = new Thread(ThreadMethod);

        // Starts the threads
        threadProgram1.Start();
        threadProgram2.Start();
    }
}