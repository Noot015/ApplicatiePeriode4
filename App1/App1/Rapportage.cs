using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Rapportage
    {
        public Gebruiker Rapporteerder { get; protected set; }
        public Gebruiker Gerapporteerde { get; protected set; }
        public string Klacht { get; protected set; }
        public DateTime Datumtijd { get; protected set; }
        public Foto Bewijs { get; protected set; }

        public Rapportage(Gebruiker rapporteerder, Gebruiker gerapporteerde, string klacht, DateTime datumtijd, Foto bewijs)
        {
            Rapporteerder = rapporteerder;
            Gerapporteerde = gerapporteerde;
            Klacht = klacht;
            Datumtijd = datumtijd;
            Bewijs = bewijs;
        }
    }
}
