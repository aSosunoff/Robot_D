using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Robot_D.Exception_App;
using Robot_D.Exception_App.Exception_Dispatcher;

namespace Robot_D.Dispatcher
{
    public class DevideCommand
    {
        #region поле
        private string[] _arrCommand;
        #endregion
        #region свойство
        public string[] ArrCommand
        {
            get { return _arrCommand; }
            set
            {
                var command = value[0];
                command = command.Trim();
                Regex a = new Regex(@"[^\r\n]+");
                _arrCommand = a.Matches(command)
                    .Cast<Match>()
                    .Select(m => m.Value)
                    .ToArray();
                if (((_arrCommand.Length - 1) % 2) != 0)
                {
                    throw new Exception_Devide_Command("Не достаточно данных для отправки");
                }
            }
        }
        #endregion
        public DevideCommand(string command)
        {
            ArrCommand = new[]{command};
        }
    }
}
