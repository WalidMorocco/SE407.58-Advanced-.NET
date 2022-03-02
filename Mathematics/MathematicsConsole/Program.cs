using Mathematics;
using System;

namespace MathematicsConsole
{
    class Program
    {
        private static double _num1;
        private static double _num2;
        private static string _operand;
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            //foreach (var a in args)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();
            AreArgumentsValid(args);
            var math = new BasicMath();
        }

        public static void AreArgumentsValid(String[] args)
        {
            _operand = args[1].ToLower();
            _num1 = NumParser(args[2]);
            _num2 = NumParser(args[3]);
            Console.WriteLine("All arguments are valid !");
            Console.ReadLine();

        }

        public static double NumParser(string arg)
        {
            double number;
            if (Double.TryParse(arg, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine($"Unable to parse {arg}.");
                Environment.Exit(99);
            }

            return 0;   
        }
    }
}
