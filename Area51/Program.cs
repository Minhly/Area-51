using System;
using System.Threading.Tasks;

namespace Area51
{
    class Program
    {
        static async Task Main(string[] args)
        {
            GameController gameCon = new GameController();
            await gameCon.Start();
            Console.ReadLine();
        }
    }
}
