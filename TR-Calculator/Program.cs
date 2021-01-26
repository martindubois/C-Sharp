
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TR-Calculator/Program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR_Calculator
{
    class Calculator
    {

        public Calculator()
        {
            mStack = new LinkedList<double>();
        }

        public void Add()
        {
            double lA = Pop();
            double lB = Pop();

            double lVal = lB + lA;

            Console.Write(lB);
            Console.Write(" + ");
            Console.Write(lA);
            Console.Write(" = ");
            Console.WriteLine(lVal);

            Push(lVal);
        }

        public void Div()
        {
            double lA = Pop();
            double lB = Pop();

            double lVal = lB / lA;

            Console.Write(lB);
            Console.Write(" / ");
            Console.Write(lA);
            Console.Write(" = ");
            Console.WriteLine(lVal);

            Push(lVal);
        }

        public void Mul()
        {
            double lA = Pop();
            double lB = Pop();

            double lVal = lB * lA;

            Console.Write(lB);
            Console.Write(" * ");
            Console.Write(lA);
            Console.Write(" = ");
            Console.WriteLine(lVal);

            Push(lVal);
        }

        public double Pop()
        {
            double lResult = mStack.Last.Value;

            mStack.RemoveLast();

            return lResult;
        }

        public void Push(double aValue)
        {
            mStack.AddLast(aValue);
        }

        public void Sub()
        {
            double lA = Pop();
            double lB = Pop();

            double lVal = lB - lA;

            Console.Write(lB);
            Console.Write(" - ");
            Console.Write(lA);
            Console.Write(" = ");
            Console.WriteLine(lVal);

            Push(lVal);
        }

        public void Reset()
        {
            mStack = new LinkedList<double>();
        }

        private LinkedList<double> mStack;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator lCalculator = new Calculator();

            for (; ; )
            {
                Console.Write("> ");

                String lLine = Console.ReadLine();

                if ("Exit"  == lLine) { break; }
                if ("Reset" == lLine) { lCalculator.Reset(); continue; }

                if ("+" == lLine) { lCalculator.Add(); continue; }
                if ("/" == lLine) { lCalculator.Div(); continue; }
                if ("*" == lLine) { lCalculator.Mul(); continue; }
                if ("-" == lLine) { lCalculator.Sub(); continue; }

                if ("" == lLine) { continue; }

                lCalculator.Push(Convert.ToDouble(lLine));
            }
        }
    }
}
