using System.Text.RegularExpressions;
using Robot_D.Exception;

namespace Robot_D.Bottom_Layer
{
    public class Course
    {

        #region поле
        private string _direction;
        #endregion
        #region свойство
        public string Direction
        {
            get
            {
                if (_direction != null)
                    return _direction;
                else 
                    throw new ExceptionUser("Направление Дрона заданно не правильно");
            }
            set
            {
                Regex regex = new Regex("^[NnEeSsWw]$");
                if (regex.IsMatch(value))
                    _direction = value;
                else
                    throw new ExceptionUser("Дрон может иметь только одно направление из (N, E, S, W)");
            }
        }
        public void Turn(string Side)
        {
            Side = Side.ToUpper();
            switch (Side)
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
        #endregion
        #region метод

        #endregion
        #region конструктор
        public Course(string direction)
        {
            Direction = direction;
        }
        #endregion
        
        
    }
}