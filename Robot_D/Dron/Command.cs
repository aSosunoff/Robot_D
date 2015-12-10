using System.Linq;
using System.Text.RegularExpressions;
using Robot_D.Exception_App.Exception_Spare_Parts;

namespace Robot_D.Dron
{
    public class Command
    {
        #region поле
        private string[] _command;
        #endregion
        #region свойство

        public string[] Commands {
            get { return _command; }
            set
            {
                string command = value[0];
                Regex regex = new Regex(@"(^\s*[LlRrMm]+(\s*[LlRrMm]*)*$)");
                if (regex.IsMatch(command))
                {
                    regex = new Regex("[^LlRrMm]");
                    command = regex.Replace(command, "").ToUpper();

                    regex = new Regex(@"[LlRrMm]");

                    _command = regex.Matches(command)
                        .Cast<Match>()
                        .Select(v => v.Value)
                        .ToArray();
                }
                else
                    throw new Exception_Command("Ваша команда не корректна");
            } 
        }
        #endregion
        public Command(string command)
        {
            Commands = new string[]{command};
        }
    }
}
