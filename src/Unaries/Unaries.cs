using System;

namespace SymbolicMath {
    abstract class Unaries : Function {
        public Function value;
        public Function Arg;

        public Unaries(Function value) {
            this.value = value;
            this.Arg = value;
        }
    }
}