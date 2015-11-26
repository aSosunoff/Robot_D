using Robot_D.Bottom_Layer;
using Robot_D.Exception;

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
                try
                {
                    return _point.X;
                }
                catch (ExceptionUser)
                {
                    throw new ExceptionUser("Координата X у поля не корректна");
                }  
                
            }
            set { _point.X = value; }
        }
        public int Max_Y
        {
            get
            {
                try
                {
                    return _point.Y;
                }
                catch (ExceptionUser)
                {
                    throw new ExceptionUser("Координата Y у поля не корректна");
                }  
            }
            set { _point.Y = value; }
        }

        public string SetArea
        {      
            set
            {
                try
                {
                    _point.SetCoordinate(value);
                }
                catch (ExceptionUser)
                {
                    throw new ExceptionUser("Координаты поля не корректны");
                }
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
            catch (ExceptionUser)
            {
                throw new ExceptionUser("Координаты поля не корректны");
            }    
        }

        public Area(int x, int y)
        {
            try
            {
                _point = new Point(x, y);
            }
            catch (ExceptionUser)
            {
                throw new ExceptionUser("Координаты поля не корректны");
            }     
        }

        public Area(Area area)
        {
            try
            {
                _point = new Point(area.Max_X, area.Max_Y);
            }
            catch (ExceptionUser)
            {
                throw new ExceptionUser("Координаты поля не корректны");
            }     
        }
        #endregion 
    }
}