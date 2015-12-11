using System.Linq;
using System.Text.RegularExpressions;
using Robot_D.RobotDException.DispatcherException;

namespace Robot_D.Dispatcher
{
    /// <summary>
    /// Класс дробления сырого текста комманд
    /// </summary>
    public class DevideCommand
    {
        #region поле
        private string[] _CommandsList;
        #endregion
        #region свойство
        /// <summary>
        /// Свойство дробления и добавления в массив комманд для дальнейшего использования и распредиления по объектам
        /// </summary>
        public string[] GetArrayListCommand
        {
            get { return _CommandsList; }
            set
            {
                var lineCommand = value[0];
                lineCommand = lineCommand.Trim();
                Regex lineCommandRegex = new Regex(@"[^\r\n]+");
                _CommandsList = lineCommandRegex.Matches(lineCommand)
                    .Cast<Match>()
                    .Select(e => e.Value)
                    .ToArray();
                if (((_CommandsList.Length - 1) % 2) != 0)
                {
                    throw new DevideCommandException("Не достаточно данных для отправки");
                }
            }
        }
        #endregion
        public DevideCommand(string command)
        {
            GetArrayListCommand = new[]{command};
        }
    }
}
