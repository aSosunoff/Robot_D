using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Dispatcher;
using Robot_D.Exception_App;

namespace TestPoint
{
    [TestClass]
    public class TestDevideCommand
    {
        [TestMethod]
        public void DevideCommand_Test()
        {
            var arrCommandStart = new[]
            {
                "5 5\r\n1 2 N\r\nLMLMLMLMM\r\n",
                "5 5\r\n1 2 N\r\nLMLMLMLMM\r\n1 2 N"
            };

            var arrCommandFinish = new[]
            {
                3,
                666
            };

            for (int i = 0; i < arrCommandStart.Length; i++)
            {
                try
                {
                    DevideCommand devideCommand = new DevideCommand(arrCommandStart[i]);

                    Assert.AreEqual(devideCommand.ArrCommand.Length, arrCommandFinish[i]);
                }
                catch (Exception_Devide_Command exceptionDevideCommand)
                {
                    Assert.AreEqual(exceptionDevideCommand.Message, "Не достаточно данных для отправки");
                }
            }
        }
    }
}
