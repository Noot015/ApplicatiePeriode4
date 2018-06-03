using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Gebruiker
    {
        public string GCode { get; protected set; }
        public string Voornaam { get; protected set; }
        public string Tussenvoegsel { get; protected set; }
        public string Achternaam { get; protected set; }
        public string Email { get; protected set; }
        public Foto Profielfoto { get; protected set; }
        public DateTime DatumLid { get; protected set; }

        public Gebruiker(string idCode, string voornaam, string tussenvoegsel, string achternaam, string email, DateTime datumLid, Foto profielfoto = null)
        {
            GCode = idCode;
            Voornaam = voornaam;
            Tussenvoegsel = tussenvoegsel;
            Achternaam = achternaam;
            Email = email;
            DatumLid = datumLid;
            Profielfoto = profielfoto;
        }
    }
}
