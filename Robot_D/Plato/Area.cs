using Robot_D.SpareParts;

namespace Robot_D.Plato
{
    /// <summary>
    /// Класс поля для роботов
    /// </summary>
    public class Area
    {
        #region поле
        public Point Point;
        #endregion
        #region конструктор
        public Area(Point point)
        {
            Point = point;
        }
        #endregion 
    }
}