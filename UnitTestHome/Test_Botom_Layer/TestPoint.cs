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
        public void Point_Set_X_Y_int()
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
            int actual;

            foreach (int iElement in arr)
            {
                try
                {
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
                }
                catch (ExceptionPointX exPointX)
                {
                    Assert.AreEqual("Координата X не может быть меньше нуля", exPointX.Message);
                }
                catch (ExceptionPointY exPointY)
                {
                    Assert.AreEqual("Координата Y не может быть меньше нуля", exPointY.Message);
                }

                index++;
            }
        }


        //,
        //            { -1, 1 },
        //            { -2147483648, 2147483647 },
        //            { 2147483647, -2147483648 },
        [TestMethod]
        public void Point_Set_X_Y_string()
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
                        var point = new Point(arrIn[i]);

                        var actual = point.X;
                        Assert.AreEqual(arrOut[i*2], actual);

                        actual = point.Y;
                        Assert.AreEqual(arrOut[i*2 + 1], actual);
                    }
                    catch (ExceptionPointSetCoordinateString exPointSetCoordinateString)
                    {
                        Assert.AreEqual("Некоректные координаты объекта", exPointSetCoordinateString.Message);
                    }
                }
            
        }
    }
}
