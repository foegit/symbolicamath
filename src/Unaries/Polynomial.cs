using System;
using System.Collections;

namespace SymbolicMath {
    class Polynomial : Unaries {
        // c_0+c_1x+...+c_nx^n
        private double[] coefficients;

        public Polynomial(Function arg, double[] coef) : base(arg) {
            this.coefficients = coef;
        }

        public override string toString() {
            if (coefficients.Length == 0) {
                return "";
            }


            string result = "";
            // $"{getPrefix(c[0], 0)}{Arg.toString()}{getSuffix(0)}";

            for (int i = 0; i < coefficients.Length; i++) {
                string coef = getFormatCoef(coefficients[i], i);

                string suffix = getSuffix(i);

                result += $"{coef}{(i == 0 ? "" : Arg.toString())}{suffix}{( i + 1 == coefficients.Length ? "" : " ")}";
            }

            return result;
        }

        public override double calc(double x) {
            double result = 0;

            for (int i = 0; i < coefficients.Length; i++) {
                result += coefficients[i] * Math.Pow(Arg.calc(x), i);
            }

            return result;
        }

        private string getFormatCoef(double value, int index) {
            if (value >= 0 && index != 0) {
                return $"+ {value}";
            }

            if (value < -1) {
                return $"- {Math.Abs(value)}";
            }

            return $"{value}";
        }

        private string getSuffix(int n) {
            if (n == 0 || n == 1) {
                return "";
            }

            return "^" + (n);
        }

        public override Function diff() {
            double[] newCoefficients = new double[coefficients.Length - 1];

            for (int i = 0; i < newCoefficients.Length; i++) {
                newCoefficients[i] = coefficients[i + 1] * (i + 1);
            }

            return new Polynomial(Arg, newCoefficients);
        }
    }
}