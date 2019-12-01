using System;

namespace SymbolicMath {
    class Tools {
        static public double degreeToRadian(double degree) {
            return degree * Math.PI / 180;
        }

        static public string formatFunction(Function fn) {
            string result = fn.toString();

            if (fn is Binaries || result[0] == '-') {
                result = $"({result})";
            }

            return result;
        }
    }
}