using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Area51
{
    public class Scanner
    {
        public delegate void AlertTurretToKill();
        public event AlertTurretToKill AlertTurretz;
        Turret turret = new Turret();
        public async Task Scan(Minion minis, Etage etagez)
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("The elevator door opens and a scanner begins to scan certification level\n");
            if (minis.CertLvl < minis.TargetFloor)
            {
                await Task.Delay(TimeSpan.FromSeconds(2));
                Console.WriteLine("This Minion doesnt have the rights to enter this floor!\n");
                minis.Dead = true;
                await Task.Delay(TimeSpan.FromSeconds(5));
                AlertTurretInvoke();
            }
            else
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The personel has arrived safely at its location Floor: {0}\n\n\n\n", etagez.Floor);
                Console.ResetColor();
            }
        }

        public void AlertTurretInvoke()
        {
            if (AlertTurretz != null)
            {
                AlertTurretz();
            }
        }
    }
}
