using System;

namespace SymbolicMath {
    class Div : Binaries {
        public Div(Function larg, Function rarg) : base(larg, rarg) {}

        public override string toString() {
            return $"{Tools.formatFunction(LArg)} / {Tools.formatFunction(RArg)}";
        }

        public override double calc(double x) {
            return LArg.calc(x) / RArg.calc(x);
        }

        public override Function diff() {
            Subsctract enumerator = new Subsctract(new Mult(LArg.diff(), RArg), new Mult(LArg, RArg.diff()));
            Pow denumerator = new Pow(RArg, new Constant(2));

            return new Div(enumerator, denumerator);
        }
    }
}