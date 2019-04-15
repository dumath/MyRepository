using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gower
{
    //Абстракция персонажа
    abstract class Character : IMove
    {
        protected int _yCoord;
        protected int _xCoord;

        public abstract void MoveDown(Ground[,] terrain);
        public abstract void MoveLeft(Ground[,] terrain);
        public abstract void MoveRigth(Ground[,] terrain);
        public abstract void MoveUp(Ground[,] terrain);
    }
}
