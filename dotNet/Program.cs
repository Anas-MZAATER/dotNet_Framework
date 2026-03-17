using System;
using System.Collections.Generic;

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

            Dictionary<string, Action> exercices = new Dictionary<string, Action>()
            {
                { "somme",       Somme       },
                { "division",    Division    },
                { "permutation", Permutation },
                { "triangle",    Triangle    },
                { "binaire",     Binaire     }
            };

            while (true)
            {
                Console.WriteLine("\nMéthodes disponibles :");
                foreach (var key in exercices.Keys)
                    Console.WriteLine("- " + key);

                Console.Write("\nChoix : ");
                string choix = Console.ReadLine().ToLower();

                if (exercices.ContainsKey(choix))
                    exercices[choix]();
                else
                    Console.WriteLine("Méthode non trouvée !");
            }
        }

        static void Somme()
        {
            Console.Write("Entrez a : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Entrez b : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Somme = " + (a + b));
        }

        static void Division()
        {
            Console.Write("Entrez a : ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Entrez b : ");
            double b = double.Parse(Console.ReadLine());

            if (b != 0)
                Console.WriteLine("Résultat = " + (a / b));
            else
                Console.WriteLine("Division par zéro !");
        }

        static void Permutation()
        {
            Console.Write("Entrez a : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Entrez b : ");
            int b = int.Parse(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Après permutation : a={a}, b={b}");
        }

        static void Triangle()
        {
            Console.Write("Entrez le nombre : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Entrez la largeur : ");
            int largeur = int.Parse(Console.ReadLine());

            for (int i = 1; i <= largeur; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(n);
                Console.WriteLine();
            }
        }

        static void Binaire()
        {
            Console.Write("Entrez un nombre : ");
            int nombre = int.Parse(Console.ReadLine());

            Console.WriteLine("Binaire = " + Convert.ToString(nombre, 2));
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