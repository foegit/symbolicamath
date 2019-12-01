using System;

namespace SymbolicMath {
    class Cos : Unaries {
        public Cos(Function arg) : base(arg) {}

        public override string toString() {
            return $"cos({Arg.toString()})";
        }

        public override double calc(double x) {
            return Math.Cos(Arg.calc(x));
        }

        public override Function diff() {
            Function g = Arg.diff();

            return new Mult(g, new Mult(new Constant(-1), new Sin(Arg)));
        }
    }
}