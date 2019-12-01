using System;

namespace SymbolicMath {
    class Ctg : Unaries {
        public Ctg(Expression value) : base(value) {}

        public override string toString() {
            return $"ctg({value.toString()})";
        }

        public override double calc() {
            return 1 / Math.Tan(value.calc());
        }

        public override Expression diff() {
            Polynomial enumerator = new Polynomial(new Constant(1), new double[]{-1});
            Pow denumerator = new Pow(new Sin(value), new Constant(2));

            return new Div(enumerator, denumerator);
        }
    }
}