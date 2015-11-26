using System;
using System.Text.RegularExpressions;
using Robot_D.Exception;

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
                //if (_x >= 0)
                    return _x;
                //else
                //    throw new ExceptionPointX("Координата X не задана либо она не может быть менше нуля");
            }
            set
            {
                if (value >= 0)
                    _x = value;
                else
                    throw new ExceptionPointX("Координата X не может быть меньше нуля");
            }
        }

        public int Y
        {
            get
            {
                //if (_y >= 0)
                    return _y;
                //else
                //    throw new ExceptionPointY("Координата Y не задана либо она не может быть менше нуля");
            }
            set
            {
                if (value >= 0)
                {
                    _y = value;
                }
                else
                    throw new ExceptionPointY("Координата Y не может быть меньше нуля");
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
                throw new ExceptionPointSetCoordinateString("Некоректные координаты объекта");
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