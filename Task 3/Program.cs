using System;
using System.Threading;

class Program
{
    static Random random = new Random();

    static void ThreadMethod()
    {
        int warnings = 0;

        while(warnings < 3)
        {
            // Gets random temperature between -20 to 120
            int temperature = random.Next(-20, 120);

            // Prints temperature
            Console.WriteLine($"Tråd: {temperature}C°");

            // Checks if temperature is in a unacceptable range
            if ((temperature < 0) || (temperature > 100))
            {
                // Increment warning
                warnings++;

                // Prints warning
                Console.WriteLine($"Tråd: Advarsel { warnings }: temperaturen ligger uden for det tiladte inteval!");
            }

            // Waits for 2 seconds before taking new temperature test
            Thread.Sleep(2000);
        }
    }

    static void Main(string[] args)
    {
        // Creates thread, that executes ThreadMethod
        Thread t = new Thread(ThreadMethod);

        // Starts thread
        t.Start();
 
        // Check if thread is active
        while(t.IsAlive)
        {
            Console.WriteLine("Main: Tråden er aktiv!");
            Thread.Sleep(10000);
            Console.WriteLine("Main: Tester om tråden stadig er aktiv!");
        }

        // Joins thread to main thread 
        t.Join();

        // Prints termination message
        Console.WriteLine("Main: Alarm-tråd termineret!");
        
        Console.Read();
    }
}