using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_BCE_V2
{
    class ComplexArithmetic
    {
        /// <summary>
        /// Adds two complex numbers
        /// </summary>
        /// <param name="left">any valid ComplexData Value</param>
        /// <param name="right">any valid ComplexData Value</param>
        /// <returns>returns an object of type ComplexData</returns>
        public ComplexData Add(ComplexData left, ComplexData right)
        {
            double r = left.real + right.real;
            double i = left.imaginary + right.imaginary;
            ComplexData sum = new ComplexData(r, i);
            return sum;
        }

        /// <summary>
        /// Subtracts two complex numbers
        /// </summary>
        /// <param name="left">any valid ComplexData Value</param>
        /// <param name="right">any valid ComplexData Value</param>
        /// <returns>returns an object of type ComplexData</returns>
        public ComplexData Subtract(ComplexData left, ComplexData right)
        {
            double r = left.real - right.real;
            double i = left.imaginary - right.imaginary;
            ComplexData sum = new ComplexData(r, i);
            return sum;
        }

        /// <summary>
        /// multiplies two complex numbers
        /// </summary>
        /// <param name="left">any valid ComplexData Value</param>
        /// <param name="right">any valid ComplexData Value</param>
        /// <returns>returns an object of type ComplexData</returns>
        public ComplexData Multiply(ComplexData left, ComplexData right)
        {
            double r = (left.real * right.real) - (left.imaginary * right.imaginary);
            double i = (left.real * right.imaginary) + (left.imaginary * right.real);
            ComplexData product = new ComplexData(r, i);
            return product;
        }

        /// <summary>
        /// divides two complex numbers
        /// </summary>
        /// <param name="left">any valid ComplexData Value</param>
        /// <param name="right">any valid ComplexData Value</param>
        /// <returns>returns an object of type ComplexData</returns>
        public ComplexData Divide(ComplexData left, ComplexData right)
        {
            double topI = (left.real * (-1 * right.imaginary)) + (left.imaginary * right.real);
            double topR = (left.real * right.real) + (left.imaginary * right.imaginary);
            double btmVal = (right.real * right.real) - (right.imaginary * (-1 * right.imaginary));
            double r = topR / btmVal;
            double i = topI / btmVal;
            ComplexData val = new ComplexData(r, i);
            return val;
        }
    }
}
