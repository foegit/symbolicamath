using System;

namespace SymbolicMath {
  class Div : Binaries {
    public Div(Expression lvalue, Expression rvalue) : base(lvalue, rvalue) {}

    public override string toString() {
      return $"({lvalue.toString()}) / ({rvalue.toString()})";
    }

    public override double calc() {
      return lvalue.calc() / rvalue.calc();
    }
  }
}