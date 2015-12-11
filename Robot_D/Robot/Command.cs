using System.Linq;
using System.Text.RegularExpressions;
using Robot_D.RobotDException.DronException;

namespace Robot_D.Robot
{
    /// <summary>
    /// Класс проверки правильности ввода команды для робота
    /// </summary>
    public class Command
    {
        #region поле
        private string[] _CommandsList;
        #endregion
        #region свойство
        /// <summary>
        /// Проверка и добавление в массив команды движения по полю для робота
        /// </summary>
        public string[] CommandsList
        {
            get { return _CommandsList; }
            set
            {
                string commandLine = value[0];
                Regex regex = new Regex(@"(^\s*[LlRrMm]+(\s*[LlRrMm]*)*$)");
                if (regex.IsMatch(commandLine))
                {
                    regex = new Regex("[^LlRrMm]");
                    commandLine = regex.Replace(commandLine, "").ToUpper();

                    regex = new Regex(@"[LlRrMm]");

                    _CommandsList = regex.Matches(commandLine)
                        .Cast<Match>()
                        .Select(v => v.Value)
                        .ToArray();
                }
                else
                    throw new CommandException("Ваша команда не корректна");
            } 
        }
        #endregion
        public Command(string command)
        {
            CommandsList = new string[] { command };
        }
    }
}
