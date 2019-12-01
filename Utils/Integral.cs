using System;

namespace SymbolicMath {
    class Integral {
        static public double integral(Function fn, double a, double b) {
            double n = 1000000;
            double range = b - a;
            double result = 0;

            for (double i = 1; i <= n; i += 1 ) {
                double mi = a + ((2 * i - 1) / (2 * n)) * (b - a);

                result += fn.calc(mi);
            }

            return (range / n) * result;
        }
    }
}