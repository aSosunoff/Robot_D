using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Center_Layer;
using Robot_D.Exception;
using Robot_D.Exception.Exception_Center_Layer;

namespace TestPoint.Test_Center_Layer
{
    [TestClass]
    public class TestArea
    {
        [TestMethod]
        public void Area_Constructor_X_Y_int()
        {
            var arrStart = new[]
            {
                -1, 1, 2, 3, -1, 400000000
            };

            foreach (var xElement in arrStart)
            {
                try
                {
                    var area = new Area(xElement, 1);

                    var actual = area.Max_X;

                    Assert.AreEqual(xElement, actual);
                }
                catch (Exception_Area exceptionArea)
                {
                    Assert.AreEqual("Координаты поля не корректны\r\nЗадать X координату можно от 0 до 2147483647", exceptionArea.Message);
                }
                
            }

            foreach (var yElement in arrStart)
            {
                try
                {
                    var area = new Area(1, yElement);

                    var actual = area.Max_Y;

                    Assert.AreEqual(yElement, actual);
                }
                catch (Exception_Area exceptionArea)
                {
                    Assert.AreEqual("Координаты поля не корректны\r\nЗадать Y координату можно от 0 до 2147483647", exceptionArea.Message);
                }

            }
            
        }

        [TestMethod]
        public void Area_Constructor_X_Y_string()
        {
            var arrIn = new[]
            {
                "      0000020000103       0150       ",
                "1 -1",
                "-1 1",
                "05 06",
                "1 1",
                "0304 430",
                "10 01",
                "      103       015       "
            };
            var arrOut = new[]
            {
                20000103, 150,
                1, -1,
                -1, 1,
                5, 6,
                1, 1,
                304, 430,
                10, 01,
                103, 15
            };

            for (int i = 0; i < arrIn.Length; i++)
            {
                try
                {
                    var area = new Area(arrIn[i]);

                    var actual = area.Max_X;
                    Assert.AreEqual(arrOut[i * 2], actual);

                    actual = area.Max_Y;
                    Assert.AreEqual(arrOut[i * 2 + 1], actual);
                }
                catch (Exception_Area exceptionArea)
                {
                    Assert.AreEqual("Координаты поля не корректны\r\nСтрока должна содержать 2 числа через [Пробел]", exceptionArea.Message);
                }
            }
        }
    }
}
