using System;
using System.Threading;

class Program
{
    /// <summary>
    /// Used to print "C# threading is easy" 5 times
    /// </summary>
    static void ThreadMethod()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("C#-tårdning er nemt!");
        }
    }

    static void Main(string[] args)
    {
        // Adds the ThreadMethod to the thread delegate
        Thread threadProgram = new Thread(ThreadMethod);

        // Starts the thread
        threadProgram.Start();
    }
}