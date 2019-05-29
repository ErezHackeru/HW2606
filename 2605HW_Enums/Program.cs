using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW2605_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===========
            // Q1 :
            // ===========
            ElevatorFloorManager elevatorFM = new ElevatorFloorManager();
            Elevator elevator = new Elevator(ElevatorState.RESTING, 3);

            elevatorFM.TheFloorReached += elevator.FloorReached;
            bool IsTheFloorReached;// = elevatorFM.OnTheFloorReached();

            if (elevator.GoToFloor(2))
            {
                Thread.Sleep(2000);
                IsTheFloorReached = elevatorFM.OnTheFloorReached();
            }

            // ===========
            // Q2 :
            // ===========
            Days CourseDays = Days.Sun | Days.Wed;
            Console.WriteLine($"Is Sunday in course: {IsDayInCourseDays(CourseDays, Days.Sun)}");
            Console.WriteLine($"Is Friday in course: {IsDayInCourseDays(CourseDays, Days.Fri)}");
            AddDayToCourseDays(ref CourseDays, Days.Mon);
            Console.WriteLine("AddDayToCourseDays(CourseDays, Days.Mon);===========>>>>");
            Console.WriteLine($"Is Monday in course: {IsDayInCourseDays(CourseDays, Days.Mon)}");
            RemoveDayFromCourseDays(ref CourseDays, Days.Wed);
            Console.WriteLine("RemoveDayFromCourseDays(CourseDays, Days.Wed);===========>>>>");
            Console.WriteLine($"Is Wednesday in course: {IsDayInCourseDays(CourseDays, Days.Wed)}");

            Console.ReadKey();
        }

        public static bool IsDayInCourseDays(Days CourseDays, Days day)
        {
            return CourseDays.HasFlag(day);
        }
        public static void AddDayToCourseDays(ref Days CourseDays, Days day)
        {
            CourseDays = CourseDays |day ;
        }
        public static void RemoveDayFromCourseDays(ref Days CourseDays, Days day)
        {
            CourseDays &= ~day;
        }
    }
}
