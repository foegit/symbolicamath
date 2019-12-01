using System;

namespace SymbolicMath
{
    class Constant : Function
    {
        private double constnValue;
        public Constant(double c) {
            this.constnValue = c;
        }

        public override string toString() {
            return $"{constnValue}";
        }

        public override double calc(double x) {
            return constnValue;
        }

        public override Function diff() {
            return new Constant(0);
        }
    }
}
