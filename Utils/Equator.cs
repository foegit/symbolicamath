using System;

namespace SymbolicMath {
    class Equator {
        static public double Dichotomy(Function fn, double a, double b) {
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