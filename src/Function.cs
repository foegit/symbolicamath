using System;

namespace SymbolicMath
{
    abstract class Function
    {
        abstract public string toString();

        abstract public double calc(double x);

        abstract public Function diff();
    }
}
