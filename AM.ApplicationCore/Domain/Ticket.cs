﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        [ForeignKey("Passenger")]
        public string PassengerFk { get; set; } // prop clé etrangere
        [ForeignKey("Flight")]
        public int FlightFk { get; set; }  // prop clé etrangere

        public double Prix { get; set; }
        public string Siege { get; set; }
        public bool VIP { get; set; }
        public Flight Flight { get; set; }
        public Passenger Passenger { get; set; }

    }
}
