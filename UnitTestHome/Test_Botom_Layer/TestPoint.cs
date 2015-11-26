using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Bottom_Layer;
using Robot_D.Exception;

namespace UnitTestHome.Test_Botom_Layer

{
    [TestClass]
    public class TestPoint
    {
        [TestMethod]
        public void Point_Set_X_Y_Int()
        {
            try
            {
                var Arr = new int[,]
                {
                    { 0, 1 },
                    { -1, 1 },
                    { -1, 1 },
                    { -2147483648, 2147483647 },
                    { 2147483647, -2147483648 },
                };

                int index = 0;

                foreach (int iElement in Arr)
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
    }
}
