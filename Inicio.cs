using System;
using System.Threading;

namespace Cronometro
{
    class Inicio
    {
        public static void Start(int time)
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
            Console.WriteLine("StopWatch Finalizado...");
            Thread.Sleep(2500);
            Menu();
   
        }
        public static void Menu()
        {
            Console.WriteLine("S - Segundos");
            Console.WriteLine("M - Minutos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();
            //o códig abaixo serve para pegar o último caractere digitado pelo usuário.
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int segundos = 1;

            if (type == 'm')
                segundos = 60;
            if (time == 0)
                Environment.Exit(0);

            PreStart(time * segundos);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Gooo....");
            Thread.Sleep(2500);
            
            Inicio.Start(time);
        }
        
    }  
}
