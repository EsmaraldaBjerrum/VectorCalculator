using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace VectorCalculator.Unit.Test
{
    [TestFixture]
    public class VectorCalUnitTest
    {
        private VectorCal uut;

        [SetUp]
        public void Setup()
        {
            uut = new VectorCal();
        }

        [Test]
        public void AddVec_ax1Plusbx2_Iscx3()
        {
            Vector A = new Vector(1,1);
            Vector B = new Vector(2,2);
            Vector C = new Vector(3,3);

            Assert.That(uut.AddVec(A,B).X, Is.EqualTo(C.X));
        }

        [Test]
        public void AddVec_ay1Plusby2_Iscy3()
        {
            Vector A = new Vector(1, 1);
            Vector B = new Vector(2, 2);
            Vector C = new Vector(3, 3);

            Assert.That(uut.AddVec(A, B).Y, Is.EqualTo(C.Y));
        }

        [Test]
        public void AddVec_ax2Minusbx1_Iscx1()
        {
            Vector A = new Vector(2, 2);
            Vector B = new Vector(1, 1);
            Vector C = new Vector(1, 1);

            Assert.That(uut.SubtractVec(A, B).X, Is.EqualTo(C.X));
        }

        [Test]
        public void AddVec_ay2Minusby1_Iscy1()
        {
            Vector A = new Vector(2, 2);
            Vector B = new Vector(1, 1);
            Vector C = new Vector(1, 1);

            Assert.That(uut.SubtractVec(A, B).Y, Is.EqualTo(C.Y));
        }

        [Test]
        public void ScaleVec_3Timeax2_cx6()
        {
            Vector A = new Vector(2,2);
            int s = 3;
            Vector C = new Vector(6,6);

            Assert.That(uut.ScaleVec(s,A).X, Is.EqualTo(C.X));
        }


        [Test]
        public void ScaleVec_3Timeay2_cy6()
        {
            Vector A = new Vector(2, 2);
            int s = 3;
            Vector C = new Vector(6, 6);

            Assert.That(uut.ScaleVec(s, A).Y, Is.EqualTo(C.Y));
        }

        [Test]
        public void DotVec_ax2y2Dotbx3y3_Is12()
        {
            Vector A = new Vector(2, 2);
            Vector B = new Vector(3, 3);

            Assert.That(uut.DotVec(A, B), Is.EqualTo(12).Within((Double.Epsilon)));
        }

        //[Test]
        //public void AngleVec_ax0y3Andax3y0_Is90()
        //{
        //    Vector A = new Vector(0,3);
        //    Vector B = new Vector(3,0);
            
        //    Assert.That(uut.AngleVec(A, B), Is.EqualTo(90).Within(Double.Epsilon));
        //}
    }
}
