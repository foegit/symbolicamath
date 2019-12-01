using System;

namespace SymbolicMath {
    class Ln : Unaries {
        public Ln(Expression value) : base(value) {}

        public override string toString() {
            return $"ln({value.toString()})";
        }

        public override double calc() {
            return Math.Log(value.calc(), Math.E);
        }

        public override Expression diff() {
            return new Div(new Constant(1), value);
        }
    }
}