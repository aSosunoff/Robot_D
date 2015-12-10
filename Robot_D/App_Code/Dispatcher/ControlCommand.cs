using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Robot_D.App_Code.Dispatcher;
using Robot_D.Dron;
using Robot_D.Exception_App;
using Robot_D.Exception_App.Exception_Dispatcher;
using Robot_D.Plato;
using Robot_D.Spare_Paths;

namespace Robot_D.Dispatcher
{
    public class ControlCommand
    {
        #region поле

        #endregion

        #region свойство
        public string DronFinish { get; private set; }

        #endregion

        #region метод



        public ControlCommand(string sendCommand)
        {
            DronFinish = "";
            DevideCommand dCommand = new DevideCommand(sendCommand);

            Area area = new Area(new Point(dCommand.ArrCommand[0]));

            List<Dron.Dron> dronList = new List<Dron.Dron>();

            int j = 1;
            int i = 0;

            while (i < ((dCommand.ArrCommand.Length - 1) / 2))
            {
                Regex regex = new Regex(@"(\d+\s+\d+)|([NnEeSsWw])");
                MatchCollection matches = regex.Matches(dCommand.ArrCommand[j]);
                Dron.Dron dron = new Dron.Dron(
                    new Point(matches[0].Value),
                    new Course(matches[1].ToString())
                    );

                j++;
                dron.Run(new Command(dCommand.ArrCommand[j]), area);
                dronList.Add(dron);
                j++;
                i++;
                DronFinish += String.Format("{0} {1} {2}\r\n", dron.Point.X, dron.Point.Y, dron.Course.Direction);
            }
        }
        #endregion

        #region конструктор
        #endregion
    }
}

  