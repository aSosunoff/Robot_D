using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot_D.Robot;
using Robot_D.RobotDException.DronException;

namespace TestPoint.DronTest
{
    [TestClass]
    public class CommandTest
    {
        [TestMethod]
        public void CommandsTest()
        {
            var inputStringCommands = new[]
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

            var outputStringCommands = new[]
            {
                new []{"ERROR"},
                new []{"L","M","M","R","R","R","L","M","M"},
                new []{"L","M","M","R","R","R","L","R","R","R","R","L","L","L"},
                new []{"ERROR"},
                new []{"L"},
                new []{"ERROR"},
                new []{"N","N","N","N","N","N","N","N","N","M","M","M","M"},
                new []{"ERROR"},
                new []{"M","M","M","M"},
                new []{"L","M","M","M","M"}
            };

            for (int i = 0; i < inputStringCommands.Length; i++)
            {
                try
                {
                    var command = new Command(inputStringCommands[i]);

                    for (int j = 0; j < command.CommandsList.Length; j++)
                    {
                        Assert.AreEqual(outputStringCommands[i][j], command.CommandsList[j]);
                    }
                    
                }
                catch (CommandException exceptionCommand)
                {
                    Assert.AreEqual("Ваша команда не корректна", exceptionCommand.Message);
                }
            }
        }
    }
}
