using System;
using System.Collections.Generic;
using System.Text;

    public class Calculator
    {
        private delegate double Operation(double x);

        private static double Square(double x)
        {
            return x * x;
        }

        private static double Cube(double x)
        {
            return x * x * x;
        }

        private static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        private static double Exp(double x)
        {
            return Math.Exp(x);
        }

        private static double Sin(double x)
        {
            return Math.Sin(x);
        }

        private static double Cos(double x)
        {
            return Math.Cos(x);
        }

        private static double Tan(double x)
        {
            return Math.Tan(x);
        }

        private static double Log(double x)
        {
            return Math.Log(x);
        }

        private static double Abs(double x)
        {
            return Math.Abs(x);
        }

        public static void Run()
        {
            Operation[] operations = new Operation[10];
            operations[0] = Square;
            operations[1] = Cube;
            operations[2] = Sqrt;
            operations[3] = Exp;
            operations[4] = Sin;
            operations[5] = Cos;
            operations[6] = Tan;
            operations[7] = Log;
            operations[8] = Abs;
            operations[9] = Math.Round;

            double x = 2.5;
            foreach (var op in operations)
            {
                double result = op(x);
                Console.WriteLine($"{op.Method.Name}({x}) = {result}");
                x = result;
            }
        }
    }
Calculator.Run();

