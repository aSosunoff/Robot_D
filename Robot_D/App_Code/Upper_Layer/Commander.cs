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
        //Поле на котором гуляют дроны
        #endregion

        #region свойство

        #endregion

        #region метод

        public string SendCommand(string sendCommand)
        {
                string s = "";
                if (sendCommand.Trim() != "")
                {
                    Regex regex = new Regex(@".+[^\r\n]");
                    MatchCollection matches = regex.Matches(sendCommand);
                    if (matches.Count >= 3)
                    {
                        List<string> arrCommandList = new List<string>();
                        foreach (var i in matches)
                        {
                            if (i.ToString().Trim() != "")
                                arrCommandList.Add(i.ToString());
                        }

                        if (((arrCommandList.Count() - 1) % 2) == 0)
                        {
                            _area = new Area(arrCommandList[0]);

                            int j = 1;
                            int i = 0;
                            _dron = new List<Dron>();
                            while (i < ((arrCommandList.Count - 1) / 2))
                            {
                                Dron dron = new Dron(arrCommandList[j]);
                                j++;
                                dron.Move(arrCommandList[j], _area);
                                _dron.Add(dron);
                                j++;
                                i++;
                                s += String.Format("{0} {1} {2}\r\n", dron.X, dron.Y, dron.Direction);
                                //if ((dron.X <= _area.Max_X) && (dron.Y <= _area.Max_Y))
                                //{
                                //    j++;
                                //    dron.Move(arrCommandList[j], _area);
                                //    _dron.Add(dron);
                                //    j++;
                                //    i++;
                                //    s += String.Format("{0} {1} {2}\r\n", dron.X, dron.Y, dron.Direction);
                                //}
                                //else
                                //    throw new ExceptionUser("Позиция Дрона выходит за поле");

                            }
                        }
                        else
                        {
                            throw new ExceptionUser("Не достаточно данных для отправки");
                        }
                    }
                    else
                    {
                        throw new ExceptionUser("Не достаточно данных для отправки");
                    }
                }
                else
                {
                    throw new ExceptionUser("Срока пуста");
                }
                return s;
            
        }
        #endregion

        #region конструктор
        #endregion
    }
}

  