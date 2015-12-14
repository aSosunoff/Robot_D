using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.RobotDException.SparePartsException;
using Robot_D.SpareParts;

namespace TestPoint.SparePartsTest

{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void Point_Set_X_int()
        {
            var inputValues = new[]
            {
                0,
                -1,
                -2147483648,
                2147483647
            };

            foreach (int xElement in inputValues)
            {
                try
                {
                    var point = new Point(xElement, 1);

                    var actual = point.X;

                    Assert.AreEqual(xElement, actual);
                }
                catch (PointException exceptionPoint)
                {
                    Assert.AreEqual("Задать X координату можно от 0 до 2147483647", exceptionPoint.Message);
                }
            }
        }

        [TestMethod]
        public void Point_Set_Y_int()
        {
            var inputValues = new[]
            {
                1,
                -1,
                2147483647,
                -2147483648,
                0
            };

            foreach (int yElement in inputValues)
            {
                try
                {
                    var point = new Point(1, yElement);

                    var actual = point.Y;

                    Assert.AreEqual(yElement, actual);
                }
                catch (PointException exceptionPoint)
                {
                    Assert.AreEqual("Задать Y координату можно от 0 до 2147483647", exceptionPoint.Message);
                }
            }
        }

        [TestMethod]
        public void Point_Set_X_Y_string()
        {
            var inputStringXY = new[]
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
            var outputValues = new[]
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

            for (int i = 0; i < inputStringXY.Length; i++)
            {
                try
                {
                    var point = new Point(inputStringXY[i]);

                    var actual = point.X;
                    Assert.AreEqual(outputValues[i*2], actual);

                    actual = point.Y;
                    Assert.AreEqual(outputValues[i*2 + 1], actual);
                }
                catch (PointException exceptionPoint)
                {
                    Assert.AreEqual("Строка должна содержать 2 числа через [Пробел]. Только положительные числа.", exceptionPoint.Message);
                }
            }
            
        }
    }
}
