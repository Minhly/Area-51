using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
        int loopy = 0;
        int minionCount = 1;
        public async Task Start()
        {
            minions = minionList.GetMinions();
            etager = etageList.GetEtager();
            while(loopy < 20)
            {
                var ElevatorEvent = ElevatorEventAsync();
                var minionEventA = MinionEventAsync();
                await minionEventA;
                await ElevatorEvent;
                SubscribeToKillMinion();
                await ScanPersonel();
                KillMinion();
                UnSubToKillMinion();
                loopy++;
            }
        }

        public void AddToList()
        {
/*            int listCounter = 0;
            foreach (var e in minions)
            {
                listCounter++;
                Console.WriteLine("({0})Personel CertificationLvl: {1} SpawnFloor: {3} TargetFloor: {2}", listCounter, e.CertLvl, e.TargetFloor, e.SpawnFloor);
            }
            Console.WriteLine("\nEnter a number to delete a personel");
            int deleteFromListNum = Convert.ToInt32(Console.ReadLine());*/
        }

        public async Task ElevatorEventAsync()
        {
            await SpawnMinion();
            elevator.CurrentElvFloor(minions);
            await Task.Delay(TimeSpan.FromSeconds(15));
            elevator.ChangeFloor(minions);
        }

        public async Task MinionEventAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(minions[0].SpawnTime));
            Console.WriteLine("After {3} seconds Minion {0} has been spawned on floor {1} with the certification level of {2}\n", minionCount, etager[minions[0].SpawnFloor].Floor, minions[0].CertLvl, minions[0].SpawnTime);
            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("Minion {0} presses the button to call for the elevator\n",minionCount);
            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("After 3 seconds the elevator arrives and Minion {0} steps inside, and presses the button for floor {1}\n",minionCount, etager[minions[0].TargetFloor].Floor);
            minionCount++;
        }

        public void UnSubToKillMinion()
        {
            scan.AlertTurretz -= SubTestAlert;
            scan.AlertTurretz -= turret.OnAlertKillMinion;
        }

        public void SubscribeToKillMinion()
        {
            scan.AlertTurretz += turret.OnAlertKillMinion;
            scan.AlertTurretz += SubTestAlert;
        }

        public void SubTestAlert()
        {
            /*Console.WriteLine("Subbed???????????? \n");*/
        }

        public async Task ScanPersonel()
        {
            await scan.Scan(minions[0], etager[minions[0].TargetFloor]);
        }

        public void KillMinion()
        {
            minions.RemoveAt(0);
        }

        public async Task SpawnMinion()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            await Task.Delay(TimeSpan.FromSeconds(0));
            Console.WriteLine("Minion {5} CertLevel: {0}  SpawnFloor: {1} TargetFloor: {2}  SpawnTime: {3}  Dead:{4}\n", minions[0].CertLvl, minions[0].SpawnFloor, minions[0].TargetFloor, minions[0].SpawnTime, minions[0].Dead, minionCount);
            Console.ResetColor();
        }

    }
}
