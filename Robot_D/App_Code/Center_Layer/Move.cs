using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Robot_D.Bottom_Layer;
using Robot_D.Center_Layer;
using Robot_D.Exception;

namespace Robot_D.Center_Layer
{
    class Move
    {
        #region поле
        private Point _point;
        private Course _course;
        #endregion
        #region свойство
        public int X
        {
            get { return _point.X; }
            set { _point.X = value; }
        }

        public int Y
        {
            get { return _point.Y; }
            set { _point.Y = value; }
        }

        public string Direction
        {
            get { return _course.Direction; }
            set { _course.Direction = value; }
        }
        #endregion
        #region конструктор
        public Move(int x, int y, string direction)
        {
            _point = new Point(x, y);
            _course = new Course(direction);
        }
        public Move(string setPosition)
        {
            Regex regex = new Regex(@"^[^\S]*\d+[^\S]+\d+[^\S]+[NnEeSsWw]{1,1}[^\S]*$");
            if (regex.IsMatch(setPosition))
            {
                regex = new Regex(@"(\d+(0*\d*)*)|([NnEeSsWw]{1,1})");
                MatchCollection matches = regex.Matches(setPosition);
                _point = new Point(Convert.ToInt32(matches[0].Value), Convert.ToInt32(matches[1].Value));
                _course = new Course(matches[2].ToString());
            }
        }

        public void Turn(string Side)
        {
            _course.Turn(Side);
        }

        public void Run(string command, Area area)
        {
            Regex regex = new Regex(@"(^[^\S]*[LlRrMm]+([^\S]*[LlRrMm]*)*$)");
            if (regex.IsMatch(command))
            {
                regex = new Regex("[^LlRrMm]");
                command = regex.Replace(command, "");

                regex = new Regex(@"[LlRrMm]");
                MatchCollection matches = regex.Matches(command);
                foreach (var i in matches)
                {
                    if ((i.ToString() != "M") && (i.ToString() != "m"))
                        _course.Turn(i.ToString());
                    else
                        switch (Direction)
                        {
                            case "N":
                                if (Y < area.Max_Y)
                                    Y++;
                                else
                                    throw new ExceptionUser("Дрон выходит из зданного поля");
                                break;
                            case "E":
                                if (X < area.Max_X)
                                    X++;
                                else
                                    throw new ExceptionUser("Дрон выходит из зданного поля");
                                break;
                            case "S":
                                if (Y > 0)
                                    Y--;
                                else
                                    throw new ExceptionUser("Дрон выходит из зданного поля");
                                break;
                            case "W":
                                if (X > 0)
                                    X--;
                                else
                                    throw new ExceptionUser("Дрон выходит из зданного поля");
                                break;
                        }
                }
            }
        }
        #endregion
        #region метод

        #endregion
    }
}
