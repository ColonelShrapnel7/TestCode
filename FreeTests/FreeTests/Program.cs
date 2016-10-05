using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpreadsheetUtilities;
using System.Text.RegularExpressions;

namespace FreeTests
{
    class Program
    {

        static void Main(string[] args)
        {
            double num;
            List<String> ThisList = new List<String>();
            List<String> objList = new List<String>();
            //Formula form1 = new Formula("2+2");
            //Console.WriteLine(form1.ToString());
            //Console.WriteLine(normalizer("x2"));

            ThisList.Add("x");
            //ThisList.Add("+");
            //ThisList.Add("X");
            objList.Add("x");
            //objList.Add("+");
            //objList.Add("X");



            Console.WriteLine(Object.ReferenceEquals(ThisList, objList));
            Console.ReadLine();
        }

        public static bool validator(String s)
        {
            if (s == "x1" || s == "X1" || s == "y1" || s == "Y1")
            {
                return true;
            }
            return false;
        }

        public static String normalizer(String s)
        {
            String a = s.ToUpper();
            return a;
        }

        private static IEnumerable<string> GetTokens(String formula)
        {
            // Patterns for individual tokens
            String lpPattern = @"\(";
            String rpPattern = @"\)";
            String opPattern = @"[\+\-*/]";
            String varPattern = @"[a-zA-Z_](?: [a-zA-Z_]|\d)*";
            String doublePattern = @"(?: \d+\.\d* | \d*\.\d+ | \d+ ) (?: [eE][\+-]?\d+)?";
            String spacePattern = @"\s+";

            // Overall pattern
            String pattern = String.Format("({0}) | ({1}) | ({2}) | ({3}) | ({4}) | ({5})",
                                            lpPattern, rpPattern, opPattern, varPattern, doublePattern, spacePattern);

            // Enumerate matching tokens that don't consist solely of white space.
            foreach (String s in Regex.Split(formula, pattern, RegexOptions.IgnorePatternWhitespace))
            {
                if (!Regex.IsMatch(s, @"^\s*$", RegexOptions.Singleline))
                {
                    yield return s;
                }
            }

        }

    }
}
