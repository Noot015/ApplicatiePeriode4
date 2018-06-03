using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Boeking
    {
        public Gebruiker Verhuurder { get; protected set; }
        public Gebruiker Huurder { get; protected set; }
        public Aanbieding Gehuurde { get; protected set; }
        public DateTime GereserveerdIn { get; protected set; }
        public DateTime GereserveerdUit { get; protected set; }

        public Boeking(Gebruiker verhuurder, Gebruiker huurder, Aanbieding gehuurde, DateTime gereserveerdIn, DateTime gereserveerdUit)
        {
            Verhuurder = verhuurder;
            Huurder = huurder;
            Gehuurde = gehuurde;
            GereserveerdIn = gereserveerdIn;
            GereserveerdUit = gereserveerdUit;
        }
    }
}
