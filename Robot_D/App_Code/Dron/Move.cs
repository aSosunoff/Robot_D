using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Robot_D.Spare_Paths;
using Robot_D.Exception;
using Robot_D.Exception.Exception_Bottom_Layer;
using Robot_D.Exception.Exception_Center_Layer;
using Robot_D.Plato;

namespace Robot_D.Dron
{
    public class Move
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
        public Move(Point point, Course course)
        {
            _point = new Point()
            {
                X = point.X,
                Y = point.Y
            };
            _course = new Course()
            {
                Direction = course.Direction
            };
        }

        #endregion
        public void Turn(string Side)
        {
            _course.Turn(Side);
        }

        public void Run(string command, Area area)
        {
            Regex regex = new Regex(@"(^\s*[LlRrMm]+(\s*[LlRrMm]*)*$)");
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
                                    throw new Exception_Move("Дрон выходит из зданного поля");
                                break;
                            case "E":
                                if (X < area.Max_X)
                                    X++;
                                else
                                    throw new Exception_Move("Дрон выходит из зданного поля");
                                break;
                            case "S":
                                if (Y > 0)
                                    Y--;
                                else
                                    throw new Exception_Move("Дрон выходит из зданного поля");
                                break;
                            case "W":
                                if (X > 0)
                                    X--;
                                else
                                    throw new Exception_Move("Дрон выходит из зданного поля");
                                break;
                        }
                }
            }
            else
                throw new Exception_Move("Ваша команда не корректна");
        }
        
        #region метод

        #endregion
    }
}
