using System;
using System.Collections.Generic;
using System.Text;

namespace Area51
{
    public class GameController
    {
        Random rndNumb = new Random();
        Elevator elevator = new Elevator(1, 1, 1);
        MinionList minionList = new MinionList();
        List<Minion> minions;
        Scanner scan = new Scanner();
        EtageList etageList = new EtageList();
        List<Etage> etager;
        Turret turret = new Turret();

        int count = 0;
        public void Start()
        {
            minions = minionList.GetMinions();
            etager = etageList.GetEtager();
            SubscribeTest();
            ScanPersonel();
        }

        public void SubscribeTest()
        {
            scan.AlertTurretz += SubLol;
            scan.AlertSubscribe();
        }

        public void SubLol()
        {
            Console.WriteLine("Subbed???????????? \n");
        }

        public void ScanPersonel()
        {
            scan.Scan(minions[count], etager[count]);
            Console.WriteLine("Personale Cert: {0}  Target Floor: {1}\n", minions[0].CertLvl, minions[0].TargetFloor);
        }

        public void KillMinion()
        {
            minions.RemoveAt(0);
        }

        public void SpawnMinion()
        {
            int i = 0;
            foreach (var e in minions)
            {
                i++;
                Console.WriteLine("Minion {0}", i);
                Console.WriteLine("Cert: {0}  SpawnFloor: {1} TargetFloor: {2}  SpawnTime: {3}  Dead:{4}\n", e.CertLvl, e.SpawnFloor, e.TargetFloor, e.SpawnTime, e.Dead);
            }
        }

    }
}
