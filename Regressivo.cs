using System;
using System.Threading;


namespace Cronometro
{
    class Regressivo
    {
        public static void Regresso(int time)
        {
            
            Console.Clear();
            for(int i = 0; i <= time; time--)
            {
                Console.WriteLine(time);
                Thread.Sleep(2500);
            }
            Console.Clear();
            Console.WriteLine("StopWatch Finalizado...");
            Thread.Sleep(2500);
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundos");
            Console.WriteLine("M - Minutos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int segundos = 1;

            if (type == 'm')
                segundos = 60;
            if (time == 0)
                Environment.Exit(0);
            PreRegresso(time * segundos);
        }

        static void PreRegresso(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GOOOOOO...");
            Thread.Sleep(1000);

            Regresso(time);
        }
    }
}
