using System;
using System.Threading;

class ThreadProgram
{
    /// <summary>
    /// Used to print "Simple Thread" 5 times
    /// </summary>
    public void WorkThreadFunction()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Simple Thread");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate ThreadProgram
        ThreadProgram tp = new ThreadProgram();

        // Instantiate thread and adds delegate
        // refrence (WorkThreadFunction) to thread
        Thread thread = new Thread(new ThreadStart(tp.WorkThreadFunction));

        // Starts thread, calls WorkThreadFunction from thread
        thread.Start(); 

        Console.Read();
    }
}