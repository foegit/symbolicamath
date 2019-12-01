using System;

namespace SymbolicMath {
    class Ctg : Unaries {
        public Ctg(Function arg) : base(arg) {}

        public override string toString() {
            return $"ctg({Arg.toString()})";
        }

        public override double calc(double x) {
            return 1 / Math.Tan(Arg.calc(x));
        }

        public override Function diff() {
            return new Div(new Constant(-1), new Pow(new Sin(Arg), new Constant(2)));
        }
    }
}