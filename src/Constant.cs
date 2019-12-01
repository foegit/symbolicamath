using System;

namespace SymbolicMath
{
    class Constant : Expression
    {
        private double number;
        public Constant(double number) {
            this.number = number;
        }

        public override string toString() {
            return $"{number}";
        }

        public override double calc() {
            return number;
        }
    }
}
