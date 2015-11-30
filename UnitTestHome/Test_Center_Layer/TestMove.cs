using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Center_Layer;
using Robot_D.Exception.Exception_Bottom_Layer;

namespace TestPoint.Test_Center_Layer
{
    [TestClass]
    public class TestMove
    {
        [TestMethod]
        public void Move_Constructor_X()
        {
            var arr = new[]
            {
                1, 2, 3, -1
            };

            foreach (var element in arr)
            {
                try
                {
                    var move = new Move(element, 1, "N");

                    var actual = move.X;

                    Assert.AreEqual(element, actual);
                }
                catch (Exception_Point exceptionPoint)
                {
                    Assert.AreEqual("Задать X координату можно от 0 до 2147483647", exceptionPoint.Message);
                }
            }   
        }
        [TestMethod]
        public void Move_Constructor_Y()
        {
            var arr = new[]
            {
                1, 2, 3, -1
            };

            foreach (var element in arr)
            {
                try
                {
                    var move = new Move(1, element, "N");

                    var actual = move.Y;

                    Assert.AreEqual(element, actual);
                }
                catch (Exception_Point exceptionPoint)
                {
                    Assert.AreEqual("Задать Y координату можно от 0 до 2147483647", exceptionPoint.Message);
                }
            }
        }

        [TestMethod]
        public void Move_Constructor_Direction()
        {
            var arrStart = new[]
            {
                "R", "N", "W", "E", "S", "s", "e", "w", "n", "As"
            };

            var arrFinish = new[]
            {
                "ERROR", "N", "W", "E", "S", "S", "E", "W", "N", "ERROR"
            };
            for (int i = 0; i < arrStart.Length; i++)
            {
                try
                {
                    var move = new Move(1, 1, arrStart[i]);

                    var actual = move.Direction;

                    Assert.AreEqual(arrFinish[i], actual);
                }
                catch (Exception_Course exceptionCourse)
                {
                    Assert.AreEqual("Дрон может иметь только одно направление из (N, E, S, W)", exceptionCourse.Message);
                }
            }
        }

        [TestMethod]
        public void Move_Set_X_Y()
        {
            var arr = new[]
            {
                1, 2, 3, -1
            };

            foreach (var element in arr)
            {
                var move = new Move(1, 1, "N");

                try
                {
                    move.X = element;

                    var actual = move.X;

                    Assert.AreEqual(element, actual);
                }
                catch (Exception_Point exceptionPoint)
                {
                    Assert.AreEqual("Задать X координату можно от 0 до 2147483647", exceptionPoint.Message);
                }

                try{
                    move.Y = element;

                    var actual = move.Y;

                    Assert.AreEqual(element, actual);
                }
                catch (Exception_Point exceptionPoint)
                {
                    Assert.AreEqual("Задать Y координату можно от 0 до 2147483647", exceptionPoint.Message);
                }
            }
        }

        [TestMethod]
        public void Move_Set_Direction()
        {
            var arrStart = new[]
            {
                "N", "W", "S", "E", "e", "s", "w", "n", "as"
            };

            var arrFinish = new[]
            {
                "N", "W", "S", "E", "E", "S", "W", "N", "ERROR"
            };

            for (int i = 0; i < arrStart.Length; i++)
            {
                var move = new Move(1, 1, "N");

                try
                {
                    move.Direction = arrStart[i];

                    var actual = move.Direction;

                    Assert.AreEqual(arrFinish[i], actual);
                }
                catch (Exception_Course exceptionCourse)
                {
                    Assert.AreEqual("Дрон может иметь только одно направление из (N, E, S, W)", exceptionCourse.Message);
                }
            }
        }

        [TestMethod]
        public void Move_Constructor_String()
        {
            var arrStart = new[]
            {
                "    1 1 N", 
                "2      323232 w"
            };

            var arrFinish = new[]
            {
                "1 1 N", 
                "2 323232 W"
            };

            for (int i = 0; i < arrStart.Length; i++)
            {

                try
                {
                    var move = new Move(arrStart[i]);

                    var actual = String.Format("{0} {1} {2}", move.X, move.Y, move.Direction);

                    Assert.AreEqual(arrFinish[i], actual);
                }
                catch (Exception_Course exceptionCourse)
                {
                    Assert.AreEqual("Не правильно задана позиция", exceptionCourse.Message);
                }
            }
        }

    }
}
