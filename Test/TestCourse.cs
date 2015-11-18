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
    class TestCourse
    {
        //[Test]
        //public void Course_Direction_N_Returned_N()
        //{
        //    var Course = new Course();

        //    Course.Direction = "N";

        //    var actual = Course.Direction;

        //    Assert.AreEqual("N", actual);
        //}
        //[Test]
        //public void Course_Direction_n_Returned_n()
        //{
        //    var Course = new Course();

        //    Course.Direction = "n";

        //    var actual = Course.Direction;

        //    Assert.AreEqual("n", actual);
        //}

        //[Test]
        //public void Course_Direction_E_Returned_E()
        //{
        //    var Course = new Course();

        //    Course.Direction = "E";

        //    var actual = Course.Direction;

        //    Assert.AreEqual("E", actual);
        //}
        //[Test]
        //public void Course_Direction_e_Returned_e()
        //{
        //    var Course = new Course();

        //    Course.Direction = "e";

        //    var actual = Course.Direction;

        //    Assert.AreEqual("e", actual);
        //}
        //[Test]
        //public void Course_Direction_S_Returned_S()
        //{
        //    var Course = new Course();

        //    Course.Direction = "S";

        //    var actual = Course.Direction;

        //    Assert.AreEqual("S", actual);
        //}
        //[Test]
        //public void Course_Direction_s_Returned_s()
        //{
        //    var Course = new Course();

        //    Course.Direction = "s";

        //    var actual = Course.Direction;

        //    Assert.AreEqual("s", actual);
        //}
        //[Test]
        //public void Course_Direction_W_Returned_W()
        //{
        //    var Course = new Course();

        //    Course.Direction = "W";

        //    var actual = Course.Direction;

        //    Assert.AreEqual("W", actual);
        //}
        //[Test]
        //public void Course_Direction_w_Returned_w()
        //{
        //    var Course = new Course();

        //    Course.Direction = "w";

        //    var actual = Course.Direction;

        //    Assert.AreEqual("w", actual);
        //}
        [Test]
        public void Course_Constructor_Direction_N_Returned_N()
        {
            var Course = new Course("N");

            var actual = Course.Direction;

            Assert.AreEqual("N", actual);
        }
        [Test]
        public void Course_Constructor_Direction_n_Returned_n()
        {
            var Course = new Course("n");

            var actual = Course.Direction;

            Assert.AreEqual("n", actual);
        }
        [Test]
        public void Course_Constructor_Direction_E_Returned_E()
        {
            var Course = new Course("E");

            var actual = Course.Direction;

            Assert.AreEqual("E", actual);
        }
        [Test]
        public void Course_Constructor_Direction_e_Returned_e()
        {
            var Course = new Course("e");

            var actual = Course.Direction;

            Assert.AreEqual("e", actual);
        }
        [Test]
        public void Course_Constructor_Direction_S_Returned_S()
        {
            var Course = new Course("S");

            var actual = Course.Direction;

            Assert.AreEqual("S", actual);
        }
        [Test]
        public void Course_Constructor_Direction_s_Returned_s()
        {
            var Course = new Course("s");

            var actual = Course.Direction;

            Assert.AreEqual("s", actual);
        }
        [Test]
        public void Course_Constructor_Direction_W_Returned_W()
        {
            var Course = new Course("W");

            var actual = Course.Direction;

            Assert.AreEqual("W", actual);
        }
        [Test]
        public void Course_Constructor_Direction_w_Returned_w()
        {
            var Course = new Course("w");

            var actual = Course.Direction;

            Assert.AreEqual("w", actual);
        }
        //[Test]
        ////[ExpectedException(typeof(ExceptionUser))]
        //public void Course_Direction_Null_Returned_Exception()
        //{
        //    var course = new Course();

        //    try
        //    {
        //        var actual = course.Direction;
        //    }
        //    catch (ExceptionUser exUser)
        //    {
        //        Assert.AreEqual("Направление Дрона заданно не правильно", exUser.Message);
        //        //throw;
        //    }
        //}

        //[Test]
        ////[ExpectedException(typeof(ExceptionUser))]
        //public void Course_Direction_Set_Incorrect_Returned_Exception()
        //{
        //    var course = new Course();

        //    try
        //    {
        //        course.Direction = "RetNWs";
        //    }
        //    catch (ExceptionUser exUser)
        //    {
        //        Assert.AreEqual("Дрон может иметь только одно направление из (N, E, S, W)", exUser.Message);
        //        //throw;
        //    }
        //}

        //[Test]
        ////[ExpectedException(typeof(ExceptionUser))]
        //public void Course_DirectionInt_Get_Incorrect_Returned_Exception()
        //{
        //    var course = new Course();

        //    try
        //    {
        //        var actual = course.DirectionInt;
        //    }
        //    catch (ExceptionUser exUser)
        //    {
        //        Assert.AreEqual("Направление Дрона заданно не правильно", exUser.Message);
        //        //throw;
        //    }
        //}

        //[Test]
        //public void Course_DirectionInt_Get_N_Returned_1()
        //{
        //    var course = new Course("N");

        //    var actual = course.DirectionInt;

        //    Assert.AreEqual(1, actual);

        //}

        //[Test]
        //public void Course_DirectionInt_Get_E_Returned_2()
        //{
        //    var course = new Course("E");

        //    var actual = course.DirectionInt;

        //    Assert.AreEqual(2, actual);

        //}

        //[Test]
        //public void Course_DirectionInt_Get_S_Returned_3()
        //{
        //    var course = new Course("S");

        //    var actual = course.DirectionInt;

        //    Assert.AreEqual(3, actual);

        //}

        //[Test]
        //public void Course_DirectionInt_Get_W_Returned_4()
        //{
        //    var course = new Course("W");

        //    var actual = course.DirectionInt;

        //    Assert.AreEqual(4, actual);

        //}
    }
}
