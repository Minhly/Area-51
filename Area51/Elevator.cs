using System;
using System.Collections.Generic;
using System.Text;

namespace Area51
{
    public class Elevator
    {
        int CurrentFloor { get; set; }
        int TargetFloor { get; set; }
        int PersonLimit { get; set; }
        public Elevator(int currentFloor, int targetFloor, int personLimit)
        {
            CurrentFloor = currentFloor;
            TargetFloor = targetFloor;
            PersonLimit = personLimit;
        }

        public void EtagePanel()
        {

        }
    }
}
