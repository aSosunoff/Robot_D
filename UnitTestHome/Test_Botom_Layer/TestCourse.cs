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
        public void CourseTurnTest()
        {
            var arr = new[]
            {
                "L", "R"
            };

            var arrDirectionStart = new[]
            {
                "N"
            };

            var arrDirectionFinish = new[]
            {
                "N"
            };

            foreach (var element in arr)
            {
                foreach (var elementdirection in arrDirectionStart)
                {
                    var course = new Course(elementdirection);

                    course.Turn(element);

                    var actual = course.Direction;

                    Assert.AreEqual("W", actual);   
                }
            }
            

            

            
        }
    }
}
