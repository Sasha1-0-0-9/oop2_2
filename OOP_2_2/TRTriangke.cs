using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_2
{
    class TRTriangle
    {
        private double lengthKatet_1, lengthKatet_2;

        public double LengthKatet_1
        {
            get
            {
                return lengthKatet_1;
            }

            set
            {
                lengthKatet_1 = value;
            }
        }

        public double LengthKatet_2
        {
            get
            {
                return lengthKatet_2;
            }

            set
            {
                lengthKatet_2 = value;
            }
        }

        public TRTriangle()
        { }

        public TRTriangle(double katet_1, double katet_2)
        {
            lengthKatet_1 = katet_1;
            lengthKatet_2 = katet_2;
        }

        // copy constructor
        public TRTriangle(TRTriangle trTriangle) : this(trTriangle.lengthKatet_1, trTriangle.lengthKatet_2)
        { }


        public static TRTriangle Input()
        {
            Console.Write("Katet_1: ");
            double katet_1 = double.Parse(Console.ReadLine());
            Console.Write("Katet_2: ");
            double katet_2 = double.Parse(Console.ReadLine());
            return new TRTriangle(katet_1, katet_2);
        }

        public double Area() => (lengthKatet_1 * lengthKatet_2) / 2;

        public double Perimetr() => lengthKatet_1 + lengthKatet_2 + Hypotenuse();

        public double Hypotenuse() => Math.Sqrt(Math.Pow(lengthKatet_1, 2) + Math.Pow(lengthKatet_2, 2));

        public override string ToString()
        {
            return string.Format("First katet = {0}\nSecond katet = {1}\nHypotenuse = {2}\nArea is {3}\nPerimetr is {4}",
                lengthKatet_1, lengthKatet_2, Hypotenuse(), Area(), Perimetr());
        }

        public override int GetHashCode()
        {
            int hashcode = 17;
            hashcode = hashcode * 23 + lengthKatet_1.GetHashCode();
            hashcode = hashcode * 23 + lengthKatet_2.GetHashCode();
            return hashcode;
        }

        public static TRTriangle operator *(TRTriangle trT, double number)
        {
            return new TRTriangle(trT.lengthKatet_1 * number, trT.lengthKatet_2 * number);
        }

        public static TRTriangle operator *(double number, TRTriangle trT)
        {
            return new TRTriangle(trT.lengthKatet_1 * number, trT.lengthKatet_2 * number);
        }
    }
}
