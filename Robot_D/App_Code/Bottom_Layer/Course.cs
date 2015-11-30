using System.Text.RegularExpressions;
using Robot_D.Exception;
using Robot_D.Exception.Exception_Bottom_Layer;

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
                return _direction;
            }
            set
            {
                Regex regex = new Regex("^[NnEeSsWw]$");
                if (regex.IsMatch(value))
                    _direction = value.ToUpper();
                else
                    throw new Exception_Course("Дрон может иметь только одно направление из (N, E, S, W)");
            }
        }
        public void Turn(string Side)
        {
            Regex regex = new Regex(@"(^[^\S]*[LlRr][^\S]*$)");
            if (regex.IsMatch(Side))
            {
                Side = Side.ToUpper().Trim();
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
            else
                throw new Exception_Course("Поворот задан не правильно. Попробуйте ещё раз");
            
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