using System;

namespace SymbolicMath
{
    abstract class Expression
    {
        abstract public string toString();
        abstract public double calc();
    }
}
