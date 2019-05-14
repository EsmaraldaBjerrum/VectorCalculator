using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VectorCalculator
{
    public class VectorCal
    {
        public VectorCal()
        {

        }
        public Vector AddVec(Vector a, Vector b)
        {
            Vector c;

            return c = new Vector(a.X + b.X, a.Y + b.Y);
        }

        public Vector SubtractVec(Vector a, Vector b)
        {
            Vector c;

            return c = new Vector(a.X - b.X, a.Y - b.Y);
        }

        public Vector ScaleVec(int s, Vector a)
        {
            Vector c;

            return c = new Vector(s * a.X, s * a.Y);
        }

        public double DotVec(Vector a, Vector b)
        {
            double c;

            return c = ( a.X * b.X + a.Y * b.Y );
        }

        public double AngleVec(Vector a, Vector b)
        {
            double cosAngle;
            double angle;
            cosAngle = ((a.X * b.X + a.Y * b.Y)) /
                              ((Math.Pow(a.X, 2) + Math.Pow(a.Y, 2)) * ((Math.Pow(b.X, 2) + Math.Pow(b.Y, 2))));

            angle = Math.Acos(cosAngle);
            return angle;
        }
    }
}
