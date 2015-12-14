using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Robot_D.Plato;
using Robot_D.Robot;
using Robot_D.RobotDException.DispatcherException;
using Robot_D.SpareParts;

namespace Robot_D.Dispatcher
{
    /// <summary>
    /// Класс в который приходит сырой текст с командами от пользователя
    /// </summary>
    public class ControlCommand
    {
        #region свойство
        /// <summary>
        /// Свойство получения конечного расположения роботов на поле
        /// </summary>
        //public string GetFinalPositionRobot { get; private set; }
        public Dictionary<string, string> GetFinalPositionRobot { get; private set; }
        #endregion

        #region конструктор
        /// <summary>
        /// Распредиление команд по объектам
        /// </summary>
        /// <param name="devideCommand">Класс для дробления сырого текста команд на массив для дальнейшего распределения по объектам</param>
        public ControlCommand(DevideCommand devideCommand)
        {
            GetFinalPositionRobot = new Dictionary<string, string>();

            Area area = new Area(new Point(devideCommand.GetArrayListCommand[0]));

            List<RobotBody> dronsList = new List<RobotBody>();

            int j = 1;
            int i = 0;

            while (i < ((devideCommand.GetArrayListCommand.Length - 1) / 2))
            {
                Regex regex = new Regex(@"^\s*\d+\s+\d+\s+[NnEeSsWw]$");
                if (regex.IsMatch(devideCommand.GetArrayListCommand[j]))
                {
                    regex = new Regex(@"(\d+\s+\d+)|([NnEeSsWw])");
                    MatchCollection matches = regex.Matches(devideCommand.GetArrayListCommand[j]);
                    RobotBody dron = new RobotBody(
                        new Point(matches[0].Value),
                        new Course(matches[1].ToString())
                        );

                    j++;
                    dron.Run(new Command(devideCommand.GetArrayListCommand[j]), area);
                    dronsList.Add(dron);
                    j++;
                    i++;
                    GetFinalPositionRobot.Add("Робот № " + i, String.Format("{0} {1} {2}\r\n", dron.Point.X, dron.Point.Y, dron.Course.Direction));  
                }
                else
                {
                    CommandControlException ex = new CommandControlException("Строка не корректна.");
                    ex.Data.Add("Возможная ошибка в строке", devideCommand.GetArrayListCommand[j]);
                    throw ex;
                }
            }
        }
        #endregion
    }
}

  