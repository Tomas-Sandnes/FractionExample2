using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	public class Fraction
	{
		#region Fields & properties

		int Numerator {  get; set; }
		int Denominator { get; set; }

        #endregion

		#region Constructors

        public Fraction(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

		#endregion

		#region Public methods

		public Fraction Add(Fraction other)
		{
			int numerator = (Numerator * other.Denominator) + (Denominator * other.Numerator);
			int denomonator = Denominator * other.Denominator;
			Fraction sum = new(numerator, denomonator);
			return sum;
		}

		public static Fraction Add(Fraction left, Fraction right)
		{
			int numerator = (left.Numerator * right.Denominator) + (left.Denominator * right.Numerator);
			int denomonator = left.Denominator * right.Denominator;
			Fraction sum = new(numerator, denomonator);
			return sum;
		}

		public string ToText()
		{
			return $"{Numerator}/{Denominator}";
		}

		#endregion
	}
}
