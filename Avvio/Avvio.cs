using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Avvio
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("CEPICS v 4.0.162");
            WriteLine();
            WriteLine("-----------------------------------------------------");
            WriteLine();
            WriteLine("Caricamento Database Completato");
            WriteLine();
            WriteLine("Inserire numero carta di credito per proseguire:");
            ReadLine();
            WriteLine();
            WriteLine("Cancellazione Database FsSoa in corso...");
            ReadKey();

        }
    }
}
