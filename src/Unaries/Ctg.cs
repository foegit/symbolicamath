using System;

namespace SymbolicMath {
  class Ctg : Unaries {
    public Ctg(Expression value) : base(value) {}

    public override string toString() {
      return $"ctg({value.toString()})";
    }
    public override double calc() {
      return 1 / Math.Tan(value.calc());
    }
  }
}