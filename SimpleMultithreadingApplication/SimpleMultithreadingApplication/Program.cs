﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SimpleMultithreadingApplication
{
    class Program
    {
        static void FirstThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(20);
                Console.WriteLine("Первый поток говорит: Hello!");
            }
            Console.WriteLine("Завершение первого потока");
        }
        static void SecondThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("Второй поток говорит: World!");
            }
            Console.WriteLine("Завершение второго потока");
        }
        static void ThirdThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(90);
                Console.WriteLine("Третий поток говорит: Hello World!");
            }
            Console.WriteLine("Завершение третьего потока");
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            Thread thread2 = new Thread(new ThreadStart(SecondThread));
            Thread thread3 = new Thread(new ThreadStart(ThirdThread));

            thread1.Start();
            thread2.Start();
            thread3.Start();

            Console.WriteLine("Главный поток молчит");
            Console.WriteLine("Завершение главного потока");
            Console.ReadLine();  
        }
    }
}
