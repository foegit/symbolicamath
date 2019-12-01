using System;

namespace SymbolicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constant
            Constant c = new Constant(2);
            print(c);

            // Variable
            Variable x = new Variable("x", c);
            Variable u = new Variable("u", new Pow(c, c));
            Variable v = new Variable("v", new Exp(new Constant(Math.E)));
            print(x);

            // Sin
            Sin sinx = new Sin(x);
            print(sinx);

            // Cos
            Cos cosx = new Cos(x);
            print(cosx);

            // Exp
            Exp ex = new Exp(x);
            print(ex);

            // Ln
            Ln lnx = new Ln(x);
            print(lnx);

            // Tg
            Tg tgx = new Tg(x);
            print(tgx);

            // Ctg
            Ctg ctgx = new Ctg(x);
            print(ctgx);

            // Add
            Add add = new Add(u, v);
            print(add);

            // Substract
            Subsctract sub = new Subsctract(u, v);
            print(sub);

            // Mult
            Mult mult = new Mult(u, v);
            print(mult);

            // Div
            Div div = new Div(u, v);
            print(div);

        }

        static void print(Expression exp) {
            Console.WriteLine($"\n* {exp.toString()} = {exp.calc()}");
            Console.Write($"* ({exp.toString()})' = {exp.diff().toString()} = {exp.diff().calc()}\n");
        }
    }
}
