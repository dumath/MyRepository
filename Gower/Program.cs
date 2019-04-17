using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gower
{
    class Program
    {
        static void Main(string[] args)
        {
            World newWorld = new World();
            try
            {
                Console.WriteLine("Press W - move Up");
                Console.WriteLine("Press S - move Down");
                Console.WriteLine("Press A - move Left");
                Console.WriteLine("Press D - move Rigth");
                Console.WriteLine("Press F1 - Exit Program");

                ConsoleKeyInfo userButton = Console.ReadKey();
                while (userButton.Key != ConsoleKey.F1)
                {
                    Console.Clear();
                    newWorld.Move(userButton.Key);
                    newWorld.Update();
                    Console.WriteLine("Press W - move Up");
                    Console.WriteLine("Press S - move Down");
                    Console.WriteLine("Press A - move Left");
                    Console.WriteLine("Press D - move Rigth");
                    Console.WriteLine("Press F1 - Exit Program");
                    userButton = Console.ReadKey();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
        }
    }
}
