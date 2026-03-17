using System;
using System.Collections.Generic;
using System.Linq;

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
        static int[] tableau = null;

        public static void Lancer()
        {
            Console.WriteLine("Programme 2 exécuté !");

            Initialisation(); // étape obligatoire

            int choix;
            do
            {
                Console.WriteLine("\n=== MENU ENTIER ===");
                Console.WriteLine("1. Afficher");
                Console.WriteLine("2. Trier");
                Console.WriteLine("3. Min / Max");
                Console.WriteLine("0. Quitter");
                Console.Write("Choix : ");

                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        Afficher();
                        break;
                    case 2:
                        Trier();
                        break;
                    case 3:
                        MinMax();
                        break;
                }

            } while (choix != 0);
        }

        static void Initialisation()
        {
            Console.WriteLine("1. Remplissage manuel");
            Console.WriteLine("2. Tableau aléatoire");
            Console.Write("Choix : ");

            int choix = int.Parse(Console.ReadLine());

            Console.Write("Taille du tableau : ");
            int n = int.Parse(Console.ReadLine());

            tableau = new int[n];

            if (choix == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Valeur {i} : ");
                    tableau[i] = int.Parse(Console.ReadLine());
                }
            }
            else if (choix == 2)
            {
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                    tableau[i] = rnd.Next(0, 100);

                Console.WriteLine("Tableau généré !");
            }
        }

        static void Afficher()
        {
            Console.WriteLine(string.Join(" ", tableau));
        }

        static void Trier()
        {
            Array.Sort(tableau);
            Console.WriteLine("Trié : " + string.Join(" ", tableau));
        }

        static void MinMax()
        {
            Console.WriteLine("Min = " + tableau.Min());
            Console.WriteLine("Max = " + tableau.Max());
        }
    }
}