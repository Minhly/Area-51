using System;
using System.Collections.Generic;
using System.Text;

namespace Area51
{
    public class Elevator
    {
        EtageList etageList = new EtageList();
        List<Etage> etager;
        int floorCount = 0;
        int CurrentFloor { get; set; }
        int TargetFloor { get; set; }
        int PersonLimit { get; set; }

        public Elevator(int currentFloor, int targetFloor, int personLimit)
        {
            etager = etageList.GetEtager();
            CurrentFloor = currentFloor;
            TargetFloor = targetFloor;
            PersonLimit = personLimit;
        }

        public void ElevatorOrderList(List<Minion> minionL)
        {
            foreach (var e in minionL)
            {
                Console.WriteLine("1SpawnFloor: {0}  TargetFloor: {1}",e.SpawnFloor,e.TargetFloor);
            }
        }

        public void CurrentElvFloor(List<Minion> minionL)
        {
            
            if (floorCount == 0)
            {
                Console.WriteLine("Current floor the elevator is in: {0}\n",etager[minionL[0].SpawnFloor].Floor);
                CurrentFloor = minionL[0].TargetFloor;
                floorCount++;
            }
            else
            {
                Console.WriteLine("Current floor the elevator is in: {0}\n", etager[CurrentFloor].Floor);
            }
        }

        public void ChangeFloor(List<Minion> minionL)
        {
            TargetFloor = minionL[0].TargetFloor;
            Console.WriteLine("The elevator is now changing floor from {0} to {1}\n", etager[minionL[0].SpawnFloor].Floor, etager[minionL[0].TargetFloor].Floor);
            CurrentFloor = TargetFloor;
        }
    }
}
