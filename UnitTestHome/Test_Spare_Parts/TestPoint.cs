using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Exception_App.Exception_Spare_Parts;
using Robot_D.Exception_App.Exception_Spare_Parts;
using Robot_D.Spare_Parts;

namespace TestPoint.Test_Botom_Layer

{
    [TestClass]
    public class TestPoint
    {
        [TestMethod]
        public void Point_Set_X_int()
        {
            var arrStart = new[]
            {
                0,
                -1,
                -2147483648,
                2147483647
            };

            foreach (int xElement in arrStart)
            {
                try
                {
                    var point = new Point(xElement, 1);

                    var actual = point.X;

                    Assert.AreEqual(xElement, actual);
                }
                catch (Exception_Point exceptionPoint)
                {
                    Assert.AreEqual("Задать X координату можно от 0 до 2147483647", exceptionPoint.Message);
                }
            }
        }

        [TestMethod]
        public void Point_Set_Y_int()
        {
            var arrStart = new[]
            {
                1,
                -1,
                2147483647,
                -2147483648,
                0
            };

            foreach (int yElement in arrStart)
            {
                try
                {
                    var point = new Point(1, yElement);

                    var actual = point.Y;

                    Assert.AreEqual(yElement, actual);
                }
                catch (Exception_Point exceptionPoint)
                {
                    Assert.AreEqual("Задать Y координату можно от 0 до 2147483647", exceptionPoint.Message);
                }
            }
        }

        [TestMethod]
        public void Point_Set_X_Y_string()
        {
            var arrIn = new[]
            {//000 000 доделать регулярку
                "       0           0           ",
                "0           0",
                "   0 0",
                "0 0        ",
                "0 0",
                "1           0      ",
                "1           0",
                "1 0      ",
                "1 0",
                "          0            1",
                "0            1",
                "0 1        ",
                "0 1",
                "         0 1",
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
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                0, 0,
                1, 0,
                1, 0,
                1, 0,
                1, 0,
                0, 1,
                0, 1,
                0, 1,
                0, 1,
                0, 1,
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
                    var point = new Point(arrIn[i]);

                    var actual = point.X;
                    Assert.AreEqual(arrOut[i*2], actual);

                    actual = point.Y;
                    Assert.AreEqual(arrOut[i*2 + 1], actual);
                }
                catch (Exception_Point exceptionPoint)
                {
                    Assert.AreEqual("Строка должна содержать 2 числа через [Пробел]", exceptionPoint.Message);
                }
            }
            
        }
    }
}
