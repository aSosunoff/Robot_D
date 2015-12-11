using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Dispatcher;
using Robot_D.RobotDException.DispatcherException;

namespace TestPoint
{
    [TestClass]
    public class DevideCommandTest
    {
        [TestMethod]
        public void DevideCommand_Test()
        {
            var inputStringCommand = new[]
            {
                "5 5\r\n1 2 N\r\nLMLMLMLMM\r\n",
                "5 5\r\n1 2 N\r\nLMLMLMLMM\r\n1 2 N"
            };

            var outputValues = new IComparable[]
            {
                3,
                "ERROR"
            };

            for (int i = 0; i < inputStringCommand.Length; i++)
            {
                try
                {
                    DevideCommand devideCommand = new DevideCommand(inputStringCommand[i]);

                    Assert.AreEqual(devideCommand.GetArrayListCommand.Length, outputValues[i]);
                }
                catch (DevideCommandException exceptionDevideCommand)
                {
                    Assert.AreEqual(exceptionDevideCommand.Message, "Не достаточно данных для отправки");
                }
            }
        }
    }
}
