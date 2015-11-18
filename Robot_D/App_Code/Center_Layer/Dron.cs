namespace Robot_D.Center_Layer
{
    public class Dron
    {
        #region поле
        //private Point _point;
        //private Course _course;
        private Move _move;
        #endregion
        #region свойство
        public int X
        {
            get { return _move.X; }
            //set { _point.X = value; }
        }

        public int Y
        {
            get { return _move.Y; }
            //set { _point.Y = value; }
        }

        public string Direction
        {
            get { return _move.Direction; }
            //set { _course.Direction = value; }
        }

        #endregion
        #region конструктор

        public Dron(string setPosition)
        {
            //SetPosition(setPosition);
            _move = new Move(setPosition);
        }

        public Dron(int x, int y, string d)
        {
            _move = new Move(x, y, d);
            //_point = new Point(x, y);
            //_course = new Course(d);
        }
        #endregion

        //public void SetPosition(string setPosition)
        //{
        //    Regex regex = new Regex(@"^[^\S]*\d+[^\S]+\d+[^\S]+[NnEeSsWw]{1,1}[^\S]*$");
        //    if (regex.IsMatch(setPosition))
        //    {
        //        //_point = new Point();

        //        regex = new Regex(@"(\d+(0*\d*)*)|([NnEeSsWw]{1,1})");
        //        MatchCollection matches = regex.Matches(setPosition);
        //        _move.X = Convert.ToInt32(matches[0].Value);
        //        _move.Y = Convert.ToInt32(matches[1].Value);
        //        _move.Direction = matches[2].ToString();
        //    }        
        //}

        public void Move(string command, Area area)
        {
            _move.Run(command, area); 
        }
    }
}