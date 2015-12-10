using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Robot_D.Exception_App;
using Robot_D.Exception_App.Exception_Spare_Parts;
using Robot_D.Plato;
using Robot_D.Spare_Parts;

namespace Robot_D.Dron
{
    public class Move
    {
        #region поле
        #endregion
        #region свойство
        #endregion
        #region конструктор
        public Move(Point point, Course course, Command command, Area area)
        {
            foreach (var i in command.Commands)
            {
                if (i != "M")
                    course.Turn(i);
                else
                    switch (course.Direction)
                    {
                        case "N":
                            if (point.Y < area._point.Y)
                                point.Y++;
                            else
                                throw new Exception_Move("Дрон выходит из зданного поля");
                            break;
                        case "E":
                            if (point.X < area._point.X)
                                point.X++;
                            else
                                throw new Exception_Move("Дрон выходит из зданного поля");
                            break;
                        case "S":
                            if (point.Y > 0)
                                point.Y--;
                            else
                                throw new Exception_Move("Дрон выходит из зданного поля");
                            break;
                        case "W":
                            if (point.X > 0)
                                point.X--;
                            else
                                throw new Exception_Move("Дрон выходит из зданного поля");
                            break;
                    }
            }

        }

        #endregion  
        #region метод

        #endregion
    }
}
