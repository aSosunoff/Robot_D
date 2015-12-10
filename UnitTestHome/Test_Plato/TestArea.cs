using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Exception_App.Exception_Spare_Parts;
using Robot_D.Exception_App.Exception_Spare_Parts;
using Robot_D.Plato;
using Robot_D.Spare_Parts;

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
                    var area = new Area(new Point(xElement, 1)); //xElement, 1);

                    var actual = area._point.X;

                    Assert.AreEqual(xElement, actual);
                }
                catch (Exception_Point exceptionPoint)
                {
                    Assert.AreEqual("Задать X координату можно от 0 до 2147483647", exceptionPoint.Message);
                }
                
            }

            foreach (var yElement in arrStart)
            {
                try
                {
                    var area = new Area(new Point(1, yElement));//(1, yElement);

                    var actual = area._point.Y;

                    Assert.AreEqual(yElement, actual);
                }
                catch (Exception_Point exceptionPoint)
                {
                    Assert.AreEqual("Задать Y координату можно от 0 до 2147483647", exceptionPoint.Message);
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
                    var area = new Area(new Point(arrIn[i]));//arrIn[i]);

                    var actual = area._point.X;
                    Assert.AreEqual(arrOut[i * 2], actual);

                    actual = area._point.Y;
                    Assert.AreEqual(arrOut[i * 2 + 1], actual);
                }
                catch (Exception_Point exceptionPoint)
                {
                    Assert.AreEqual("Строка должна содержать 2 числа через [Пробел]", exceptionPoint.Message);
                }
            }
        }
    }
}
