using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Bottom_Layer;
using Robot_D.Exception;

namespace TestPoint.Test_Botom_Layer
{
    [TestClass]
    public class TestCourse
    {
        [TestMethod]
        public void CourseTest()
        {
            var arr = new[]
            {
                "N", "n",
                "E", "e",
                "S", "s",
                "W", "w",
                "Q", "q"
            };

            foreach (var elDirection in arr)
            {
                try
                {
                    var course = new Course(elDirection);

                    var actual = course.Direction;

                    Assert.AreEqual(elDirection, actual);
                }
                catch (ExceptionUser w)
                {
                    Assert.AreEqual("Дрон может иметь только одно направление из (N, E, S, W)", w.Message);
                }
            }

        }
    }
}
