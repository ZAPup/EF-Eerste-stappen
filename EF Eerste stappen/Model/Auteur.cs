using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Eerste_stappen.Model
{
    class Auteur
    {
        public Auteur(string naam, string emailContact)
        {
            Naam = naam;
            EmailContact = emailContact;
        }
        public int Id { get; set; }
        public string Naam { get; set; }
        public string EmailContact { get; set; }
    }
}
