/***********************************************************************
 * Module:  SystemClock.cs
 * Author:  lukaa
 * Purpose: Definition of the Class SystemClock
 ***********************************************************************/

using System;

namespace Model
{
   public class SystemClock
   {
      public static long Tick()
      {
         // TODO: implement
         return 0;
      }
   
      public long ElapsedTime { get; set; }

        public SystemClock(long elapsedTime)
        {
            ElapsedTime = elapsedTime;
        }

        public SystemClock()
        {
        }
    }
}