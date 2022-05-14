using System;
using System.Threading;
using System.IO;

namespace ControlRemoto
{

    class Program
    {
        static void Main(string[] args)
        {
            string comando = "";

            while (true)
            {
                comando = Console.ReadKey(true).KeyChar.ToString().ToLower();
                Console.WriteLine(comando);
            }
        }
    }
}

