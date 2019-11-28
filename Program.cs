using System;

namespace SymbolicMath
{
    class Program
    {
        static void Main(string[] args)
        {

            Constant a = new Constant(0);
            Constant b = new Constant(1);
            Constant e = new Constant(Math.E);

            print(new Sin(a));
            print(new Cos(a));

            // Expression sin = new Sin(a);
            // Expression cos = new Cos(b);
            // Expression tg = new Tg(b);
            // Expression ln = new Ln(e);
            // Expression exp = new Exp(e);
            // Expression ctg = new Ctg(b);

            // Expression p = new Constant(2);
            // Expression q = new Constant(5);
            // Expression add = new Add(ln, q);
            // Expression sub = new Subsctract(p, q);
            // Expression mult = new Mult(p, q);
            // Expression div = new Div(p, q);
            // Expression pow = new Pow(q, p);

            // double[] coef = new double[] {2, 3, 0, 0.5};
            // Expression polinomial = new Polynomial(q, coef);

            // print(sin);
            // print(cos);
            // print(tg);
            // print(ln);
            // print(exp);
            // print(ctg);
            // print(add);
            // print(sub);
            // print(mult);
            // print(div);
            // print(pow);
            // print(polinomial);
        }

        static void print(Expression exp) {
          Console.WriteLine($"\n* {exp.toString()} = {exp.calc()}");
          Console.WriteLine($"* {exp.toString()}' = {exp.diff().toString()} = {exp.diff().calc()}\n");
        }
    }
}
