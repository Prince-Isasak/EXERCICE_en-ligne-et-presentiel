
                      Exercice1
using System;

namespace exos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer un numero");
            var Numero = Console.ReadLine();
            var NumeroTel = Convert.ToInt32(Numero);

            if (NumeroTel >= 1 && NumeroTel <= 10)
            Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}


                                 Exercice2
using System;

namespace exos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer le 1er nombre");
            var Nombre = Console.ReadLine();
            var Nombre1 = Convert.ToInt32(Nombre);

            Console.WriteLine("Entrer le 2eme nombre");
            var nombre = Console.ReadLine();
            var nombre2 = Convert.ToInt32(nombre);

            var max = (Nombre1 > nombre2) ? Nombre1 : nombre2;
            Console.WriteLine("Max is " + max);



        }
    }
}


                     Exercice3
using System;

namespace exos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("saisir la Largeur de l'image");
            var Lag = Console.ReadLine();
            var Largeur = Convert.ToInt32(Lag);


            Console.WriteLine("saisir la Hauteur de l'image");
            var Haut = Console.ReadLine();
            var Hauteur = Convert.ToInt32(Haut);

            var Position = (Largeur > Hauteur) ? iPosition.Paysage : iPosition.Portrait;
            Console.WriteLine("la position de l'image est: " + Position);

        }
        public enum iPosition
        {
            Paysage, Portrait
        }
    }
}


 
                        Exercise4()
using System;
using System.Collections.Generic;

namespace exos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer la limite de Vitesse de la voiture");
            var Limite = Console.ReadLine();
            var LimiteVitesse = Convert.ToInt32(Limite);

            Console.WriteLine("Entrer la limite de Vitesse de la voiture");
            var limiteV = Console.ReadLine();
            var LimiteVoiture = Convert.ToInt32(limiteV);

            if (LimiteVoiture < LimiteVitesse) ;
            Console.WriteLine("ok");

        }
    }
}

                                  Exercice5
using System;
using System.Collections.Generic;

namespace exos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> liste = new List<string>();
            while (true)
            {
                Console.WriteLine("Saisir Different noms");
                var Utilisateur = Console.ReadLine();
                if (Utilisateur == "Entrée")
                break;
                  else
                {
                    var User = Convert.ToInt32(Utilisateur);
                    liste.Add(Utilisateur);
                }
            }
        }
    }
}
                         Exercice6
using System;

namespace exos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer Votre Nom");
            var nom = Console.ReadLine();
            var Nom = new char[nom.Length];

            var reverse = new string(Nom);
            Console.WriteLine(" le Nom renverser est: " + reverse);

        }
    }

