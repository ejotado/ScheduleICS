using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Mail;

namespace ScheduleICS.Test
{
   [TestClass]
   public class MeetingRequestSendMail
   {
      [TestMethod]
      public void SendMail()
      {
         MailMessage mail = new MailMessage("bidule@dotnethub.be", "to@dotnethub.be");
         mail.Subject = "Coucou";
         mail.Body = "Salut";

         Event myEvent = new Event();
         myEvent.UID = "Test-01";
         myEvent.Location = "Brussels";
         myEvent.Status = EventStatus.CONFIRMED;
         myEvent.Organizer = new Organizer() { PublicName = "Thierry THOUA", Email = "bidule@dotnethub.be" };
         myEvent.StartTime = new DateTime(2011, 7, 1, 17, 0, 0);
         myEvent.EndTime = new DateTime(2011, 7, 1, 19, 0, 0);
         myEvent.Attendees.Add(new Attendee() { PublicName = "Jojo Lapin", Email = "bidule@domain.com", Role = Role.OPTPARTICIPANT });
         myEvent.Description = "Voici une conf";
         myEvent.Title = "Conference about ics";

         mail.AddEvent(myEvent);
      }
   }
}
