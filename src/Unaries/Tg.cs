using System;

namespace SymbolicMath {
    class Tg : Unaries {
        public Tg(Function arg) : base(arg) {}

        public override string toString() {
            return $"tg({Arg.toString()})";
        }

        public override double calc(double x) {
            return Math.Tan(Arg.calc(x));
        }

        public override Function diff() {
            return new Div(new Constant(1), new Pow(new Cos(Arg), new Constant(2)));
        }
    }
}