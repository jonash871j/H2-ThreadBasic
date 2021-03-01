﻿using System;
using System.Threading;

class Program
{
    static char currentCharacter = '*';

    static void InputThread()
    {
        while(true)
        {
            currentCharacter = Console.ReadKey().KeyChar;
        }
    }
    static void OutputThread()
    {
        while(true)
        {
            Console.Write(currentCharacter);
            Thread.Sleep(50);
        }
    }

    static void Main(string[] args)
    {
        // Adds the InputThread the first thread delegate
        Thread inputThread = new Thread(InputThread);

        // Adds the OutputThread the second thread delegate
        Thread logicThread = new Thread(OutputThread);

        // Starts the threads
        inputThread.Start();
        logicThread.Start();
    }
}