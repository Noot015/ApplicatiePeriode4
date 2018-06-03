using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Aanbieding
    {
        public string ACode { get; protected set; }
        public string Titel { get; protected set; }
        public string Beschrijving { get; protected set; }
        public float Huurprijs { get; protected set; }
        public DateTime Geplaatsd { get; protected set; }
        public Gebruiker Verhuurder { get; protected set; }
        public Foto[] Fotos  { get; protected set; }

        public Aanbieding(string aCode, string titel, string beschrijving, float huurprijs, DateTime geplaatsd, Gebruiker verhuurder, Foto[] fotos)
        {
            ACode = aCode;
            Titel = titel;
            Beschrijving = beschrijving;
            Huurprijs = huurprijs;
            Geplaatsd = geplaatsd;
            Verhuurder = verhuurder;
            Fotos = fotos;
        }
    }
}
