using Robot_D.Plato;
using Robot_D.SpareParts;

namespace Robot_D.Robot
{
    /// <summary>
    /// Класс робота
    /// </summary>
    public class RobotBody
    {
        #region поле
        public Point Point;
        public Course Course;
        public Move Move;
        #endregion

        #region конструктор
        public RobotBody(Point point, Course course)
        {
            Point = point;
            Course = course;
        }
        #endregion
        /// <summary>
        /// Движение робота
        /// </summary>
        /// <param name="command"></param>
        /// <param name="area"></param>
        public void Run(Command command, Area area)
        {
            new Move(Point, Course, command, area);
        }
    }
}