using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string newfunction = StringGenerator();

            Console.WriteLine(newfunction);
            Console.Read();

        }

        public static string StringGenerator()
        {
            string function = "";
            Random rnd = new Random();
            int rand = 0;
            rand = rnd.Next(20);

            function = function + rnd.Next(20);

            if (rand < 5)
                function = function + "+";
            else if (rand < 10 && rand > 4)
                function = function + "-";
            else if (rand < 15 && rand > 9)
                function = function + "*";
            else
                function = function + "/";

            function = function + rnd.Next(20);

            while (rnd.Next(20) > 4)
            {
                if (rand > 9)
                {
                    function = function + rnd.Next(1000);

                    if (rand < 5)
                        function = function + "+";
                    else if (rand < 10 && rand > 4)
                        function = function + "-";
                    else if (rand < 15 && rand > 9)
                        function = function + "*";
                    else
                        function = function + "/";

                    function = function + rnd.Next(20);
                    rand = rnd.Next(20);
                }
                else
                {
                    function = function + "(";
                    function = function + rnd.Next(20);

                    if (rand < 5)
                        function = function + "+";
                    else if (rand < 10 && rand > 4)
                        function = function + "-";
                    else if (rand < 15 && rand > 9)
                        function = function + "*";
                    else
                        function = function + "/";

                    function = function + rnd.Next(20);
                    function = function + ")";

                    if (rand < 5)
                        function = function + "+";
                    else if (rand < 10 && rand > 4)
                        function = function + "-";
                    else if (rand < 15 && rand > 9)
                        function = function + "*";
                    else
                        function = function + "/";

                    while (rnd.Next(20) < 10)
                    {
                        function = function + "(";
                        function = function + rnd.Next(20);

                        if (rand < 5)
                            function = function + "+";
                        else if (rand < 10 && rand > 4)
                            function = function + "-";
                        else if (rand < 15 && rand > 9)
                            function = function + "*";
                        else
                            function = function + "/";

                        rand = rnd.Next(20);
                        function = function + rand;
                        function = function + ")";

                        if (rand < 5)
                            function = function + "+";
                        else if (rand < 10 && rand > 4)
                            function = function + "-";
                        else if (rand < 15 && rand > 9)
                            function = function + "*";
                        else
                            function = function + "/";

                    }
                }
            }
            if (rand < 5)
                function = function + "+";
            else if (rand < 10 && rand > 4)
                function = function + "-";
            else if (rand < 15 && rand > 9)
                function = function + "*";
            else
                function = function + "/";

            function = function + rnd.Next(20);

            return function;
        }
    }
}
