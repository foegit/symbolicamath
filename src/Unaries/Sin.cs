using System;

namespace SymbolicMath {
    class Sin : Unaries {
        public Sin(Expression value) : base(value) {}

        public override string toString() {
            return $"sin({value.toString()})";
        }

        public override double calc() {
            return Math.Sin(value.calc());
        }

        public override Expression diff() {
            Expression o = this.value.diff();

            return new Mult(o, new Cos(this.value));
        }
    }
}