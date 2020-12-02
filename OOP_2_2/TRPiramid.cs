using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2_2
{
    class TRPiramid : TRTriangle
    {
        private double piramidHeight;

        public TRPiramid(double katet1, double katet2, double h) : base(katet1, katet2)
        {
            piramidHeight = h;
        }

        public TRPiramid(TRTriangle tr, double h) : this(tr.LengthKatet_1, tr.LengthKatet_2, h)
        { }

        public new double Area()
        {
            return (piramidHeight * ((Perimetr() - Hypotenuse()) + (Hypotenuse() / Math.Sin(piramidHeight / Hypotenuse())))) / 2;
        }

        public double Volume() => (base.Area() * piramidHeight) / 3;

        public override string ToString()
        {
            return string.Format("\nArea bok. is {0:f2}\nArea osn. is {1}\nVolume is {2}", Area(), base.Area(), Volume());
        }
    }
}
