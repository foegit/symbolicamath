using System;

namespace SymbolicMath {
    class Mult : Binaries {
        public Mult(Expression lvalue, Expression rvalue) : base(lvalue, rvalue) {}

        public override string toString() {
            return $"{Tools.formatExpression(LValue)} * {Tools.formatExpression(RValue)}";
        }

        public override double calc() {
            return LValue.calc() * RValue.calc();
        }

        public override Expression diff() {
            return new Add(new Mult(LValue.diff(), RValue), new Mult(LValue, RValue.diff()));
        }
    }
}