
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-Calculator/Calculator.cs

using System.Collections.Generic;

namespace TT_Calculator
{

    public class Calculator
    {

        public Calculator()
        {
            mStack = new LinkedList<double>();
        }

        public double Add()
        {
            double lA = Pop();
            double lB = Pop();

            return Push(lB + lA);
        }

        public double Div()
        {
            double lA = Pop();
            double lB = Pop();

            return Push(lB / lA);
        }

        public double Mul()
        {
            double lA = Pop();
            double lB = Pop();

            return Push(lB * lA);
        }

        public double Push(double aValue)
        {
            mStack.AddLast(aValue);

            return aValue;
        }

        public void Reset()
        {
            mStack = new LinkedList<double>();
        }

        public double Sub()
        {
            double lA = Pop();
            double lB = Pop();

            return Push(lB - lA);
        }

        public int StackDept
        {
            get
            {
                return mStack.Count;
            }
        }

        private double Pop()
        {
            double lResult = mStack.Last.Value;

            mStack.RemoveLast();

            return lResult;
        }

        private LinkedList<double> mStack;

    }

}
