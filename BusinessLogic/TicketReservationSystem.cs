using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    public class TicketReservationSystem
    {
        private int seatNumber;
        private int rownNumber;
        private int ticketPrice;
        public TicketReservationSystem(int sno, int rno, int price)
        {
            seatNumber = sno;
            rownNumber = rno;
            ticketPrice = price;
        }
    }

    public class Play : TicketReservationSystem
    {
        private string drama;

        public Play(string act, int sno, int rno, int price) :
            base(sno, rno, price)
        {
            drama = act;
        }
    }

    public class Lecture : TicketReservationSystem
    {
        private string motivationallecture;

        public Lecture(string motilecture,int sno, int rno, int price) :
            base(sno, rno, price)
        {
            motivationallecture = motilecture;
        }
    }

    public class Musical : TicketReservationSystem
    {
        private string Instrumental;

        public Musical(string song, int sno, int rno, int price) :
            base(sno, rno, price)
        {
            Instrumental = song;
        }
    }
}
