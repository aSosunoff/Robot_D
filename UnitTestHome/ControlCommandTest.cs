using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Dispatcher;
using Robot_D.RobotDException.DispatcherException;

namespace TestPoint
{
    [TestClass]
    public class ControlCommandTest
    {
        [TestMethod]
        public void ControlCommand()
        {
            var inputStringCommand = new[]
            {
                "5 5\r\n1 2 N\r\nLMLMLMLMM\r\n",
                "5 5\r\n1 2 N\r\nLMLMLMLMM\r\n1 2 N\r\nLMLMLMLMM\r\n",
                "5 5\r\n1 2 N\r\nLMLMLMLMM\r\n1 -2 N\r\nLMLMLMLMM\r\n"
            };

            var outputValues = new IComparable[]
            {
                1,
                2,
                "ERROR"
            };

            for(int i = 0; i < inputStringCommand.Length; i++)
            {
                try
                {
                    var controlCommand = new ControlCommand(new DevideCommand(inputStringCommand[i]));
                    Assert.AreEqual(controlCommand.GetFinalPositionRobot.Count, outputValues[i]);
                }
                catch (CommandControlException exception)
                {
                    Assert.AreEqual("Строка не корректна.", exception.Message);
                }
            }
        }
    }
}
