using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Bericht
    {
        public string Inhoud { get; protected set; }
        public DateTime Datumtijd { get; protected set; }
        public Gebruiker Verzenden { get; protected set; }
        public Gebruiker Ontvanger { get; protected set; }
        public Aanbieding Onderwerp { get; protected set; }

        public Bericht(string bericht, DateTime datumtijd, Gebruiker verzenden, Gebruiker ontvanger, Aanbieding onderwerp)
        {
            Inhoud = bericht;
            Datumtijd = datumtijd;
            Verzenden = verzenden;
            Ontvanger = ontvanger;
            Onderwerp = onderwerp;
        }
    }
}
