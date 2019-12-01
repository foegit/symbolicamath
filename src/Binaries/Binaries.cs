using System;

namespace SymbolicMath {
    abstract class Binaries : Expression {
        public readonly Expression LValue;
        public readonly Expression RValue;
        public Binaries(Expression lvalue, Expression rvalue) {
            this.LValue = lvalue;
            this.RValue = rvalue;
        }
    }
}