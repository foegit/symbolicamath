using System;

namespace SymbolicMath {
    abstract class Unaries : Expression {
        public Expression value;

        public Unaries(Expression value) {
            this.value = value;
        }
    }
}