using System;

namespace SymbolicMath {
  class Cos : Unaries {
    public Cos(Expression value) : base(value) {}

    public override string toString() {
      return $"cos({value.toString()})";
    }

    public override double calc() {
      return Math.Cos(value.calc());
    }
  }
}