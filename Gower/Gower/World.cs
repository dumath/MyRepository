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
        
        //Земля, по которой движется герой
        private Ground[,] terrain;

        //Герой, которым управляет пользователь
        private Heroy mainHeroy;

        //ПАССИВНЫЙ конструктор объекта WORLD
        public World()
        {
            this.terrain = new Ground[DEFAULT_Y, DEFAULT_X];

            for(int y = 0; y < DEFAULT_Y; y++)
            {
                for(int x = 0; x < DEFAULT_X; x++)
                {
                    
                    this.terrain[y, x] = Ground.G;
                    
                    if (y == 0 && x == 0)
                    {
                        this.terrain[y, x] = Ground.H;
                        this.mainHeroy = new Heroy(y, x);
                    }
                    Console.Write(this.terrain[y, x]);
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
            switch(key)
            {
                case ConsoleKey.W : this.mainHeroy.MoveUp(this.terrain);
                    break;
                case ConsoleKey.S : this.mainHeroy.MoveDown(this.terrain);
                    break;
                case ConsoleKey.A : this.mainHeroy.MoveLeft(this.terrain);
                    break;
                case ConsoleKey.D : this.mainHeroy.MoveRigth(this.terrain);
                    break;
                default : return ;

            }
        }
    }
}
