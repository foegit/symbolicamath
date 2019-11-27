using System;
using System.Collections;

namespace SymbolicMath {
  class Polynomial : Unaries {
    public double[] coef;
    public Polynomial(Expression value, double[] coef) : base(value) {
      this.coef = coef;
    }

    public override string toString() {
      string result = "";
      string stringValue = value.toString();

      for (int i = 0; i < coef.Length; i++) {
        result += $"({coef[i]}*{stringValue}^{i + 1})";

        if (i != coef.Length - 1) {
          result += " + ";
        }
      }

      return result;
    }


    private double calcPart(int number) {
      return Math.Pow(coef[number] * value.calc(), number + 1);
    }

    public override double calc() {
      double result = calcPart(0);

      for (int i = 1; i < coef.Length; i++) {
        double part = calcPart(i);

        result += part;
      }

      return result;
    }
  }
}