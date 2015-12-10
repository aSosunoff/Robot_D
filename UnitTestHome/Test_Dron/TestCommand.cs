using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D;
using Robot_D.Dron;
using Robot_D.Exception_App.Exception_Spare_Parts;
using Robot_D.Plato;
using Robot_D.Spare_Paths;

namespace TestPoint
{
    [TestClass]
    public class TestCommand
    {
        [TestMethod]
        public void Command_Test()
        {
            var commandStart = new[]
            {
                "llmmT",
                "lmMRrRlMm",
                "  lm M RrRl  r r rrlL     L",
                "lmMRrRlMmmmmM3",
                "l",
                "lmMRrRlMmmmqwe#",
                "NnNn N n  NNNMmmM",
                "EMmmMMM",
                "Mmmm",
                "lMmmm"
            };

            var commandFinish = new[]
            {
                new[]{"ERROR"},
                new[]{"L","M","M","R","R","R","L","M","M"},
                new []{"L","M","M","R","R","R","L","R","R","R","R","L","L","L"},
                new []{"ERROR"},
                new []{"L"},
                new []{"ERROR"},
                new []{"N","N","N","N","N","N","N","N","N","M","M","M","M"},
                new []{"ERROR"},
                new []{"M","M","M","M"},
                new []{"L","M","M","M","M"}
            };

            for (int i = 0; i < commandStart.Length; i++)
            {
                try
                {
                    var command = new Command(commandStart[i]);

                    for (int j = 0; j < command.Commands.Length; j++)
                    {
                        Assert.AreEqual(commandFinish[i][j], command.Commands[j]);
                    }
                    
                }
                catch (Exception_Command exceptionCommand)
                {
                    Assert.AreEqual("Ваша команда не корректна", exceptionCommand.Message);
                }
            }
        }
    }
}
