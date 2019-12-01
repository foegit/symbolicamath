using System;

namespace SymbolicMath
{
    class Variable : Expression
    {
        private string name;
        private Expression expression;
        public Variable(string name, Expression expression) {
            this.name = name;
            this.expression = expression;
        }

        public override string toString() {
            return $"{name}";
        }

        public override double calc() {
            return expression.calc();
        }

        public override Expression diff() {
            return new Variable($"{name}'", expression.diff());
        }
    }
}
