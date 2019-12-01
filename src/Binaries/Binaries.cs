using System;

namespace SymbolicMath {
    abstract class Binaries : Function {
        protected Function LArg;
        protected Function RArg;
        public Binaries(Function larg, Function rarg) {
            LArg = larg;
            RArg = rarg;
        }
    }
}