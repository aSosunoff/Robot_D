using System.Text.RegularExpressions;
using Robot_D.RobotDException.DronException;

namespace Robot_D.Robot
{
    /// <summary>
    /// Класс направления
    /// </summary>
    public class Course
    {
        #region поле
        private string _Direction;
        #endregion
        #region свойство
        /// <summary>
        /// Свойство поворота головы
        /// </summary>
        public string Direction
        {
            get{ return _Direction; }
            set
            {
                Regex regex = new Regex("^[NnEeSsWw]$");
                if (regex.IsMatch(value))
                    _Direction = value.ToUpper();
                else
                    throw new CourseException("Направление может быть одно из (N, E, S, W)");
            }
        }
        #endregion
        #region метод
        /// <summary>
        /// Метод поворота по заданному направлению
        /// </summary>
        /// <param name="side">Сторона поворота</param>
        public void Turn(string side)
        {
            Regex regex = new Regex(@"(^\s*[LlRr]\s*$)");
            if (regex.IsMatch(side))
            {
                side = side.ToUpper().Trim();
                switch (side)
                {
                    case "L":
                        switch (Direction)
                        {
                            case "N":
                                Direction = "W";
                                break;
                            case "W":
                                Direction = "S";
                                break;
                            case "S":
                                Direction = "E";
                                break;
                            case "E":
                                Direction = "N";
                                break;
                        }
                        break;
                    case "R":
                        switch (Direction)
                        {
                            case "N":
                                Direction = "E";
                                break;
                            case "E":
                                Direction = "S";
                                break;
                            case "S":
                                Direction = "W";
                                break;
                            case "W":
                                Direction = "N";
                                break;
                        }
                        break;
                }
            }
            else
                throw new CourseException("Поворот задан не правильно. Попробуйте ещё раз");
        }
        #endregion
        #region конструктор
        public Course(string direction)
        {
            Direction = direction;
        }
        #endregion
        
        
    }
}