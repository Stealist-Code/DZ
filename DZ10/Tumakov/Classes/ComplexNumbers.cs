using System;

namespace Tumakov.Classes
{
    class ComplexNumbers
    {
        public double ReZ { get; set; }
        public double ImZ { get; set; }

        public ComplexNumbers(double rez, double imz)
        {
            ReZ = rez;
            ImZ = imz;
        }

        public static ComplexNumbers operator +(ComplexNumbers number1, ComplexNumbers number2)
        {
            return new ComplexNumbers(number1.ReZ + number2.ReZ, number1.ImZ + number2.ImZ);
        }
        public static ComplexNumbers operator -(ComplexNumbers number1, ComplexNumbers number2)
        {
            return new ComplexNumbers(number1.ReZ - number2.ReZ, number1.ImZ - number2.ImZ);
        }
        public static ComplexNumbers operator *(ComplexNumbers number1, ComplexNumbers number2)
        {
            var reZ = number1.ReZ * number2.ReZ - number1.ImZ * number2.ImZ;
            var imZ = number1.ReZ * number2.ImZ + number1.ImZ * number2.ReZ;
            return new ComplexNumbers(reZ, imZ);
        }
        public static bool operator ==(ComplexNumbers number1, ComplexNumbers number2)
        {
            if (ReferenceEquals(number1, null))
            {
                return ReferenceEquals(number2, null);
            }
            else if (ReferenceEquals(number2, null))
            {
                return false;
            }
            return number1.ReZ == number2.ReZ && number1.ImZ == number2.ImZ;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            return this == (ComplexNumbers)obj;
        }
        public static bool operator !=(ComplexNumbers number1, ComplexNumbers number2)
        {
            return !(number1 == number2);
        }
        public override string ToString()
        {
            return $"Комплексное число: {ReZ} + i*({ImZ})";
        }
    }
}
