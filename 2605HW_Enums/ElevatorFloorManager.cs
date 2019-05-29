using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2605_Enums
{
    class ElevatorFloorManager
    {
        public delegate bool FloorReachedEventHandler();
        public event FloorReachedEventHandler TheFloorReached;

        public bool OnTheFloorReached()
        {
            if (TheFloorReached != null)
            {
                return TheFloorReached.Invoke();
            }
            else
                return false;
        }
    }
}
