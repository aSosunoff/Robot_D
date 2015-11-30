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
        {   //данные для проверки
            var arr = new[]
            {
                "N", "n",
                "E", "e",
                "S", "s",
                "W", "w",
                "Q", "q"
            };

            foreach (var element in arr)
            {
                try
                {
                    var course = new Course(element);

                    var actual = course.Direction;

                    Assert.AreEqual(element, actual);
                }
                catch (ExceptionUser w)
                {
                    Assert.AreEqual("Дрон может иметь только одно направление из (N, E, S, W)", w.Message);
                }
            }

        }

        [TestMethod]
        public void CourseTurnTestSide_L()
        {
            var arrDirectionStart = new[]
            {
                "N", "W", "S", "E"
            };

            var arrDirectionFinish_L = new[]
            {
                "W", "S", "E", "N"
            };

            var arrDirectionFinish_R = new[]
            {
                "N", "W", "S", "E"
            };

            for (int i = 0; i < arrDirectionStart.Length; i++)
            {
                var course = new Course(arrDirectionStart[i]);

                course.Turn("L");

                var actual = course.Direction;

                Assert.AreEqual(arrDirectionFinish_L[i], actual);

                course.Turn("R");

                actual = course.Direction;

                Assert.AreEqual(arrDirectionFinish_R[i], actual);   
            }
            
        }
    }
}
