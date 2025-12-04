using System;

namespace Tumakov.Classes
{
    [DeveloperInfo("Bob", "2025-10-01")]
    [DeveloperInfo()]
    class RationalNumbers
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public RationalNumbers(int numerator, int denominator)
        {
            if (denominator != 0)
            {
                Numerator = numerator;
                Denominator = denominator;
            }
            else if (denominator == 0)
            {
                throw new DivideByZeroException("Деление на ноль. Знаменатель не может быть нулем");
            }
        }

        public static bool operator ==(RationalNumbers rnumber1, RationalNumbers rnumber2)
        {
            if (ReferenceEquals(rnumber1, null))
            {
                return ReferenceEquals(rnumber2, null);
            }
            else if (ReferenceEquals(rnumber2, null))
            {
                return false;
            }
            return rnumber1.Numerator * rnumber2.Denominator == rnumber2.Numerator * rnumber1.Denominator;
        }
        public static bool operator !=(RationalNumbers rnumber1, RationalNumbers rnumber2)
        {
            return !(rnumber1 == rnumber2);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            return this == (RationalNumbers)obj;
        }
        public static bool operator <(RationalNumbers rnumber1, RationalNumbers rnumber2)
        {
            return rnumber1.Numerator * rnumber2.Denominator < rnumber2.Numerator * rnumber1.Denominator;
        }
        public static bool operator >(RationalNumbers rnumber1, RationalNumbers rnumber2)
        {
            return rnumber1.Numerator * rnumber2.Denominator > rnumber2.Numerator * rnumber1.Denominator;
        }
        public static bool operator <=(RationalNumbers rnumber1, RationalNumbers rnumber2)
        {
            return rnumber1.Numerator * rnumber2.Denominator <= rnumber2.Numerator * rnumber1.Denominator;
        }
        public static bool operator >=(RationalNumbers rnumber1, RationalNumbers rnumber2)
        {
            return rnumber1.Numerator * rnumber2.Denominator >= rnumber2.Numerator * rnumber1.Denominator;
        }
        public static RationalNumbers operator +(RationalNumbers rnumber1, RationalNumbers rnumber2)
        {
            var numerator = rnumber1.Numerator * rnumber2.Denominator + rnumber2.Numerator * rnumber1.Denominator;
            var denominator = rnumber1.Denominator * rnumber2.Denominator;
            return new RationalNumbers(numerator, denominator);
        }
        public static RationalNumbers operator -(RationalNumbers rnumber1, RationalNumbers rnumber2)
        {
            if (rnumber1.Denominator == rnumber2.Denominator)
            {
                return new RationalNumbers(rnumber1.Numerator - rnumber2.Numerator, rnumber1.Denominator);
            }
            var numerator = rnumber1.Numerator * rnumber2.Denominator - rnumber2.Numerator * rnumber1.Denominator;
            var denominator = rnumber1.Denominator * rnumber2.Denominator;
            return new RationalNumbers(numerator, denominator);
        }
        public static RationalNumbers operator ++(RationalNumbers rnumber)
        {
            var numerator = rnumber.Numerator + rnumber.Denominator;
            return new RationalNumbers(numerator, rnumber.Denominator);
        }
        public static RationalNumbers operator --(RationalNumbers rnumber)
        {
            var numerator = rnumber.Numerator - rnumber.Denominator;
            return new RationalNumbers(numerator, rnumber.Denominator);
        }
        public override string ToString()
        {
            return $"Число: {Numerator}/{Denominator}"; ;
        }
        public static explicit operator float(RationalNumbers rnumber)
        {
            return (float)rnumber.Numerator / rnumber.Denominator;
        }
        public static explicit operator int(RationalNumbers rnumber)
        {
            return (int)(rnumber.Numerator / rnumber.Denominator);
        }
        public static implicit operator RationalNumbers(int number)
        {
            return new RationalNumbers(number, 1);
        }
        public static implicit operator RationalNumbers(float number)
        {
            var numberInString = number.ToString();
            var denominator = NumeratorFromString(numberInString) * 10;
            var numerator = number * 10 * NumeratorFromString(numberInString);
            return new RationalNumbers((int)numerator, 1);
        }
        public static RationalNumbers operator *(RationalNumbers rnumber1, RationalNumbers rnumber2)
        {
            int numerator = rnumber1.Numerator * rnumber2.Numerator;
            int denominator = rnumber1.Denominator * rnumber2.Denominator;
            return new RationalNumbers(numerator, denominator);
        }

        public static RationalNumbers operator /(RationalNumbers rnumber1, RationalNumbers rnumber2)
        {
            if (rnumber2.Numerator == 0)
                throw new DivideByZeroException("Деление на ноль");

            int numerator = rnumber1.Numerator * rnumber2.Denominator;
            int denominator = rnumber1.Denominator * rnumber2.Numerator;
            return new RationalNumbers(numerator, denominator);
        }

        public static RationalNumbers operator %(RationalNumbers rnumber1, RationalNumbers rnumber2)
        {
            if (rnumber2.Numerator == 0)
                throw new DivideByZeroException("Деление на ноль");

            RationalNumbers rnumber3 = rnumber1 / rnumber2;
            int remains = (int)((double)rnumber3.Numerator / rnumber3.Denominator);
            return rnumber1 - rnumber2 * new RationalNumbers(remains, 1);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Numerator.GetHashCode();
                hash = hash * 23 + Denominator.GetHashCode();
                return hash;
            }
        }
        public static int NumeratorFromString(string number)
        {
            string[] parts = number.Split('.');
            if (parts.Length > 1 && parts[1].Length > 0)
            {
                char firstAfterDot = parts[1][0];
                if (firstAfterDot == '0' && parts[1].Replace("0", "").Length == 0)
                {
                    return 1;
                }
                return parts[1].Length;
            }
            return 1;
        }
    }
}