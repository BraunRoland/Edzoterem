using System;
using System.Collections.Generic;
using System.Text;

namespace Edzoterem
{
    internal class SingleReservation : GymReservation
    {
        private string contactName;
        private int reservationTime;
        private bool hasSeasonTicket;

        public SingleReservation(string contactName, int reservationTime)
        {
            this.contactName = contactName;
            this.reservationTime = reservationTime;
            this.hasSeasonTicket = false;
        }

        public string ContactName { get => contactName; set => contactName = value; }
        public int ReservationTime { get => reservationTime; set => reservationTime = value; }
        public bool HasSeasonTicket { get => hasSeasonTicket; set => hasSeasonTicket = value; }


        public void buySeasonTicket()
        {
            hasSeasonTicket = true;
        }
        public int calculatePriceToPay()
        {
            if (hasSeasonTicket)
            {
                return 2250;
            }
            else
            {
                return 4500;
            }
        }

        public string getContactName()
        {
            return this.contactName;
        }

        public int getReservationTime()
        {
            return this.reservationTime;
        }
    }
}
