using System;
using System.Text.RegularExpressions;
using Robot_D.Exception_App.Exception_Spare_Parts;

namespace Robot_D.Spare_Parts
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
                if ((value >= 0) && (value <= 2147483647))
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
                if ((value >= 0) && (value <= 2147483647))
                {
                    _y = value;
                }
                else
                    throw new Exception_Point("Задать Y координату можно от 0 до 2147483647");
            }
        }
            
        #endregion
        #region метод

        #endregion
        #region конструктор
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point(string X_Y)
        {
            Regex regex = new Regex(@"^\s*\d+\s+\d+\s*$");
            if (regex.IsMatch(X_Y))
            {
                regex = new Regex(@"([1-9]+\d*)|(^\s*0\s)|(\s*0\s*$)");
                MatchCollection matches = regex.Matches(X_Y);
                X = Convert.ToInt32(matches[0].Value.Trim());
                Y = Convert.ToInt32(matches[1].Value.Trim());
            }
            else
                throw new Exception_Point("Строка должна содержать 2 числа через [Пробел]");
        }
        #endregion
        
    }
}