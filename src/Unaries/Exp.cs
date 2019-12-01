using System;

namespace SymbolicMath {
    class Exp : Unaries {
        public Exp(Expression value) : base(value) {}

        public override string toString() {
            return $"e^{Tools.formatExpression(value)}";
        }

        public override double calc() {
            return Math.Exp(value.calc());
        }

        public override Expression diff() {
            return new Exp(value);
        }
    }
}