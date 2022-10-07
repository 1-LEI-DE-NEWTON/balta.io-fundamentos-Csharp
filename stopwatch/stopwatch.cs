
using System;
using System.Threading;

namespace StopWatch;

    public class StopWatch
    {

        static void Main (string[] args)
            {
                Menu();
            }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = SEGUNDO => 10S = 10 SEGUNDOS");
            Console.WriteLine("M = MINUTO => 1M  = 1 MINUTO");
            Console.WriteLine(("0 = SAIR"));
            Console.WriteLine("Quanto tempo deseja calcular?");
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1,1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            
            int multiplier = 1;
            if (type == 'm')
                multiplier = 60;
            
            if (time == 0)
                System.Environment.Exit(0);
            
            Start(time * multiplier);

        }
        
        static void Start(int time)
            {
                int currentTime = 0;

                while (currentTime != time) 
                {
                    Console.Clear();
                    currentTime++;
                    Console.WriteLine(currentTime);
                    Thread.Sleep(1000);
                }
                Console.Clear();
                Console.WriteLine("Stopwatch finalizado");
                Thread.Sleep(2500);
                Menu();
            }

    }
    
