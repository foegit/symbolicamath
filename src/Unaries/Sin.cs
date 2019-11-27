using System;

namespace SymbolicMath {
  class Sin : Unaries {
    public Sin(Expression value) : base(value) {}

    public override string toString() {
      return $"sin({value.toString()})";
    }

    public override double calc() {
      return Math.Sin(value.calc());
    }
  }
}