using System;
using System.Collections.Generic;
using System.Text;

namespace Area51
{
    public class MinionList
    {
        List<Minion> minions = new List<Minion>();
        Minion minion = new Minion(1, 1, 1, 1, false);
        Random rndNumb = new Random();
        public MinionList()
        {
            for (int i = 0; i < 20; i++)
            {
                Minion minion = new Minion(1, 1, 1, 1, false);

                int minionRnd = rndNumb.Next(0,4);
                minion.CertLvl = minionRnd;

                minionRnd = rndNumb.Next(0, 4);
                minion.SpawnFloor = minionRnd;

                minionRnd = rndNumb.Next(0, 5);
                minion.SpawnTime = minionRnd;

                minionRnd = rndNumb.Next(0, 4);
                minion.TargetFloor = minionRnd;

                minions.Add(minion);
            }
        }

        public List<Minion> GetMinions()
        {
            return minions;
        }
    }
}
