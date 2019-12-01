using System;

namespace SymbolicMath {
    class Add : Binaries {
        public Add(Expression lvalue, Expression rvalue) : base(lvalue, rvalue) {}

        public override string toString() {
            return $"{Tools.formatExpression(LValue)} + {Tools.formatExpression(RValue)}";
        }

        public override double calc() {
            return LValue.calc() + RValue.calc();
        }

        public override Expression diff() {
            return new Add(LValue.diff(), RValue.diff());
        }
    }
}