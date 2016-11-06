using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    public class RationalClass : IComparable
    {
        private int numerator;
        public int Numerator
        {
            get { return numerator; }
            private set { numerator = value; }
        }
        public int Denomerator
        {
            get;
            private set;
        } = 1;

        public RationalClass(int numerator, int denomerator)
        {
            Numerator = numerator;
            Denomerator = denomerator;

            ReduceToLowestTermsC();
        }
        public RationalClass(RationalClass rn) : this(rn.Numerator, rn.Denomerator)
        {

        }
        public double Value
        {
            get { return (double)Numerator / Denomerator; }
        }
        public int CompareTo(object obj)
        {
            return Value.CompareTo(((RationalClass)obj).Value);
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
            RationalClass rc = obj as RationalClass;
            if (rc == null)
                return false;

            return Value == rc.Value;
        }
        //Finding Greatest Common Divisor Recursive
        public static int GCDRecursiveC(int numerator, int denomerator)
        {
            if (numerator == 0)
                return denomerator;
            if (denomerator == 0)
                return numerator;
            if (numerator > denomerator)
                return GCDRecursiveC(numerator % denomerator, denomerator);
            else
                return GCDRecursiveC(numerator, denomerator % numerator);
        }
        //Reducing the Fraction to its Lowest Terms
        private void ReduceToLowestTermsC()
        {
            int greatestCommonDivisor = RationalClass.GCDRecursiveC(numerator, Denomerator);
            numerator /= greatestCommonDivisor;
            Denomerator /= greatestCommonDivisor;
        }
    }
}
