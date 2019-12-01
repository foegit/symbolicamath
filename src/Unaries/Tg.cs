using System;

namespace SymbolicMath {
    class Tg : Unaries {
        public Tg(Expression value) : base(value) {}

        public override string toString() {
            return $"tg({value.toString()})";
        }

        public override double calc() {
            return Math.Tan(value.calc());
        }

        public override Expression diff() {
            return new Div(new Constant(1), new Pow(new Cos(value), new Constant(2)));
        }
    }
}