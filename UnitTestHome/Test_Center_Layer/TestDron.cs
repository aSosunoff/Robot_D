using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Dron;
using Robot_D.Exception.Exception_Bottom_Layer;
using Robot_D.Exception.Exception_Center_Layer;
using Robot_D.Plato;
using Robot_D.Spare_Paths;

namespace TestPoint.Test_Center_Layer
{
    [TestClass]
    public class TestDron
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
                    var dron = new Dron(new Point(element, 1), new Course("N"));

                    var actual = dron.X;

                    Assert.AreEqual(element, actual);
                }
                catch (Exception_Point exceptionPoint)
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
                    var dron = new Dron(new Point(1, element), new Course("N"));

                    var actual = dron.Y;

                    Assert.AreEqual(element, actual);
                }
                catch (Exception_Point exceptionPoint)
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
                    var dron = new Dron(new Point(1, 1), new Course(arrDirectionStart[i]));

                    var actual = dron.Direction;

                    Assert.AreEqual(arrDirectionFinish[i], actual);
                }
                catch (Exception_Course exceptionCourse)
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

            var dron = new Dron(new Point(1, 1), new Course("N"));

            var area = new Area(new Point(1, 1));//(1, 1);

            foreach (var element in arrMove)
            {
                try
                {
                    dron.Move(element, area);
                }
                catch (Exception_Move exceptionMove)
                {
                    switch (exceptionMove.Message)
                    {
                        case "Дрон выходит из зданного поля":
                            Assert.AreEqual("Дрон выходит из зданного поля", exceptionMove.Message);
                            break;
                        case "Ваша команда не корректна":
                            Assert.AreEqual("Ваша команда не корректна", exceptionMove.Message);
                            break;
                    }

                }
            }
        }
    }
}
