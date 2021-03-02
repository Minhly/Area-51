using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Area51
{
    public class Turret
    {
        public void OnAlertKillMinion()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Turret aims, shoots and kills the personel!\n\n\n\n");
            Console.ResetColor();
        }

    }
}
