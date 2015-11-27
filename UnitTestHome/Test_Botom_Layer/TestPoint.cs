using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Bottom_Layer;
using Robot_D.Exception;

namespace TestPoint.Test_Botom_Layer

{
    [TestClass]
    public class TestPoint
    {
        [TestMethod]
<<<<<<< HEAD
        public void Point_Set_X_Y_Int()
=======
        public void Point_Set_X_Y_int()
>>>>>>> 484d1c46f0c185fda0f0bcad331bbc74075d2dd9
        {
            try
            {
                var arr = new[,]
                {
                    { 0, 1 },
                    { -1, 1 },
                    { -1, 1 },
                    { -2147483648, 2147483647 },
                    { 2147483647, -2147483648 },
                };

                int index = 0;

                foreach (int iElement in arr)
                {
                    int actual;
                    if (( index % 2) == 0)
                    {
                        var point = new Point(iElement, 1);

                        actual = point.X;                
                    }
                    else
                    {
                        var point = new Point(1, iElement);

                        actual = point.Y;
                    }
                    Assert.AreEqual(iElement, actual);
                    index++;
                }
            }
            catch (ExceptionPointX exPointX)
            {
                Assert.AreEqual("Координата X не может быть меньше нуля", exPointX.Message);
            }
            catch (ExceptionPointY exPointY)
            {
                Assert.AreEqual("Координата Y не может быть меньше нуля", exPointY.Message);
            }
        }


        //,
        //            { -1, 1 },
        //            { -2147483648, 2147483647 },
        //            { 2147483647, -2147483648 },
        [TestMethod]
        public void Point_Set_X_Y_string()
        {
            try
            {
                var arrIn = new[]
                {
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
                    var point = new Point(arrIn[i]);

                    var actual = point.X;
                    Assert.AreEqual(arrOut[i*2], actual);

                    actual = point.Y;
                    Assert.AreEqual(arrOut[i*2 + 1], actual);
                }
            }
            catch (ExceptionPointX exPointX)
            {
                Assert.AreEqual("Координата X не может быть меньше нуля", exPointX.Message);
            }
            catch (ExceptionPointY exPointY)
            {
                Assert.AreEqual("Координата Y не может быть меньше нуля", exPointY.Message);
            }
            catch (ExceptionPointSetCoordinateString exPointSetCoordinateString)
            {
                Assert.AreEqual("Некоректные координаты объекта", exPointSetCoordinateString.Message);
            }
        }
    }
}
