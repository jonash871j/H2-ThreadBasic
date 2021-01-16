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
            // Genrally it's a bad idea to use thread sleep and
            // it should definitely be avoided in the main scope.
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