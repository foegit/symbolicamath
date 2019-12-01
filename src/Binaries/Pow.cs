using System;

namespace SymbolicMath {
    class Pow : Binaries {
        public Pow(Expression lvalue, Expression rvalue) : base(lvalue, rvalue) {}

        public override string toString() {
            return $"{Tools.formatExpression(LValue)} ^ {Tools.formatExpression(RValue)}";
        }

        public override double calc() {
            return Math.Pow(LValue.calc(), RValue.calc());
        }
    }
}