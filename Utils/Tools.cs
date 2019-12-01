using System;

namespace SymbolicMath {
    class Tools {
        static public double degreeToRadian(double degree) {
            return degree * Math.PI / 180;
        }

        static public string formatExpression(Expression exp) {
            string result = exp.toString();

            if (exp is Binaries || result[0] == '-') {
                result = $"({result})";
            }

            return result;
        }
    }
}