using System;

namespace SymbolicMath {
  class Exp : Unaries {
    public Exp(Expression value) : base(value) {}

    public override string toString() {
      return $"e^({value.toString()})";
    }

    public override double calc() {
      return Math.Exp(value.calc());
    }
  }
}