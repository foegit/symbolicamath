using System;

namespace SymbolicMath
{
    abstract class Expression
    {
        abstract public string toString();
        abstract public double calc();

        virtual public Expression diff() {
          return new Constant(0);
        }
    }
}
