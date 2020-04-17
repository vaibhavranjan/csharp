using System;
using CSharpPrograms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{   
    [TestClass]
    public class TicketReservationSystemTests
    {
        [TestMethod]
        public void Ticket_Reservation_System_Tests()
        {
            Play pl = new Play("funny drama act", 1, 1, 1000);
            Musical ml = new Musical("ab tum hi ho", 2, 2, 1000);
            Lecture lc = new Lecture("CSharp", 3, 3, 1000);
        }        
    }
}
