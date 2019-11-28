using System;
using System.Collections;

namespace SymbolicMath {
  class Polynomial : Unaries {
    public double[] coef;
    public Polynomial(Expression value, double[] coef) : base(value) {
      this.coef = coef;
    }

    private string getPrefix(double coef) {
      if (coef == 1) {
        return "+";
      }

      if (coef == -1) {
        return "-";
      }

      return "";
    }

    private string getSuffix(int n) {
      if (n <= 1) {
        return "";
      }

      return "^" + n;
    }

    private string getSeparator(double coef) {
      if (coef < 0) {
        return "";
      }

      return "+";
    }


    public override string toString() {
      if (coef.Length == 0) {
        return "";
      }

      if (coef.Length == 1) {
        return $"{getPrefix(coef[0])}{value.toString()}";
      }

      string result = $"{getPrefix(coef[0])}{value.toString()}{getSuffix(0)}";
      string stringValue = value.toString();

      for (int i = 1; i < coef.Length; i++) {
        result += $"{getPrefix(coef[i])}{value.toString()}{getSuffix(i)} ";
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