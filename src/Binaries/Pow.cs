using System;

namespace SymbolicMath {
  class Pow : Binaries {
    public Pow(Expression lvalue, Expression rvalue) : base(lvalue, rvalue) {}

    public override string toString() {
      return $"({lvalue.toString()}) ^ ({rvalue.toString()})";
    }

    public override double calc() {
      return Math.Pow(lvalue.calc(), rvalue.calc());
    }
  }
}