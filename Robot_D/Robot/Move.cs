using Robot_D.Plato;
using Robot_D.RobotDException.DronException;
using Robot_D.SpareParts;

namespace Robot_D.Robot
{
    /// <summary>
    /// Класс движения
    /// </summary>
    public class Move
    {
        #region конструктор
        public Move(Point point, Course course, Command command, Area area)
        {
            foreach (var i in command.CommandsList)
            {
                if (i != "M")
                    course.Turn(i);
                else
                    switch (course.Direction)
                    {
                        case "N":
                            if (point.Y < area.Point.Y)
                                point.Y++;
                            else
                                throw new MoveException("Дрон выходит из зданного поля");
                            break;
                        case "E":
                            if (point.X < area.Point.X)
                                point.X++;
                            else
                                throw new MoveException("Дрон выходит из зданного поля");
                            break;
                        case "S":
                            if (point.Y > 0)
                                point.Y--;
                            else
                                throw new MoveException("Дрон выходит из зданного поля");
                            break;
                        case "W":
                            if (point.X > 0)
                                point.X--;
                            else
                                throw new MoveException("Дрон выходит из зданного поля");
                            break;
                    }
            }

        }
        #endregion  
    }
}
