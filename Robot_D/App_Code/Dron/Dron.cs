using System;
using System.Text.RegularExpressions;
using Robot_D.Exception.Exception_Center_Layer;
using Robot_D.Plato;
using Robot_D.Spare_Paths;

namespace Robot_D.Dron
{
    public class Dron
    {
        #region поле
        private Move _move;
        #endregion
        #region свойство
        public int X
        {
            get { return _move.X; }
        }

        public int Y
        {
            get { return _move.Y; }
        }

        public string Direction
        {
            get { return _move.Direction; }
        }

        #endregion
        #region конструктор

        public Dron(Point point, Course course)
        {
            _move = new Move(new Point()
            {
                X = point.X,
                Y = point.Y
            }, new Course()
            {
                Direction = course.Direction
            });
        }
        #endregion

        public void Move(string command, Area area)
        {
            _move.Run(command, area);
        }
    }
}