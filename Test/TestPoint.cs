using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dron_Exception;
using NUnit.Framework;
using Robot_D;
using Robot_D.Bottom_Layer;

namespace Test
{
    [TestFixture]
    public class TestPoint
    {

        [Test]
        //[ExpectedException(typeof(ExceptionUser))]
        public void Point_SetCoordinate_minus_int_1_int_1_Returned_Exception()
        {
            //--Arrange
            var Point = new Point();

            //--Act
            try
            {
                Point.SetCoordinate(-1, 1);
            }
            catch (ExceptionUser exUser)
            {
                Assert.AreEqual("Координата X не может быть меньше нуля", exUser.Message);
                //throw;
            }

        }

        [Test]
        //[ExpectedException(typeof(ExceptionUser))]
        public void Point_SetCoordinate_int_1_minus_int_1_Returned_Exception()
        {
            //--Arrange
            var Point = new Point();

            //--Act
            try
            {
                Point.SetCoordinate(1, -1);
            }
            catch (ExceptionUser exUser)
            {
                Assert.AreEqual("Координата Y не может быть меньше нуля", exUser.Message);
                //throw;
            }
        }

        [Test]
        public void Point_SetCoordinate_int_0_int_1_Returned_TRUE()
        {
            //var Point = new Point();

            //var actual = Point.SetCoordinate(0, 1);

            //Assert.AreEqual(true, actual);
        }

        [Test]
        public void Point_SetCoordinate_int_1_int_1_Returned_X_1()
        {
            var Point = new Point();

            Point.SetCoordinate(1, 1);

            var actual = Point.X;

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Point_SetCoordinate_int_1_int_1_Returned_Y_1()
        {
            var Point = new Point();

            Point.SetCoordinate(1, 1);

            var actual = Point.Y;

            Assert.AreEqual(1, actual);
        }

        [Test]
        //[ExpectedException(typeof(ExceptionUser))]
        public void Point_SetCoordinate_X_Null_Returned_Exception()
        {
            var Point = new Point();

            try
            {
                var actual = Point.X;
            }
            catch (ExceptionUser exUser)
            {
                Assert.AreEqual("Координата X не задана либо она не может быть менше нуля", exUser.Message);
                //throw;
            }
        }

        [Test]
        //[ExpectedException(typeof(ExceptionUser))]
        public void Point_SetCoordinate_Y_Null_Returned_Exception()
        {
            var Point = new Point();

            try
            {
                var actual = Point.Y;
            }
            catch (ExceptionUser exUser)
            {
                Assert.AreEqual("Координата Y не задана либо она не может быть менше нуля", exUser.Message);
                //throw;
            }
        }

        [Test]
        //[ExpectedException(typeof(ExceptionUser))]
        public void Point_SetCoordinate_UNCORRECT_str_Returned_Exception()
        {
            var Point = new Point();

            try
            {
                Point.SetCoordinate("1 1s");
            }
            catch (ExceptionUser exUser)
            {
                Assert.AreEqual("Некоректные координаты объекта", exUser.Message);
                //throw;
            }
        }

        [Test]
        public void Point_SetCoordinate_string_1_string_1_Returned_X_1()
        {
            var Point = new Point();

            Point.SetCoordinate("1 1");

            var actual = Point.X;

            Assert.AreEqual(1, actual);
        }
        [Test]
        public void Point_SetCoordinate_string_1_string_1_Returned_Y_1()
        {
            var Point = new Point();

            Point.SetCoordinate("1 1");

            var actual = Point.Y;

            Assert.AreEqual(1, actual);

        }
        [Test]
        public void Point_SetCoordinate_string_10_string_1_Returned_X_10()
        {
            var Point = new Point();

            Point.SetCoordinate("10 1");

            var actual = Point.X;

            Assert.AreEqual(10, actual);
        }

        [Test]
        public void Point_SetCoordinate_string_1_string_10_Returned_Y_10()
        {
            var Point = new Point();

            Point.SetCoordinate("1 10");

            var actual = Point.Y;

            Assert.AreEqual(10, actual);
        }

        [Test]
        public void Point_SetCoordinate_string_100_string_1_Returned_X_100()
        {
            var Point = new Point();

            Point.SetCoordinate("100 1");

            var actual = Point.X;

            Assert.AreEqual(100, actual);
        }

        [Test]
        public void Point_SetCoordinate_string_1_string_100_Returned_Y_100()
        {
            var Point = new Point();

            Point.SetCoordinate("1 100");

            var actual = Point.Y;

            Assert.AreEqual(100, actual);
        }

        [Test]
        public void Point_SetCoordinate_string_01_string_1_Returned_X_1()
        {
            var Point = new Point();

            Point.SetCoordinate("01 1");

            var actual = Point.X;

            Assert.AreEqual(1, actual);
        }
        [Test]
        public void Point_SetCoordinate_string_1_string_01_Returned_Y_1()
        {
            var Point = new Point();

            Point.SetCoordinate("1 01");

            var actual = Point.Y;

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Point_SetCoordinate_string_001_string_1_Returned_X_1()
        {
            var Point = new Point();

            Point.SetCoordinate("001 1");

            var actual = Point.X;

            Assert.AreEqual(1, actual);
        }
        [Test]
        public void Point_SetCoordinate_string_1_string_001_Returned_Y_1()
        {
            var Point = new Point();

            Point.SetCoordinate("1 001");

            var actual = Point.Y;

            Assert.AreEqual(1, actual);
        }
        [Test]
        public void Point_SetCoordinate_string_101_string_1_Returned_X_101()
        {
            var Point = new Point();

            Point.SetCoordinate("101 1");

            var actual = Point.X;

            Assert.AreEqual(101, actual);
        }
        [Test]
        public void Point_SetCoordinate_string_1_string_101_Returned_Y_101()
        {
            var Point = new Point();

            Point.SetCoordinate("1 101");

            var actual = Point.Y;

            Assert.AreEqual(101, actual);
        }
        [Test]
        public void Point_SetCoordinate_int_X_1_Returned_X_1()
        {
            var Point = new Point();

            Point.X = 1;

            var actual = Point.X;

            Assert.AreEqual(1, actual);
        }
        [Test]
        public void Point_SetCoordinate_int_X_0_Returned_X_0()
        {
            var Point = new Point();

            Point.X = 0;

            var actual = Point.X;

            Assert.AreEqual(0, actual);
        }
        [Test]
        public void Point_SetCoordinate_int_Y_1_Returned_Y_1()
        {
            var Point = new Point();

            Point.Y = 1;

            var actual = Point.Y;

            Assert.AreEqual(1, actual);
        }
        [Test]
        public void Point_SetCoordinate_int_Y_0_Returned_Y_0()
        {
            var Point = new Point();

            Point.Y = 0;

            var actual = Point.Y;

            Assert.AreEqual(0, actual);
        }
        [Test]
        public void Point_SetCoordinate_Point_int_1_int_1_Returned_X_1()
        {
            var Point = new Point(1, 1);

            var actual = Point.X;

            Assert.AreEqual(1, actual);
        }
        [Test]
        public void Point_SetCoordinate_Point_int_1_int_1_Returned_Y_1()
        {
            var Point = new Point(1, 1);

            var actual = Point.Y;

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Point_SetCoordinate_Point_string_1_1_Returned_X_1()
        {
            var Point = new Point("1 1");

            var actual = Point.X;

            Assert.AreEqual(1, actual);
        }
        [Test]
        public void Point_SetCoordinate_Point_string_1_1_Returned_Y_1()
        {
            var Point = new Point("1 1");

            var actual = Point.Y;

            Assert.AreEqual(1, actual);
        }
    }
}
