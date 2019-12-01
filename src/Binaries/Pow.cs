using System;

namespace SymbolicMath {
    class Pow : Binaries {
        public Pow(Function larg, Function rarg) : base(larg, rarg)  {
            if (!(rarg is Constant)) {
                throw new Exception();
            }
        }

        public override string toString() {
            return $"{Tools.formatFunction(LArg)} ^ {Tools.formatFunction(RArg)}";
        }

        public override double calc(double x) {
            return Math.Pow(LArg.calc(x), RArg.calc(x));
        }

        public override Function diff() {
            Function g = LArg.diff();

            double currentIndex = RArg.calc(0);


            return new Mult(LArg.diff(), new Mult(RArg, new Pow(LArg, new Constant(currentIndex - 1))));
        }
    }
}