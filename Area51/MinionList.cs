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
            for (int i = 0; i < 2; i++)
            {
                Minion minion = new Minion(1, 1, 1, 1, false);

                int minionRnd = rndNumb.Next(0,2);
                minion.CertLvl = minionRnd;

                minionRnd = rndNumb.Next(0, 5);
                minion.SpawnFloor = minionRnd;

                minionRnd = rndNumb.Next(5, 10);
                minion.SpawnTime = minionRnd;

                minionRnd = rndNumb.Next(3, 10);
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
