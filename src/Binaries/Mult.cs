using System;

namespace SymbolicMath {
    class Mult : Binaries {
        public Mult(Function larg, Function rarg) : base(larg, rarg) {}

        public override string toString() {
            return $"{Tools.formatFunction(LArg)} * {Tools.formatFunction(RArg)}";
        }

        public override double calc(double x) {
            return LArg.calc(x) * RArg.calc(x);
        }

        public override Function diff() {
            return new Add(new Mult(LArg.diff(), RArg), new Mult(RArg, RArg.diff()));
        }
    }
}