using System;

namespace SymbolicMath {
    class Ln : Unaries {
        public Ln(Function arg) : base(arg) {}

        public override string toString() {
            return $"ln({Arg.toString()})";
        }

        public override double calc(double x) {
            return Math.Log(Arg.calc(x), Math.E);
        }

        public override Function diff() {
            return new Mult(Arg.diff(), new Div(new Constant(1), Arg));
        }
    }
}