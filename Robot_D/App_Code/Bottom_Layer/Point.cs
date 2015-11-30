using System;
using System.Text.RegularExpressions;
using Robot_D.Exception;
using Robot_D.Exception.Exception_Bottom_Layer;

namespace Robot_D.Bottom_Layer
{
    public class Point
    {
        #region поле
        private int _x;
        private int _y;
        #endregion
        #region свойство
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value >= 0)
                    _x = value;
                else
                    throw new Exception_Point("Задать X координату можно от 0 до 2147483647");
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                if (value >= 0)
                {
                    _y = value;
                }
                else
                    throw new Exception_Point("Задать Y координату можно от 0 до 2147483647");
            }
        }
            
        #endregion
        #region метод

        public void SetCoordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void SetCoordinate(string X_Y)
        {
            Regex regex = new Regex(@"^[^\S]*[0-9]+[^\S]+[0-9]+[^\S]*$");
            if (regex.IsMatch(X_Y))
            {
                regex = new Regex(@"([1-9]+(0*[1-9]*)*)|^0$");
                MatchCollection matches = regex.Matches(X_Y);
                X = Convert.ToInt32(matches[0].Value);
                Y = Convert.ToInt32(matches[1].Value);
            }
            else
                throw new Exception_Point("Строка должна содержать 2 числа через [Пробел]");
        }

        #endregion
        #region конструктор

        public Point(int x, int y)
        {
            SetCoordinate(x, y);
        }
        public Point(string X_Y)
        {
            SetCoordinate(X_Y);
        }
        #endregion
        
    }
}