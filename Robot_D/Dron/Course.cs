using System.Text.RegularExpressions;
using Robot_D.Exception_App;
using Robot_D.Exception_App.Exception_Spare_Parts;
using Robot_D.Exception_App.Exception_Spare_Parts;

namespace Robot_D.Dron
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
                    throw new Exception_Course("Направление может быть одно из (N, E, S, W)");
            }
        }
        public void Turn(string Side)
        {
            Regex regex = new Regex(@"(^\s*[LlRr]\s*$)");
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