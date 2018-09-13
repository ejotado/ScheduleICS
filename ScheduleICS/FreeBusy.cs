using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ScheduleICS
{
   [DataContract]
   internal class FreeBusy : ICalendarElement
   {
      public string GetFormattedElement()
      {
         return null;
      }
   }
}
