using System;
using System.Text.RegularExpressions;
using Robot_D.RobotDException.SparePartsException;

namespace Robot_D.SpareParts
{
    public class Point
    {
        #region поле
        private int _X;
        private int _Y;
        #endregion
        #region свойство
        public int X
        {
            get
            {
                return _X;
            }
            set
            {
                if ((value >= 0) && (value <= 2147483647))
                    _X = value;
                else
                    throw new PointException("Задать X координату можно от 0 до 2147483647");
            }
        }

        public int Y
        {
            get
            {
                return _Y;
            }
            set
            {
                if ((value >= 0) && (value <= 2147483647))
                {
                    _Y = value;
                }
                else
                    throw new PointException("Задать Y координату можно от 0 до 2147483647");
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
        public Point(string xY)
        {
            Regex regex = new Regex(@"^\s*\d+\s+\d+\s*$");
            if (regex.IsMatch(xY))
            {
                regex = new Regex(@"([1-9]+\d*)|(^\s*0\s)|(\s*0\s*$)");
                MatchCollection matches = regex.Matches(xY);
                X = Convert.ToInt32(matches[0].Value.Trim());
                Y = Convert.ToInt32(matches[1].Value.Trim());
            }
            else
                throw new PointException("Строка должна содержать 2 числа через [Пробел]");
        }
        #endregion
        
    }
}