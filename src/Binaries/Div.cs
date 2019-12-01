using System;

namespace SymbolicMath {
    class Div : Binaries {
        public Div(Expression lvalue, Expression rvalue) : base(lvalue, rvalue) {}

        public override string toString() {
            return $"{Tools.formatExpression(LValue)} / {Tools.formatExpression(RValue)}";
        }

        public override double calc() {
            return LValue.calc() / RValue.calc();
        }

        public override Expression diff() {
            Subsctract enumerator = new Subsctract(new Mult(LValue.diff(), RValue), new Mult(LValue, RValue.diff()));
            Pow denumerator = new Pow(RValue, new Constant(2));

            return new Div(enumerator, denumerator);
        }
    }
}