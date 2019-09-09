using System;

namespace Gower
{
    class Heroy : Character, IMove
    {
        //Пассивный конструктор отсутствует.Компилятор не создает пассивный конструктор
        public Heroy(int y, int  x)
        {
            this._yCoord = y;
            this._xCoord = x;
        }

        //У методов вручную прописаны крайние правые и нижнее грани(т.е максимально по Y 9 и по Х 9
        //TODO: Поправить в условиях проверки, в методах, крайние значения осей
        //Сдвиг вниз
        void IMove.MoveDown(Ground[,] terrain)
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
        void IMove.MoveLeft(Ground[,] terrain)
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
        void IMove.MoveRigth(Ground[,] terrain)
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
        void IMove.MoveUp(Ground[,] terrain)
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
