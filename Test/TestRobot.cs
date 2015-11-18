using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dron_Exception;
using NUnit.Framework;
using Robot_D;
using Robot_D.Center_Layer;

namespace Test
{
    [TestFixture]
    class TestRobot
    {
        //[Test]
        //public void Dron_Set_X_1_Returned_1()
        //{
        //    var dron = new Dron();

        //    dron.XCoordinate = 1;

        //    var actual = dron.XCoordinate;

        //    Assert.AreEqual(1, actual);
        //}

        //[Test]
        //public void Dron_Set_Y_1_Returned_1()
        //{
        //    var dron = new Dron();

        //    dron.YCoordinate = 1;

        //    var actual = dron.YCoordinate;

        //    Assert.AreEqual(1, actual);
        //}

        //[Test]
        //public void Dron_Set_Direction_N_Returned_N()
        //{
        //    var dron = new Dron();

        //    dron.Direction = "N";

        //    var actual = dron.Direction;

        //    Assert.AreEqual("N", actual);
        //}

        //[Test]
        ////[ExpectedException(typeof(ExceptionUser))]
        //public void Dron_Move_Returned_Exception()
        //{
        //    var dron = new Dron();
        //    var area = new Area();
        //    try
        //    {
        //        dron.Move("5 5\n1 3 N\n LmeLMR", area);
        //    }
        //    catch (ExceptionUser exUser)
        //    {
        //        Assert.AreEqual("Команда движения задана не правилно", exUser.Message);
        //        //throw;
        //    }
        //}

        [Test]
        public void Dron_Move_L_Dron_1_1_N_Area_5_5_Returned_Direction_W()
        {
            var dron = new Dron("1 1 N");
            var area = new Area("5 5");

            dron.Move("L", area);

            
            Assert.AreEqual("W", dron.Direction);
        }

        [Test]
        public void Dron_Move_L_Dron_1_1_W_Area_5_5_Returned_Direction_S()
        {
            var dron = new Dron("1 1 W");
            var area = new Area("5 5");

            dron.Move("L", area);


            Assert.AreEqual("S", dron.Direction);
        }

        [Test]
        public void Dron_Move_L_Dron_1_1_S_Area_5_5_Returned_Direction_E()
        {
            var dron = new Dron("1 1 S");
            var area = new Area("5 5");

            dron.Move("L", area);


            Assert.AreEqual("E", dron.Direction);
        }

        [Test]
        public void Dron_Move_L_Dron_1_1_E_Area_5_5_Returned_Direction_N()
        {
            var dron = new Dron("1 1 E");
            var area = new Area("5 5");

            dron.Move("L", area);


            Assert.AreEqual("N", dron.Direction);
        }


        [Test]
        public void Dron_Move_R_Dron_1_1_N_Area_5_5_Returned_Direction_E()
        {
            var dron = new Dron("1 1 N");
            var area = new Area("5 5");

            dron.Move("R", area);


            Assert.AreEqual("E", dron.Direction);
        }

        [Test]
        public void Dron_Move_R_Dron_1_1_W_Area_5_5_Returned_Direction_N()
        {
            var dron = new Dron("1 1 W");
            var area = new Area("5 5");

            dron.Move("R", area);


            Assert.AreEqual("N", dron.Direction);
        }

        [Test]
        public void Dron_Move_R_Dron_1_1_S_Area_5_5_Returned_Direction_W()
        {
            var dron = new Dron("1 1 S");
            var area = new Area("5 5");

            dron.Move("R", area);


            Assert.AreEqual("W", dron.Direction);
        }

        [Test]
        public void Dron_Move_R_Dron_1_1_E_Area_5_5_Returned_Direction_S()
        {
            var dron = new Dron("1 1 E");
            var area = new Area("5 5");

            dron.Move("R", area);


            Assert.AreEqual("S", dron.Direction);
        }

        [Test]
        public void Dron_Constructor_X_1_Returned_1()
        {
            var dron = new Dron(1, 1,"E");
            var actual = dron.X;
            Assert.AreEqual(1, actual);
        }
    }
}
