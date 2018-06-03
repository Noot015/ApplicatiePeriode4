using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Foto
    {

        public string Bestandsnaam { get; protected set; }     //naam waaronder de foto is opgeslagen in het systeem
        public string Beschrijving { get; protected set; }     //beschrijving van de foto
        public string Titel { get; protected set; }            //naam die de gebruiker aan de foto geeft

        public Foto(string bestandsnaam, string beschrijving, string titel)
        {
            Bestandsnaam = bestandsnaam;
            Beschrijving = beschrijving;
            Titel = titel;
        }
    }
}
