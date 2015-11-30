using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Bottom_Layer;
using Robot_D.Exception;
using Robot_D.Exception.Exception_Bottom_Layer;

namespace TestPoint.Test_Botom_Layer
{
    [TestClass]
    public class TestCourse
    {
        [TestMethod]
        public void CourseDirectionTest()
        {   //данные для проверки
            var arrStart = new[]
            {
                "N", "n",
                "E", "e",
                "S", "s",
                "W", "w",
                "Q", "q"
            };

            var arrFinish = new[]
            {
                "N", "N",
                "E", "E",
                "S", "S",
                "W", "W",
                "Q", "Q"
            };

            for (int i = 0; i < arrStart.Length; i++)
            {
                try
                {
                    var course = new Course(arrStart[i]);

                    var actual = course.Direction;

                    Assert.AreEqual(arrFinish[i], actual);
                }
                catch (Exception_Course exceptionUser)
                {
                    Assert.AreEqual("Дрон может иметь только одно направление из (N, E, S, W)", exceptionUser.Message);
                }
            }
        }

        [TestMethod]
        public void CourseTurnL()
        {
            var arrDirectionStart = new[]
            {
                "N", "W", "S", "E"
            };

            var arrDirectionFinish_L = new[]
            {
                "W", "S", "E", "N"
            };

            var side = new[]
            {
                "L", 
                "l", 
                "E", 
                "      l      ",
                "sd",
                "      L"
            };


            foreach (var element in side)
            {
                try
                {
                    for (int i = 0; i < arrDirectionStart.Length; i++)
                    {
                        var course = new Course(arrDirectionStart[i]);

                        course.Turn(element);

                        var actual = course.Direction;

                        Assert.AreEqual(arrDirectionFinish_L[i], actual);
                    }
                }
                catch (Exception_Course exceptionCourse)
                {
                    Assert.AreEqual("Поворот задан не правильно. Попробуйте ещё раз", exceptionCourse.Message);
                }
                
            }
            
        }

        [TestMethod]
        public void CourseTurnR()
        {
            var arrDirectionStart = new[]
            {
                "N", "E", "S", "W"
            };

            var arrDirectionFinish_R = new[]
            {
                "E", "S", "W", "N"
            };

            var side = new[]
            {
                "R", 
                "r", 
                "E", 
                "      r      ",
                "sd",
                "      R"
            };

            foreach (var element in side)
            {
                try
                {
                    for(int i = 0; i < arrDirectionStart.Length; i++)
                    {
                        var course = new Course(arrDirectionStart[i]);

                        course.Turn(element);

                        var actual = course.Direction;

                        Assert.AreEqual(arrDirectionFinish_R[i], actual);
                    }
                }
                catch (Exception_Course exceptionCourse)
                {
                    Assert.AreEqual("Поворот задан не правильно. Попробуйте ещё раз", exceptionCourse.Message);
                }
            }
        }
    }
}
