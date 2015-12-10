using System;
using System.Text.RegularExpressions;
using Robot_D.Plato;
using Robot_D.Spare_Parts;

namespace Robot_D.Dron
{
    public class Dron
    {
        #region поле

        public Point Point;
        public Course Course;
        public Move Move;
        #endregion
        #region свойство

        #endregion
        #region конструктор

        public Dron(Point point, Course course)
        {
            Point = point;
            Course = course;
        }
        #endregion

        public void Run(Command command, Area area)
        {
            new Move(Point, Course, command, area);
        }
    }
}