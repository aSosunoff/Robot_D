using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Plato;
using Robot_D.Robot;
using Robot_D.RobotDException.DronException;
using Robot_D.SpareParts;

namespace TestPoint.DronTest
{
    [TestClass]
    public class MoveTest
    {
        [TestMethod]
        public void Move_Run_Test()
        {
            var inputStringComandRun = new[]
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

            var outputStringComandRun = new[]
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

            for (int i = 0; i < inputStringComandRun.Length; i++)
            {
                var point = new Point(0, 0);

                var course = new Course("N");

                try
                {
                    new Move(point, course, new Command(inputStringComandRun[i]), new Area(new Point(10, 10)));

                    Assert.AreEqual(outputStringComandRun[i][0], point.X);

                    Assert.AreEqual(outputStringComandRun[i][1], point.Y);

                    Assert.AreEqual(outputStringComandRun[i][2], course.Direction);
                }
                catch (MoveException exceptionMove)
                {
                    Assert.AreEqual("Дрон выходит из зданного поля", exceptionMove.Message);
                }
            }
        }
    }
}
