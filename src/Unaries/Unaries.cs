using System;

namespace SymbolicMath {
    abstract class Unaries : Function {
        protected Function Arg;

        public Unaries(Function value) {
            this.Arg = value;
        }
    }
}