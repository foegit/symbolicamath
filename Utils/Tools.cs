using System;

namespace SymbolicMath {
    class Tools {
        static public string formatFunction(Function fn) {
            string result = fn.toString();

            if (fn is Binaries || result[0] == '-') {
                result = $"({result})";
            }

            return result;
        }

        static public double Integral(Function fn, double a, double b) {
            double n = 1000000;
            double range = b - a;
            double result = 0;

            for (double i = 1; i <= n; i += 1 ) {
                double mi = a + ((2 * i - 1) / (2 * n)) * (b - a);

                result += fn.calc(mi);
            }

            return (range / n) * result;
        }

        static public double Solve(Function fn, double a, double b) {
            double eps = 0.005;
            double left = a;
            double right = b;
            double mid = (a + b) / 2;
            int max = 10000;
            int count = 0;

            while(count < max) {
                if (Math.Abs(fn.calc(mid)) < eps) {
                    return mid;
                }

                mid = (left + right) / 2;

                if (fn.calc(left) * fn.calc(mid) < 0) {
                    right = mid;
                } else if (fn.calc(mid) * fn.calc(right) < 0) {
                    left = mid;
                }

                count += 1;
            }

            return mid;
        }
    }
}