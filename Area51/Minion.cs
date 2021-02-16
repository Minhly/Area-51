using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Area51
{
    public class Minion
    {
        public int CertLvl { get; set; }
        public int SpawnFloor { get; set; }
        public int TargetFloor { get; set; }
        public int SpawnTime { get; set; }
        public bool Dead { get; set; }
        public Minion(int certLvl, int spawnFloor, int targetFloor, int spawnTime, bool dead)
        {
            CertLvl = certLvl;
            SpawnFloor = spawnFloor;
            TargetFloor = targetFloor;
            SpawnTime = spawnTime;
            Dead = dead;
        }

    }
}
