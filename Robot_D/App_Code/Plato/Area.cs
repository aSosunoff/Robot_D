using Robot_D.Spare_Paths;

namespace Robot_D.Plato
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

        public Area(Point point)
        {
            _point = new Point()
            {
                X = point.X,
                Y = point.Y
            };
        }
        #endregion 
    }
}