
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TR-Calculator/Program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR_CmdParser
{
    class Program
    {
        static String Ligne;

        static void Main(string[] args)
        {
            bool Cont = true;

            do
            {
                Console.WriteLine();
                Console.Write("> ");

                Ligne = Console.ReadLine();

                bool OK = false;

                if ("Compter" == Ligne)
                {
                    Compter(Ligne);
                    OK = true;
                }

                if ("Echo" == Ligne)
                {
                    Echo(Ligne);
                    OK = true;
                }

                if ("Exit" == Ligne)
                {
                    Cont = false;
                    OK = true;
                }

                if ("Help" == Ligne)
                {
                    Help();
                    OK = true;
                }

                if ("Help" == Ligne)
                {
                    Info();
                    OK = true;
                }

                if (!OK)
                {
                    Console.WriteLine("Commande invalide");
                }
            }
            while (Cont);
        }

        static void Compter(String Ligne)
        {
            String[] Words = Ligne.Substring(8).Split();

            for (int i = 0; i < Words.Length; i++)
            {
                Console.Write(Words[i].Length);
                Console.Write(" ");
            }

            Console.Write("\n");
        }

        static void Echo(String Ligne)
        {
            // Afficher l'argument!
            Console.WriteLine(Ligne.Substring(5));
        }

        static void Help()
        {
            Console.WriteLine("Compter [Word] ...   Compter les lettres dans les mots");
            Console.WriteLine("Echo {Message}       Display the message");
            Console.WriteLine("Exit                 Terminer l'execution");
            Console.Write("Help                 Afficher l'aide\n");
            Console.Write("Info                 Display the information\n");
            Console.Write("Inverser [Mot] ...   Inverser l'ordre des mots\n");
        }

        static void Info()
        {
            Console.WriteLine("Programme ecrit pour etre reviser par les etudiants du cours \"Methodes de developpement\".");
        }

        static void Inverser(String Ligne)
        {
            String [] lMots = Ligne.Substring(9).Split();

            // for (int i = lMots.Length; i >= 0; i--)
            for (int i = lMots.Length - 1; i >= 0; i --)
            {
                Console.Write(lMots[i]);
                Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}
