using System;

namespace SymbolicMath {
    class Subsctract : Binaries {
        public Subsctract(Expression lvalue, Expression rvalue) : base(lvalue, rvalue) {}

        public override string toString() {
            return $"{Tools.formatExpression(LValue)} - {Tools.formatExpression(RValue)}";
        }

        public override double calc() {
            return LValue.calc() - RValue.calc();
        }

        public override Expression diff() {
            return new Subsctract(LValue.diff(), RValue.diff());
        }
    }
}