using System;

namespace SymbolicMath {
    class Sin : Unaries {
        public Sin(Function arg) : base(arg) {}

        public override string toString() {
            return $"sin({Arg.toString()})";
        }

        public override double calc(double x) {
            return Math.Sin(Arg.calc(x));
        }

        public override Function diff() {
            Function g = Arg.diff();

            return new Mult(g, new Cos(Arg));
        }
    }
}