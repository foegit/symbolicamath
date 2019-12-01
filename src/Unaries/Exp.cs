using System;

namespace SymbolicMath {
    class Exp : Unaries {
        public Exp(Function arg) : base(arg) {}

        public override string toString() {
            return $"e^{Tools.formatFunction(Arg)}";
        }

        public override double calc(double x) {
            return Math.Exp(Arg.calc(x));
        }

        public override Function diff() {
            return new Mult(Arg.diff(), new Exp(Arg));
        }
    }
}