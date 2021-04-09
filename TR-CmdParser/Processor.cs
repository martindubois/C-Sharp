
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TR-CmdParser/Processor.cs

using System;

namespace TR_CmdParser
{
    class Processor
    {

        static public void Count(String [] aParts)
        {
            for (int i = 1; i < aParts.Length; i++)
            {
                Console.Write(" ");
                Console.Write(aParts[i].Length);
            }

            Console.WriteLine();
        }

        static public void Echo(String [] aParts)
        {
            for (int i = 1; i < aParts.Length; i++)
            {
                Console.Write(" ");
                Console.Write(aParts[i]);
            }

            Console.WriteLine();
        }

        static public void Reverse(String [] aParts)
        {
            for (int i = aParts.Length - 1; i >= 1; i--)
            {
                Console.Write(" ");
                Console.Write(aParts[i]);
            }

            Console.WriteLine();
        }

    }

}
