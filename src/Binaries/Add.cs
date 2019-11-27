using System;

namespace SymbolicMath {
  class Add : Binaries {
    public Add(Expression lvalue, Expression rvalue) : base(lvalue, rvalue) {}

    public override string toString() {
      return $"({lvalue.toString()}) + ({rvalue.toString()})";
    }

    public override double calc() {
      return lvalue.calc() + rvalue.calc();
    }
  }
}