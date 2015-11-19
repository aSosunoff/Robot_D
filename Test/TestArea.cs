using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dron_Exception;
using NUnit.Framework;
using Robot_D;
using Robot_D.Center_Layer;

namespace Test
{
    [TestFixture]
    class TestArea
    {
        [Test]
        public void Area_Constructor_int_1_int_1_Returned_Max_X_1()
        {
            var Area = new Area(1, 1);

            var actual = Area.Max_X;

            Assert.AreEqual(1, actual);
        }
        [Test]
        public void Area_Constructor_int_1_int_1_Returned_Max_Y_1()
        {
            var Area = new Area(1, 1);

            var actual = Area.Max_Y;

            Assert.AreEqual(1, actual);
        }
        [Test]
        public void Area_Constructor_string_1_1_Returned_Max_X_1()
        {
            var Area = new Area("1 1");

            var actual = Area.Max_X;

            Assert.AreEqual(1, actual);
        }
        [Test]
        public void Area_Constructor_string_1_1_Returned_Max_Y_1()
        {
            var Area = new Area("1 1");

            var actual = Area.Max_Y;

            Assert.AreEqual(1, actual);
        }
        //[Test]
        //public void Area_Set_MAX_X_1_Returned_Max_X_1()
        //{
        //    var Area = new Area();

        //    Area.Max_X = 1;

        //    var actual = Area.Max_X;

        //    Assert.AreEqual(1, actual);
        //}
        //[Test]
        //public void Area_Set_MAX_Y_1_Returned_Max_Y_1()
        //{
        //    var Area = new Area();

        //    Area.Max_Y = 1;

        //    var actual = Area.Max_Y;

        //    Assert.AreEqual(1, actual);
        //}

        //[Test]
        ////[ExpectedException(typeof(ExceptionUser))]
        //public void Area_Get_Null_Max_X_Returned_Exception()
        //{
        //    var Area = new Area();

        //    try
        //    {
        //        var actual = Area.Max_X;
        //    }
        //    catch (ExceptionUser exUser)
        //    {
        //        Assert.AreEqual("Координата X у поля не корректна", exUser.Message);
        //        //throw;
        //    }
        //}

        //[Test]
        ////[ExpectedException(typeof(ExceptionUser))]
        //public void Area_Get_Null_Max_Y_Returned_Exception()
        //{
        //    var Area = new Area();

        //    try
        //    {
        //        var actual = Area.Max_Y;
        //    }
        //    catch (ExceptionUser exUser)
        //    {
        //        Assert.AreEqual("Координата Y у поля не корректна", exUser.Message);
        //        //throw;
        //    }
        //}

        [Test]
        //[ExpectedException(typeof(ExceptionUser))]
        public void Area_Get_UNCORRECT_str_Returned_Exception()
        {


            try
            {
                var Area = new Area("1dew2");
            }
            catch (ExceptionUser exUser)
            {
                Assert.AreEqual("Координаты поля не корректны", exUser.Message);
                //throw;
            }
        }

        [Test]
        //[ExpectedException(typeof(ExceptionUser))]
        public void Area_UNCORRECT_Param_Returned_Exception()
        {


            try
            {
                var Area = new Area(-1, 2);
            }
            catch (ExceptionUser exUser)
            {
                Assert.AreEqual("Координаты поля не корректны", exUser.Message);
                //throw;
            }
        }

        //[Test]
        ////[ExpectedException(typeof(ExceptionUser))]
        //public void Area_SetArea_UNCORRECT_Returned_Exception()
        //{
        //    var Area = new Area();

        //    try
        //    {
        //        Area.SetArea = "as2";
        //    }
        //    catch (ExceptionUser exUser)
        //    {
        //        Assert.AreEqual("Координаты поля не корректны", exUser.Message);
        //        //throw;
        //    }
        //}
    }
}
