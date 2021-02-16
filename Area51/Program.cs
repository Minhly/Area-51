using System;

namespace Area51
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController gameCon = new GameController();
            gameCon.Start();
            Console.ReadLine();
        }
    }
}
