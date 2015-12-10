using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D;
using Robot_D.Dron;
using Robot_D.Exception_App.Exception_Spare_Parts;
using Robot_D.Plato;
using Robot_D.Spare_Paths;

namespace TestPoint.Test_Center_Layer
{
    [TestClass]
    public class TestMove
    {
        [TestMethod]
        public void Move_Run_Test()
        {
            var commandStart = new[]
            {
                "MmmRRmmmm",
                "M",
                "LMLMLMLMLMM",
                "MMRMM",
                "Rmmmmmmmmmm",
                "RmmmmmmmmmmM",
                "mmmmmmmmmm",
                "mmmmmmmmmmM",
                "MmmRRmm",
                "MmmRRmmmm",
                "RMMLLMM",
                "RMMLLMMM"
            };

            var commandFinish = new[]
            {
                new IComparable[]{"ERROR"},
                new IComparable[]{0, 1, "N"},
                new IComparable[]{"ERROR"},
                new IComparable[]{2, 2, "E"},
                new IComparable[]{10, 0, "E"},
                new IComparable[]{"ERROR"},
                new IComparable[]{0, 10, "N"},
                new IComparable[]{"ERROR"},
                new IComparable[]{0, 1, "S"},
                new IComparable[]{"ERROR"},
                new IComparable[]{0, 0, "W"},
                new IComparable[]{"ERROR"}
            };

            for (int i = 0; i < commandStart.Length; i++)
            {
                var point = new Point(0, 0);

                var course = new Course("N");

                try
                {
                    new Move(point, course, new Command(commandStart[i]), new Area(new Point(10, 10)));

                    Assert.AreEqual(commandFinish[i][0], point.X);

                    Assert.AreEqual(commandFinish[i][1], point.Y);

                    Assert.AreEqual(commandFinish[i][2], course.Direction);
                }
                catch (Exception_Move exceptionMove)
                {
                    Assert.AreEqual("Дрон выходит из зданного поля", exceptionMove.Message);
                }
            }
        }
    }
}
