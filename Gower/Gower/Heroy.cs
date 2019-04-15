using System;

namespace Gower
{
    class Heroy : Character
    {
        //Пассивный конструктор отсутствует.Компилятор сам создает пассивный коонструктор
        public Heroy(int y, int  x)
        {
            this._yCoord = y;
            this._xCoord = x;
        }

        //Сдвиг вниз
        public override void MoveDown(Ground[,] terrain)
        {
            if (this._yCoord == 4)
            {
                return;
            }

            terrain[this._yCoord, this._xCoord] = Ground.G;
            this._yCoord++;
            terrain[this._yCoord, this._xCoord] = Ground.H;
        }

        //Сдвиг влево
        public override void MoveLeft(Ground[,] terrain)
        {
            if (this._xCoord == 0)
            {
                return;
            }

            terrain[this._yCoord, this._xCoord] = Ground.G;
            this._xCoord--;
            terrain[this._yCoord, this._xCoord] = Ground.H;
        }

        //Сдвиг вправо
        public override void MoveRigth(Ground[,] terrain)
        {
            if (this._xCoord == 9)
            {
                return;
            }

            terrain[this._yCoord, this._xCoord] = Ground.G;
            this._xCoord++;
            terrain[this._yCoord, this._xCoord] = Ground.H;
        }

        //Сдвиг вверх
        public override void MoveUp(Ground[,] terrain)
        {
            if( this._yCoord == 0)
            {
                return;
            }

            terrain[this._yCoord, this._xCoord] = Ground.G;
            this._yCoord--;
            terrain[this._yCoord, this._xCoord] = Ground.H;
            
        }
    }
}
