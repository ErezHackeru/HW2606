using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2605_Enums
{
    public enum ElevatorState
    {
        GOING_UP,
        GOING_DOWN,
        OPEN_DOORS,
        RESTING
    }

    [Flags]
    public enum Days
    {
        Sat =1,
        Sun =2,
        Mon =4,
        Tue =8,
        Wed =16,
        Thu =32,
        Fri =64
    }
}
