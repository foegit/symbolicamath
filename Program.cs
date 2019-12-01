using System;

namespace SymbolicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constant
            Constant c = new Constant(2);
            print(c, 20);

            // Variable
            Variable x = new Variable();
            print(x, 10);

            // Sin
            Sin sin = new Sin(x);
            print(sin, 10);

            // Cos
            Cos cos = new Cos(sin);
            print(cos, 1);

            // Exp
            Exp ex = new Exp(x);
            print(ex, 1);

            // Ln
            Ln lnx = new Ln(x);
            print(lnx, 2);

            // Tg
            Tg tgx = new Tg(x);
            print(tgx, 1);

            // Ctg
            Ctg ctgx = new Ctg(x);
            print(ctgx, 1);


            Sin u = new Sin(x);
            Cos v = new Cos(x);
            // Add
            Add add = new Add(u, v);
            print(add, 0);

            // Substract
            Subsctract sub = new Subsctract(u, v);
            print(sub, 10);

            // Mult
            Mult mult = new Mult(u, v);
            print(mult, 4.4);

            // Div
            Div div = new Div(u, v);
            print(div, 5.5);

            // Pow
            Pow pow = new Pow(sin, new Constant(2));
            print(pow, 2);

            // Polynomial
            Polynomial p = new Polynomial(x, new double[]{-1, 2, 7});
            print(p, 2);

            // Integral
            Mult t = new Mult(x, x); // x^x
            Console.WriteLine($"* Int({t.toString()}, -2, 2): {Integral.Rectancles(t, -2, 10)}");

            // Equation
            Add eq = new Add(new Variable(), new Constant(2)); // x + 2 [x = 2]
            Subsctract eq2 = new Subsctract(new Pow(x, new Constant(2)), new Constant(10)); // x^2 - 10 [x1 = 3.1623, x2 = -3.1623]

            Console.WriteLine($"* Equ({eq.toString()}, -2, 2): {Equator.Dichotomy(eq, -3, 2)}");
            Console.WriteLine($"* Equ({eq2.toString()}, -10, 10): {Equator.Dichotomy(eq2, -10, 10)}");
        }

        static void print(Function exp, double x) {
            Console.WriteLine($"\n* x = {x}");
            Console.WriteLine($"* fn: {exp.toString()} = {exp.calc(x)}");
            Console.Write($"* fn': {exp.diff().toString()} = {exp.diff().calc(x)}\n");
        }
    }
}
