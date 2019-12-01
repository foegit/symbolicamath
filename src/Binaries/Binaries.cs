using System;

namespace SymbolicMath {
    abstract class Binaries : Function {
        public Function LArg { get; }
        public Function RArg { get; }
        public Binaries(Function larg, Function rarg) {
            LArg = larg;
            RArg = rarg;
        }
    }
}