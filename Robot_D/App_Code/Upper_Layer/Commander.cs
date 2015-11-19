using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using Dron_Exception;
using Robot_D.Center_Layer;

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

        public string SendCommand(string sendCommand)
        {
            string s = "";
            sendCommand = sendCommand.Trim();
            Regex a = new Regex(@"[^\r\n]+");
            var arrCommandList = a.Matches(sendCommand)
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();
            if (((arrCommandList.Length - 1) % 2) == 0)
            {
                _area = new Area(arrCommandList[0]);

                int j = 1;
                int i = 0;
                _dron = new List<Dron>();
                while (i < ((arrCommandList.Length - 1) / 2))
                {
                    Dron dron = new Dron(arrCommandList[j]);
                    j++;
                    dron.Move(arrCommandList[j], _area);
                    _dron.Add(dron);
                    j++;
                    i++;
                    s += String.Format("{0} {1} {2}\r\n", dron.X, dron.Y, dron.Direction);
                }
                //var s = _dron.Select(d => new);
                return s;
            }
            else
            {
                throw new ExceptionUser("Не достаточно данных для отправки");
            }

        }
        #endregion

        #region конструктор
        #endregion
    }
}

  