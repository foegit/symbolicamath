using System;

namespace SymbolicMath
{
    class Variable : Function
    {
        public override string toString() {
            return "x";
        }

        public override double calc(double x) {
            return x;
        }

        public override Function diff() {
            return new Constant(1);
        }
    }
}
