using System;

namespace SymbolicMath {
  abstract class Binaries : Expression {
    public Expression lvalue;
    public Expression rvalue;
    public Binaries(Expression lvalue, Expression rvalue) {
      this.lvalue = lvalue;
      this.rvalue = rvalue;
    }
  }
}