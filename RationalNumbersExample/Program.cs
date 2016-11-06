using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    class Program
    {
        static void Swap(ref RationalStruct rs1, ref RationalStruct rs2)
        {
            RationalStruct temp = rs1;
            rs1 = rs2;
            rs2 = temp;

        }
        static void Swap(ref RationalClass rn1, ref RationalClass rn2)
        {

            RationalClass temp = rn1;
            rn1 = rn2;
            rn2 = temp;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n" + "--- RationalStruct ---");

            RationalStruct rs = new RationalStruct(5, 8);
            RationalStruct rs1 = new RationalStruct(10, 8);
            RationalStruct rs2 = new RationalStruct(4, 6);
            RationalStruct rs3 = rs2;

            Console.WriteLine("Rational - rs: " + rs + " and Quotient is: " + rs.Value);
            Console.WriteLine("Rational - rs1: " + rs1 + " and Quotient is: " + rs1.Value);
            Console.WriteLine("Rational - rs2: " + rs2 + " and Quotient is: " + rs2.Value);
            Console.WriteLine("Rational - rs3: " + rs3 + " and Quotient is: " + rs3.Value);

            Console.WriteLine("\n" + "--- CompareTo ---");
            Console.WriteLine(rs.Value + " < " + rs1.Value + " is " + (rs.CompareTo(rs1) < 0 ? "true" : "false"));

            Console.WriteLine("\n" + "--- Testing for equality ---");
            // Testing  for equality (operator == is not implicitly defined for structs, and Equals for value types implicitly compares their values)
            Console.WriteLine(rs + " " + ((rs.Equals(rs1)) ? "equals" : "doesn't equal") + " " + rs1);
            Console.WriteLine(rs + " " + ((rs.Equals(rs2)) ? "equals" : "doesn't equal") + " " + rs2);
            Console.WriteLine(rs + " " + ((rs.Equals(rs3)) ? "equals" : "doesn't equal") + " " + rs3);

            Console.WriteLine("\n" + "--- RationalClass ---");

            RationalClass rn = new RationalClass(9, 4);
            RationalClass rn1 = new RationalClass(10, 6);
            RationalClass rn2 = rn1;


            Console.WriteLine("Rational - rn: " + rn + " and Quotient is: " + rn.Value);
            Console.WriteLine("Rational - rn1: " + rn1 + " and Quotient is: " + rn1.Value);
            Console.WriteLine("Rational - rn2: " + rn2 + " and Quotient is: " + rn2.Value);


            Console.WriteLine("\n" + "--- CompareTo ---");
            Console.WriteLine(rn.Value + " < " + rn1.Value + " is " + (rn.CompareTo(rn1) < 0 ? "true" : "false"));

            Console.WriteLine("\n" + "--- Testing for equality ---");
            // Testing points for equality
            Console.WriteLine(rn + " " + ((rn == rn1) ? "==" : "<>") + " " + rn1);
            Console.WriteLine(rn + " " + ((rn.Equals(rn2)) ? "equals" : "doesn't equal") + " " + rn2);




        }
    }
}