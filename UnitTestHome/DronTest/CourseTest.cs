using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Robot;
using Robot_D.RobotDException.DronException;

namespace TestPoint.DronTest
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseDirectionTest()
        {   
            var inputStringDirection = new[]
            {
                "N", "n",
                "E", "e",
                "S", "s",
                "W", "w",
                "ERROR", "ERROR"
            };

            var outputValue = new[]
            {
                "N", "N",
                "E", "E",
                "S", "S",
                "W", "W",
                "Q", "Q"
            };

            for (int i = 0; i < inputStringDirection.Length; i++)
            {
                try
                {
                    var course = new Course(inputStringDirection[i]);

                    var actual = course.Direction;

                    Assert.AreEqual(outputValue[i], actual);
                }
                catch (CourseException exceptionUser)
                {
                    Assert.AreEqual("Направление может быть одно из (N, E, S, W)", exceptionUser.Message);
                }
            }
        }

        [TestMethod]
        public void CourseTurnL()
        {
            var currentDirection = new[]
            {
                "N", "W", "S", "E"
            };

            var finalDirection = new[]
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
                    for (int i = 0; i < currentDirection.Length; i++)
                    {
                        var course = new Course(currentDirection[i]);

                        course.Turn(element);

                        var actual = course.Direction;

                        Assert.AreEqual(finalDirection[i], actual);
                    }
                }
                catch (CourseException exceptionCourse)
                {
                    Assert.AreEqual("Поворот задан не правильно. Попробуйте ещё раз", exceptionCourse.Message);
                }
                
            }
            
        }

        [TestMethod]
        public void CourseTurnR()
        {
            var currentDirection = new[]
            {
                "N", "E", "S", "W"
            };

            var finalDirection = new[]
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
                    for(int i = 0; i < currentDirection.Length; i++)
                    {
                        var course = new Course(currentDirection[i]);

                        course.Turn(element);

                        var actual = course.Direction;

                        Assert.AreEqual(finalDirection[i], actual);
                    }
                }
                catch (CourseException exceptionCourse)
                {
                    Assert.AreEqual("Поворот задан не правильно. Попробуйте ещё раз", exceptionCourse.Message);
                }
            }
        }
    }
}
