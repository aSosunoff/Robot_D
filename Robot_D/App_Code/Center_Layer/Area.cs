using System;
using Robot_D.Bottom_Layer;
using Robot_D.Exception;
using Robot_D.Exception.Exception_Bottom_Layer;
using Robot_D.Exception.Exception_Center_Layer;

namespace Robot_D.Center_Layer
{
    public class Area
    {
        #region поле
        private Point _point;
        #endregion
        #region свойство
        public int Max_X
        {
            get
            {
                return _point.X;
            }
        }
        public int Max_Y
        {
            get
            {
                return _point.Y;
            }
        }
        #endregion
        #region конструктор

        public Area(string s)
        {
            try
            {
                _point = new Point(s);
            }
            catch (Exception_Point exceptionPoint)
            {
                throw new Exception_Area(String.Format("Координаты поля не корректны\r\n{0}", exceptionPoint.Message));
            }    
        }

        public Area(int x, int y)
        {
            try
            {
                _point = new Point(x, y);
            }
            catch (Exception_Point exceptionPoint)
            {
                throw new Exception_Area(String.Format("Координаты поля не корректны\r\n{0}", exceptionPoint.Message));
            }     
        }
        #endregion 
    }
}