using System;
using System.Collections.Generic;
using System.Text;

namespace Area51
{
    public class Scanner
    {
        public delegate void AlertTurretToKill();
        public event AlertTurretToKill AlertTurretz;

        public void Scan(Minion minis, Etage etagez)
        {
            if (minis.CertLvl < minis.TargetFloor)
            {
                minis.Dead = true;
                AlertTurretInvoke();
            }
            else
            {
                Console.WriteLine("You live");
            }
        }

        public void AlertTurretInvoke()
        {
            if (AlertTurretz != null)
            {
                AlertTurretz();
            }
        }

        public void AlertSubscribe()
        {
            AlertTurretz += OnAlertKillMinion;
        }

        public void OnAlertKillMinion()
        {
            Console.WriteLine("Success minion has been killed!\n");
        }


    }
}
