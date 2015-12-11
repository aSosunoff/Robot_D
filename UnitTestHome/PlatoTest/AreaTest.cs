using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Plato;
using Robot_D.RobotDException.SparePartsException;
using Robot_D.SpareParts;

namespace TestPoint.PlatoTest
{
    [TestClass]
    public class AreaTest
    {
        [TestMethod]
        public void Area_Constructor_X_Y_int()
        {
            var values = new[]
            {
                -1, 1, 2, 3, -1, 400000000
            };

            foreach (var xElement in values)
            {
                try
                {
                    var area = new Area(new Point(xElement, 1)); //xElement, 1);

                    var actual = area.Point.X;

                    Assert.AreEqual(xElement, actual);
                }
                catch (PointException exceptionPoint)
                {
                    Assert.AreEqual("Задать X координату можно от 0 до 2147483647", exceptionPoint.Message);
                }
                
            }

            foreach (var yElement in values)
            {
                try
                {
                    var area = new Area(new Point(1, yElement));//(1, yElement);

                    var actual = area.Point.Y;

                    Assert.AreEqual(yElement, actual);
                }
                catch (PointException exceptionPoint)
                {
                    Assert.AreEqual("Задать Y координату можно от 0 до 2147483647", exceptionPoint.Message);
                }

            }
            
        }

        [TestMethod]
        public void Area_Constructor_X_Y_string()
        {
            var inputStringXY = new[]
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
            var outputValues = new[]
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

            for (int i = 0; i < inputStringXY.Length; i++)
            {
                try
                {
                    var area = new Area(new Point(inputStringXY[i]));//arrIn[i]);

                    var actual = area.Point.X;
                    Assert.AreEqual(outputValues[i * 2], actual);

                    actual = area.Point.Y;
                    Assert.AreEqual(outputValues[i * 2 + 1], actual);
                }
                catch (PointException exceptionPoint)
                {
                    Assert.AreEqual("Строка должна содержать 2 числа через [Пробел]", exceptionPoint.Message);
                }
            }
        }
    }
}
