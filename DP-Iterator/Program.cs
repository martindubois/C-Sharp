
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    DP-Iterator/Program.cs

#define ENUMERATOR

#define LIST
// #define LINKED_LIST

using System;
using System.Collections.Generic;

#if LIST
    using Container = System.Collections.Generic.List<double>;
#endif

#if LINKED_LIST
    using Container = System.Collections.Generic.LinkedList<double>;
#endif

namespace DP_Iterator
{
    class Program
    {
        const int VALUE_COUNT = 1000000;

        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch lWatch = System.Diagnostics.Stopwatch.StartNew();

            // LinkedList<double> lValues = new LinkedList<double>();
            List<double> lValues = new List<double>();

            Random lRand = new Random();

            double lVal;

            for (int i = 0; i < VALUE_COUNT; i ++)
            {
                lVal = lRand.NextDouble();

                // lValues.AddLast(lVal);
                lValues.Add(lVal);
            }

            double lMax;
            double lMin;
            double lSum;

            // LinkedList<double>.Enumerator lEnum = lValues.GetEnumerator();
            List<double>.Enumerator lEnum = lValues.GetEnumerator();

            // lVal = lEnum.Current;
            lVal = lValues[0];

            lMax = lVal;
            lMin = lVal;
            lSum = lVal;

            // while (lEnum.MoveNext())
            // {
            //    lVal = lEnum.Current;

            for (int i = 1; i < VALUE_COUNT; i ++)
            {
                lVal = lValues[i];

                if (lMax < lVal)
                {
                    lMax = lVal;
                }

                if (lMin > lVal)
                {
                    lMin = lVal;
                }

                lSum += lVal;
            }

            long lElapsed_ms = lWatch.ElapsedMilliseconds;

            Console.Write("Elapsed time : ");
            Console.Write(lElapsed_ms);
            Console.WriteLine(" ms");

            Console.Write(lMin);
            Console.Write(" -> ");
            Console.Write(lSum / 100000.0);
            Console.Write(" -> ");
            Console.WriteLine(lMax);

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
