using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Robot_D.Dron;
using Robot_D.Exception;
using Robot_D.Exception.Exception_Center_Layer;
using Robot_D.Plato;
using Robot_D.Spare_Paths;

namespace Upper_Layer
{
    public class Commander
    {
        #region поле
        private List<Dron> _dron; 
        private Area _area;
        #endregion

        #region свойство

        #endregion

        #region метод

        private string[] DevideCommand(string command)
        {
            command = command.Trim();
            Regex a = new Regex(@"[^\r\n]+");
            var arrCommandList = a.Matches(command)
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();
            if (((arrCommandList.Length - 1) % 2) == 0)
            {
                return arrCommandList;
            }
            else
            {
                throw new ExceptionUser("Не достаточно данных для отправки");
            }
        }

        public string SendCommand(string sendCommand)
        {
            string s = "";
            var arrCommandList = DevideCommand(sendCommand);
            
            _area = new Area(new Point(arrCommandList[0]));

            _dron = new List<Dron>();

            int j = 1;
            int i = 0;
            
            while (i < ((arrCommandList.Length - 1) / 2))
            {
                Regex regex = new Regex(@"(\d+\s+\d+)|([NnEeSsWw])");
                MatchCollection matches = regex.Matches(arrCommandList[j]);
                Dron dron = new Dron(
                    new Point(matches[0].Value),
                    new Course(matches[1].ToString())
                    );

                j++;
                dron.Move(arrCommandList[j], _area);
                _dron.Add(dron);
                j++;
                i++;
                s += String.Format("{0} {1} {2}\r\n", dron.X, dron.Y, dron.Direction);
            }
            return s;
        }
        #endregion

        #region конструктор
        #endregion
    }
}

  