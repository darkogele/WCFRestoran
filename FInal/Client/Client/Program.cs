using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DigitronReference;

namespace Client
{
    class Program
    {
        
        static void Main(string[] args)
        {
           

            Console.WriteLine("Vnesi 2 broja za sobiranje  ");
            var smetanje = new DigitronClient();
            // prvBroj = int.Parse(Console.ReadKey());
            //var vtorBroj = Convert.ToInt32(Console.ReadKey());
            int prvi = Convert.ToInt32(Console.ReadLine());
            int vtori = Convert.ToInt32(Console.ReadLine());
            //ConsoleKeyInfo prvBroj = Console.ReadKey();
            //ConsoleKeyInfo vtorBroj = Console.ReadKey();

            //int prvi = int.Parse(prvBroj.KeyChar.ToString());
            //int vtori = int.Parse(vtorBroj.KeyChar.ToString());

            Console.WriteLine(smetanje.Plus(prvi,vtori));

            Console.WriteLine(smetanje.Plus(30,20));
            Console.WriteLine(smetanje.Minus(30,20));
            Console.WriteLine(smetanje.Mnozi(30,20));
            Console.WriteLine(smetanje.Deli(30,20));
            Console.ReadLine();
        }
    }
}
