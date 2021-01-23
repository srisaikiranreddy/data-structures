/*
We are writing a tool to help users manage their calendars. Given an unordered list of times of day when someone is busy, write a function that tells us whether they're available during a specified period of time.

Each time is expressed as an integer using 24-hour notation, such as 1200 (12:00), 1530 (15:30), or 800 (8:00).

Sample input:

meetings = [
  [1230, 1300], // 12:30 PM to 1:00 PM
  [845, 900],   //  8:45 AM to 9:00 AM
  [1300, 1500]  //  1:00 PM to 3:00 PM
]

Expected output:

isAvailable(meetings, 915, 1215)   => true
isAvailable(meetings, 900, 1230)   => true
isAvailable(meetings, 850, 1240)   => false
isAvailable(meetings, 1200, 1300)  => false
isAvailable(meetings, 700, 1600)   => false
isAvailable(meetings, 800, 845)    => true
isAvailable(meetings, 1500, 1800)  => true
isAvailable(meetings, 845, 859)    => false
isAvailable(meetings, 846, 900)    => false
isAvailable(meetings, 846, 859)    => false
isAvailable(meetings, 845, 900)    => false
isAvailable(meetings, 2359, 2400)  => true
isAvailable(meetings, 930, 1600)   => false
isAvailable(meetings, 800, 850)    => false
isAvailable(meetings, 1400, 1600)  => false
isAvailable(meetings, 1300, 1501)  => false

*/

using System;
namespace DataStructures.Strings
{
    public class WayFairIn2
    {
        
        public static int[] time = new int[2401];
        public WayFairIn2()
        {
            Console.Write("\n Print WayFairIn2");
            int[][] meetings = new int[][] {
          new int[] {1230, 1300},
          new int[] { 845,  900},
          new int[] {1300, 1500},
        };

            for (int i = 0; i < 2401; i++)
            {
                time[i] = i;
            }
            RemoveMettings(meetings);
            Console.Write("\n Output: isAvailable(meetings, 915, 1215) " + isAvailable("meetings", 915, 1215));
            Console.Write("\n Output: isAvailable(meetings, 900, 1230) " + isAvailable("meetings", 900, 1230));
            Console.Write("\n Output: isAvailable(meetings, 850, 1240) " + isAvailable("meetings", 850, 1240));
            //Console.Write("\n Output: isAvailable('"'meetings'"', 1200, 1300)" + isAvailable('"'meetings'"', 1200, 1300));
            //Console.Write("\n Output: isAvailable('"'meetings'"', 700, 1600) " + isAvailable('"'meetings'"', 700, 1600));
            //Console.Write("\n Output: isAvailable('"'meetings'"', 800, 845)  " + isAvailable('"'meetings'"', 800, 845));
            //Console.Write("\n Output: isAvailable('"'meetings'"', 1500, 1800)" + isAvailable('"'meetings'"', 1500, 1800));
            //Console.Write("\n Output: isAvailable('"'meetings'"', 845, 859)  " + isAvailable('"'meetings'"', 845, 859));
            //Console.Write("\n Output: isAvailable('"'meetings'"', 846, 900)  " + isAvailable('"'meetings'"', 846, 900));
            //Console.Write("\n Output: isAvailable('"'meetings'"', 846, 859)  " + isAvailable('"'meetings'"', 846, 859));
            //Console.Write("\n Output: isAvailable('"'meetings'"', 845, 900)  " + isAvailable('"'meetings'"', 845, 900));
            //Console.Write("\n Output: isAvailable('"'meetings'"', 2359, 2400)" + isAvailable('"'meetings'"', 2359, 2400));
            //Console.Write("\n Output: isAvailable('"'meetings'"', 930, 1600) " + isAvailable('"'meetings'"', 930, 1600));
            //Console.Write("\n Output: isAvailable('"'meetings'"', 800, 850)  " + isAvailable('"'meetings'"', 800, 850));
            //Console.Write("\n Output: isAvailable('"'meetings'"', 1400, 1600)" + isAvailable('"'meetings'"', 1400, 1600));
            //Console.Write("\n Output: isAvailable('"'meetings'"', 1300, 1501)" + isAvailable('"'meetings'"', 1300, 1501));
        }

        static void RemoveMettings(int[][] input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                int low = input[i][0];
                int high = input[i][1];
                Remove(low, high);
            }
        }

        static void Remove(int low, int high)
        {
            for (int i = low; i <= high; i++)
            {
                time[i] = 0;
            }
        }

        static bool isAvailable(string m, int lowBound, int highBound)
        {
            var i = time[lowBound];
            return (time[lowBound] != 0 && time[highBound] != 0);
        }
    }
}

