using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choisis le programme : 1 ou 2");
            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    Programme1.Lancer();
                    break;
                case "2":
                    Programme2.Lancer();
                    break;
                default:
                    Console.WriteLine("Choix invalide");
                    break;
            }
        }
    }
    class Programme1
    {
        public static void Lancer()
        {
            Console.WriteLine("Programme 1 exécuté !");
        }
    }

    class Programme2
    {
        public static void Lancer()
        {
            Console.WriteLine("Programme 2 exécuté !");
        }
    }
}
