using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Edzoterem
{
    internal class Gym
    {
        private List<GymReservation> reservations;

        public Gym()
        {
            this.reservations = new List<GymReservation>();
        }

        internal List<GymReservation> Reservations { get => reservations; set => reservations = value; }
    
        public bool addReservation(GymReservation reservation)
        {
            bool searched = this.reservations.Any(r => r.getReservationTime == reservation.getReservationTime);
            if (!searched)
            {
                this.reservations.Add(reservation);
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
