using System;
using System.Collections.Generic;
using System.Text;

namespace Edzoterem
{
    internal interface GymReservation
    {
        string getContactName();
        int getReservationTime();
        int calculatePriceToPay();
    }
}
