using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    public class RationalStruct : IComparable
    {
        private int numerator;
        public int Numerator
        {
            get { return numerator; }
        }


        public int Denomerator
        {
            get;
            private set;
        } = 1;

        public RationalStruct(int numerator, int denomerator)
        {
            this.numerator = numerator;
            Denomerator = denomerator;

            ReduceToLowestTerms();


        }
        public double Value
        {
            get { return (double)Numerator / Denomerator; }
        }
        public int CompareTo(object obj)
        {
            return Value.CompareTo(((RationalStruct)obj).Value);
        }
        public override string ToString()
        {
            return "(" + Numerator + "/" + Denomerator + ")";
        }
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            // Equals should not throw exception even when obj is null or of other type
            if (!(obj is RationalStruct))
                return false;

            RationalStruct rs = (RationalStruct)obj;
            return Value == rs.Value;
        }
        //Finding Greatest Common Divisor Recursive
        public static int GCDRecursiveS(int Numerator, int Denomerator)
        {
            if (Numerator == 0)
                return Denomerator;
            if (Denomerator == 0)
                return Numerator;
            if (Numerator > Denomerator)
                return GCDRecursiveS(Numerator % Denomerator, Denomerator);
            else
                return GCDRecursiveS(Numerator, Denomerator % Numerator);
        }
        //Reducing the Fraction to its Lowest Terms
        private void ReduceToLowestTerms()
        {
            int greatestCommonDivisor = RationalStruct.GCDRecursiveS(numerator, Denomerator);
            numerator /= greatestCommonDivisor;
            Denomerator /= greatestCommonDivisor;
        }
    }
}
