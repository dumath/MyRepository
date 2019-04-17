using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gower
{
    class World
    {
        //Константный размер земли
        private const int DEFAULT_Y = 5;
        private const int DEFAULT_X = 10;

        //TODO: Добавить аргументы сетки,если значения в них НЕ КОНСТАНТНЫЕ
        
        //Земля, по которой движется герой
        private Ground[,] terrain;

        //Герой, которым управляет пользователь
        private Heroy mainHeroy;

        //TODO:Под UWP - для задания размера земли ниже
        //ПАССИВНЫЙ конструктор объекта WORLD(Использованы необязательные параметры)
        //Если значения в конструкторе не указаны, автоматически присвоются константы
        public World(int y = DEFAULT_Y, int x = DEFAULT_X)
        {
            this.terrain = new Ground[y, x];

            for(int yCicle = 0; yCicle < y; yCicle++)
            {
                for(int xCicle = 0; xCicle < x; xCicle++)
                {
                    
                    this.terrain[yCicle, xCicle] = Ground.G;
                    
                    if (yCicle == 0 && xCicle == 0)
                    {
                        this.terrain[yCicle, xCicle] = Ground.H;
                        this.mainHeroy = new Heroy(yCicle, xCicle);
                    }
                    Console.Write(this.terrain[yCicle, xCicle]);
                }
                Console.WriteLine();
            }
        }

        //Метод обновления мира
        public void Update()
        {
            for(int y = 0; y < DEFAULT_Y; y++ )
            {
                for(int x = 0; x < DEFAULT_X; x++)
                {
                    Console.Write(this.terrain[y, x]);
                }
                Console.WriteLine();
            }
        }

        //Метод взаимодействия пользователя и героя
        public void Move(ConsoleKey key)
        {
            IMove moveObj = this.mainHeroy as IMove;
            if(moveObj != null)
            {
                switch (key)
                {
                    case ConsoleKey.W:
                        moveObj.MoveUp(this.terrain);
                        break;
                    case ConsoleKey.S:
                        moveObj.MoveDown(this.terrain);
                        break;
                    case ConsoleKey.A:
                        moveObj.MoveLeft(this.terrain);
                        break;
                    case ConsoleKey.D:
                        moveObj.MoveRigth(this.terrain);
                        break;
                    default: return;

                }
            }
            
        }
    }
}
