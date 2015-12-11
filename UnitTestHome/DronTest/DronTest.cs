using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Plato;
using Robot_D.Robot;
using Robot_D.RobotDException.DronException;
using Robot_D.RobotDException.SparePartsException;
using Robot_D.SpareParts;

namespace TestPoint.DronTest
{
    [TestClass]
    public class DronTest
    {
        [TestMethod]
        public void Dron_X()
        {
            var arrX = new[]
            {
                1, 2, 3, -2
            };

            foreach (var element in arrX)
            {
                try
                {
                    var dron = new RobotBody(new Point(element, 1), new Course("N"));

                    var actual = dron.Point.X;

                    Assert.AreEqual(element, actual);
                }
                catch (PointException exceptionPoint)
                {
                    Assert.AreEqual("Задать X координату можно от 0 до 2147483647", exceptionPoint.Message);
                }

            }
        }

        [TestMethod]
        public void Dron_Y()
        {
            var arrY = new[]
            {
                1, 2, 3, -2
            };

            foreach (var element in arrY)
            {
                try
                {
                    var dron = new RobotBody(new Point(1, element), new Course("N"));

                    var actual = dron.Point.Y;

                    Assert.AreEqual(element, actual);
                }
                catch (PointException exceptionPoint)
                {
                    Assert.AreEqual("Задать Y координату можно от 0 до 2147483647", exceptionPoint.Message);
                }

            }
        }

        [TestMethod]
        public void Dron_Direction()
        {
            var arrDirectionStart = new[]
            {
                "N", "n", "E", "e", "W", "w", "S", "s", "tT"
            };

            var arrDirectionFinish = new[]
            {
                "N", "N", "E", "E", "W", "W", "S", "S", "ERROR"
            };

            for (int i = 0; i < arrDirectionStart.Length; i++)
            {
                try
                {
                    var dron = new RobotBody(new Point(1, 1), new Course(arrDirectionStart[i]));

                    var actual = dron.Course.Direction;

                    Assert.AreEqual(arrDirectionFinish[i], actual);
                }
                catch (CourseException exceptionCourse)
                {
                    Assert.AreEqual("Направление может быть одно из (N, E, S, W)", exceptionCourse.Message);
                }
            }
        }

        //[TestMethod]
        //public void Dron_Constructor_String()
        //{
        //    var arr = new[]
        //    {
        //        "1 1 N", 
        //        "-1 1 N",
        //        "1 -1 N",
        //        "1 1 d"
        //    };

        //    foreach (var element in arr)
        //    {
        //        try
        //        {
        //            var dron = new Dron(element);
        //        }
        //        catch (Exception_Dron exceptionDron)
        //        {
        //            Assert.AreEqual("Не правильно задана позиция", exceptionDron.Message);
        //        }
        //    }
        //}

        [TestMethod]
        public void Dron_Move()
        {
            var arrMove = new[]
            {
                "R", "r", "L", "l", "asd", "RT", "2", "MmmmmM"
            };

            var dron = new RobotBody(new Point(1, 1), new Course("N"));

            var area = new Area(new Point(1, 1));

            foreach (var element in arrMove)
            {
                try
                {
                    dron.Run(new Command(element), area);
                }
                catch (CommandException exceptionCommand)
                {
                    Assert.AreEqual("Ваша команда не корректна", exceptionCommand.Message);
                }
                catch (MoveException exceptionMove)
                {
                    Assert.AreEqual("Дрон выходит из зданного поля", exceptionMove.Message);
                }
            }
        }
    }
}
