using Dron_Exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Bottom_Layer;

namespace UnitTestHome.Test_Botom_Layer

{
    [TestClass]
    public class TestPoint
    {
        [TestMethod]
        [ExpectedException(typeof(ExceptionUser))]
        public void Point_Set_X_Returned()
        {
            try
            {
                var Arr = new int[,]
                {
                    { 0, 0 },
                    { -1, 1 },
                    { -1, 1 },
                    { -2147483648, 2147483647 },
                    { 2147483647, -2147483648 }
                };

                //foreach (int iElement in Arr)
                //{
                //    var point = new Point(iElement, 1);

                //    var actual = point.X;

                //    Assert.AreEqual(iElement, actual);
                //}

                for (int i = 0; i <= Arr.Length; i++)
                {
                    var point = new Point(Arr[i,], 1);

                    var actual = point.X;

                    Assert.AreEqual(iElement, actual);
                }
            }
            catch (ExceptionUser exUser)
            {
                Assert.AreEqual("Координата X не может быть меньше нуля", exUser.Message);
                throw;
            }
            //try
            //{
            //    int[] gf = new int[] { 0, 1, -2, -2147483648, 2147483647 };
            //    foreach (var iElement in gf)
            //    {  
            //        var point = new Point(iElement, 1);

            //        var actual = point.X;

            //        Assert.AreEqual(iElement, actual);
            //    }
            //}
            //catch (ExceptionUser exUser)
            //{
            //    Assert.AreEqual("Координата X не может быть меньше нуля", exUser.Message);
            //    throw;
            //}
            //var point = new Point();
        }

            


        //public void Dron_Set_X_1_Returned_1()
        //{
        //    var dron = new Dron();

        //    dron.XCoordinate = 1;

        //    var actual = dron.XCoordinate;

        //    Assert.AreEqual(1, actual);
        //}

    }
}
