using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gower
{
    interface IMove
    {
        void MoveUp(Ground[,] terrain);
        void MoveDown(Ground[,] terrain);
        void MoveLeft(Ground[,] terrain);
        void MoveRigth(Ground[,] terrain);
    }
}
