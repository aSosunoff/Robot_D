namespace Robot_D.Center_Layer
{
    public class Dron
    {
        #region поле
        private Move _move;
        #endregion
        #region свойство
        public int X
        {
            get { return _move.X; }
        }

        public int Y
        {
            get { return _move.Y; }
        }

        public string Direction
        {
            get { return _move.Direction; }
        }

        #endregion
        #region конструктор

        public Dron(string setPosition)
        {
            _move = new Move(setPosition);
        }

        public Dron(int x, int y, string d)
        {
            _move = new Move(x, y, d);
        }
        #endregion

        public void Move(string command, Area area)
        {
            _move.Run(command, area); 
        }
    }
}