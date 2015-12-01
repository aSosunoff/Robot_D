using Robot_D.Exception.Exception_Center_Layer;

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
            try
            {
                _move = new Move(setPosition);
            }
            catch (Exception_Move exceptionMove)
            {
                throw new Exception_Dron(exceptionMove.Message);
            }
        }

        public Dron(int x, int y, string d)
        {
            try
            {
                _move = new Move(x, y, d);
            }
            catch (Exception_Move exceptionMove)
            {
                throw new Exception_Dron(exceptionMove.Message);
            }
        }
        #endregion

        public void Move(string command, Area area)
        {
            try
            {
                _move.Run(command, area);
            }
            catch (Exception_Move exceptionMove)
            {
                throw new Exception_Dron(exceptionMove.Message);
            }
            
        }
    }
}