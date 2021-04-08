
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// REVUE Conherence <
//    \  Le nom du fichier dans le commantaire ne correspond pas au nom du
//     \ fichier.
// File    TR-Calculator/Program.cs

using System;
// REVUE Lisibilite <
//     \ Les 4 "using" qui suivent semblent innutiles.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR_CmdParser
{
    class Program
    {
        // REVUE Coherence & Lisibilite <
        //    \  Le nom de la variable "Ligne" est en francais alors que le
        //     \ reste du code semble en anglais.
        // REVUE Maintenabilite <<
        //  \    Il ne semble pas avoir de raison pour que la variable
        //   \   "Ligne" soit un membre de la classe. Elle pourrait
        //    \  probablement etre une variable locale dans la methode
        //     \ "Main".
        static String Ligne;

        static void Main(string[] args)
        {
            // REVUE Lisibilite <
            //     \ Le nom de la variable "Cont" me semble peu significatif.
            bool Cont = true;

            do
            {
                Console.WriteLine();
                Console.Write("> ");

                Ligne = Console.ReadLine();

                bool OK = false;

                // REVUE Coherence & Lisibilite <<<
                //    \  La commande "Compter" est en francais, alors que la
                //     \ plupart des autres commandes sont en anglais.
                // REVUE Maintnabilite <
                //    \  La liste des conditions pour les commandes est
                //     \ longue.
                // REVUE Fonctionnalite <<<
                //   \   La command "Compter" accepte un argument, mais si un
                //    \  argument est passe, la condition ne fonctionne pas.
                //     \ IMPORTANT: Les tests devraient verifier ce cas.
                if ("Compter" == Ligne)
                {
                    Compter(Ligne);
                    OK = true;
                }

                // REVUE Optimisation <
                //    \  Les conditions pour les commandes s'executent tous
                //     \ meme si la commande est deja identifiee et executee.
                // REVUE Fonctionnalite <<<
                //   \   La command "Echo" accepte un argument, mais si un
                //    \  argument est passe, la condition ne fonctionne pas.
                //     \ IMPORTANT: Les tests devraient verifier ce cas.
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

                // REVUE Fonctionnalite <<<
                //   \   Il semble y avoir un erreur de "coller/copier"
                //    \  empechant d'executer la commande "Info".
                //     \ IMPORTANT: Les tests devraient verifier ce cas.
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

        // REVUE Coherence & Lisibilite <<
        //    \  Le nom de la methode est en francais, alors que le reste du
        //     \ code est en anglais.
        // REVUE Lisibilite <<
        //     \ Le nom de l'argument masque une variable membre.
        // REVUE Maintnabilite <<
        //    \  Le code de traitement devrait etre separe du code de
        //     \ traitement des commandes.
        static void Compter(String Ligne)
        {
            // REVUE Fonctionnalite <<<
            //   \   Si l'utilisateur ne passe pas d'argument, cette ligne
            //    \  plante.
            //     \ IMPORTANT: Les tests devraient verifier ce cas.
            // REVUE Maintnabilite <<
            //    \  Si le nom de la commande change, la constante "8" doit
            //     \ aussi etre change.
            String[] Words = Ligne.Substring(8).Split();

            for (int i = 0; i < Words.Length; i++)
            {
                Console.Write(Words[i].Length);
                Console.Write(" ");
            }

            // REVUE Coherence & Lisibilite <
            //    \  Le reste du code semble utiliser "Console.WriteLine"
            //     \ plutot que le "\n".
            Console.Write("\n");
        }

        // REVUE Lisibilite <<
        //     \ Le nom de l'argument masque une variable membre.
        static void Echo(String Ligne)
        {
            // REVUE Lisibilite <
            //     \ Le commentaire est innutile.
            // Afficher l'argument!
            // REVUE Fonctionnalite <<<
            //   \   Si l'utilisateur ne passe pas d'argument, cette ligne
            //    \  plante.
            //     \ IMPORTANT: Les tests devraient verifier ce cas.
            // REVUE Maintnabilite <<
            //    \  Si le nom de la commande change, la constante "5" doit
            //     \ aussi etre change.
            Console.WriteLine(Ligne.Substring(5));
        }

        static void Help()
        {
            // REVUE Coherence & Lisibilite <<<
            //     \ Melange de francais et d'anglais.
            // REVUE Coherence & Lisibilite <
            //     \ Melange de "Console.WriteLine" et de "\n".
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

        // REVUE Coherence & Lisibilite <<
        //    \  Le nom de la methode est en francais, alors que le reste du
        //     \ code est en anglais.
        // REVUE Fonctionnalite <<<
        //     \ La methode "Inverser" n'est jamais appelee.
        // REVUE Lisibilite <<
        //     \ Le nom de l'argument masque une variable membre.
        static void Inverser(String Ligne)
        {
            // REVUE Coherence & Lisibilite <
            //    \  Le nom de la variable est en francais, alors que le
            //     \ reste du code est en anglais.
            // REVUE Coherence & Lisibilite <
            //    \  Le nom de la variable est prefixe par un l et aucun
            //     \ autre nom utilise cette nomenclature.
            // REVUE Maintnabilite <<
            //    \  Le code qui divise les argument en mots et duplique
            //     \ dans plusieurs methodes.
            // REVUE Fonctionnalite <<<
            //   \   Si l'utilisateur ne passe pas d'argument, cette ligne
            //    \  plante.
            //     \ IMPORTANT: Les tests devraient verifier ce cas.
            // REVUE Maintnabilite
            //    \  Si le nom de la commande change, la constante 9 doit
            //     \ aussi etre change.
            String[] lMots = Ligne.Substring(9).Split();

            // REVUE Lisibilite <
            //     \ Code en commentaire.
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
