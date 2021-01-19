
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    DP-Iterator/Program.cs

#define ENUMERATOR

// #define LINKED_LIST
#define LIST

using System;
using System.Collections.Generic;
using System.Diagnostics;

#if LINKED_LIST
    using Container = System.Collections.Generic.LinkedList<double>;
#endif

#if LIST
    using Container = System.Collections.Generic.List<double>;
#endif

namespace DP_Iterator
{
    class Program
    {
        const int VALUE_COUNT = 1000000;

        static void Main(string[] args)
        {
            Stopwatch lWatch = Stopwatch.StartNew();

            Container lValues = new Container();

            Random lRand = new Random();

            double lVal;

            for (int i = 0; i < VALUE_COUNT; i ++)
            {
                lVal = lRand.NextDouble();

#if LINKED_LIST
                lValues.AddLast(lVal);
#endif

#if LIST
                lValues.Add(lVal);
#endif
            }

            double lMax;
            double lMin;
            double lSum;

#if ENUMERATOR
            Container.Enumerator lEnum = lValues.GetEnumerator();

            lVal = lEnum.Current;
#else
            lVal = lValues[0];
#endif

            lMax = lVal;
            lMin = lVal;
            lSum = lVal;

#if ENUMERATOR
            while (lEnum.MoveNext())
            {
                lVal = lEnum.Current;
#else
            for (int i = 1; i < VALUE_COUNT; i ++)
            {
                lVal = lValues[i];
#endif

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
