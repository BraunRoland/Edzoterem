using System;
using System.Collections.Generic;
using System.Text;

namespace Edzoterem
{
    internal class TeamReservation : GymReservation
    {
        private string contactName;
        private List<string> teamMembers;
        private int reservationTime;

        public TeamReservation(string contactName, List<string> teamMembers, int reservationTime)
        {
            this.contactName = contactName;
            this.teamMembers = teamMembers;
            this.reservationTime = reservationTime;
        }

        public string ContactName { get => contactName; set => contactName = value; }
        public List<string> TeamMembers { get => teamMembers; set => teamMembers = value; }
        public int ReservationTime { get => reservationTime; set => reservationTime = value; }

        public int calculatePriceToPay()
        {
            getContactName();
            return 9000/teamMembers.Count;
        }

        public string getContactName()
        {
            return this.contactName;
        }

        public int getReservationTime()
        {
            return this.ReservationTime;
        }
    }
}
