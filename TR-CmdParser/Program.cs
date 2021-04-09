
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TR-CmdParser/Program.cs

using System;

namespace TR_CmdParser
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lContinue = true;

            do
            {
                // Do not display the command prompt when the commands are
                // read from a file.
                if (!Console.IsInputRedirected)
                {
                    Console.WriteLine();
                    Console.Write("> ");
                }

                String lLine = Console.ReadLine();

                // Ignore empty lines and comments
                if ((0 < lLine.Length) && ('#' != lLine[0]))
                {
                    String[] lParts = lLine.Split();
                    if (0 < lParts.Length)
                    {
                        if      ("Count"   == lParts[0]) { Processor.Count(lParts); }
                        else if ("Echo"    == lParts[0]) { Processor.Echo(lParts); }
                        else if ("Exit"    == lParts[0]) { lContinue = false; }
                        else if ("Help"    == lParts[0]) { Help(); }
                        else if ("Info"    == lParts[0]) { Info(); }
                        else if ("Reverse" == lParts[0]) { Processor.Reverse(lParts); }
                        else { Console.WriteLine("Commande invalide"); }
                    }
                }
            }
            while (lContinue);
        }

        static void Help()
        {
            Console.WriteLine("Count [Word] ...     Count letter in words");
            Console.WriteLine("Echo [Message]       Echo the message");
            Console.WriteLine("Exit                 Exit the program");
            Console.WriteLine("Help                 Display the command list");
            Console.WriteLine("Info                 Display the information");
            Console.WriteLine("Reverse [Word] ...   Reverse the words order");
        }

        static void Info()
        {
            Console.WriteLine("This program has been modifier after the students of the \"Methods of developpement\" course reviewed it.");
        }

    }
}
