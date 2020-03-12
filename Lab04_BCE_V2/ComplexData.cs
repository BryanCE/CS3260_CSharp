using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_BCE_V2
{
	/// <summary>
	/// Complex Data class defines a data type of the complex form a + bi
	/// defined as an object to make it a base class in the hierarchy (i think)
	/// this data type has real and imaginary operands, used to describe vectors
	/// </summary>
	class ComplexData : Object
    {
		public double real;
		public double imaginary;

		/// <summary>
		/// Constructor for ComplexData class
		/// </summary>
		/// <param name="r">takes any valid double</param>
		/// <param name="i">takes any valid double</param>
		public ComplexData(double r, double i)
		{
			this.real = r;
			this.imaginary = i;
		}


		/// <summary>
		///Purpose: to ovveride the Tostring() method for our purposes
		///correctly formats an output string
		/// </summary>
		/// <returns>a string representing a complex number</returns>
		public override string ToString()
		{
			string sign = " + ";
			if (imaginary < 0)
			{
				sign = " - ";
				imaginary *= -1;
			}
			return real.ToString() + sign + imaginary.ToString() + "i";
		}
	}
}
