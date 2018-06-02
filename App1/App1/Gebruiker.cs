using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Gebruiker
    {
        public string idCode;
        public string voornaam { get; protected set; }
        public string tussenvoegsel { get; protected set; }
        public string achternaam { get; protected set; }
        public string email { get; protected set; }
        public string profielfoto; 
        private string wachtwoord;
        public DateTime datumLid;
    }
}
