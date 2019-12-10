using System;
using LiteDB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skarbonka.Modele
{
    public class PrzychodTransakcje
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Od { get; set; }
        public string Opis { get; set; }
        [BsonRef("konta")]
        public Konta Konto { get; set; }
        [BsonRef("przychod_kategorie")]
        public PrzychodKat Kategoria { get; set; }
        public double Ilosc { get; set; }
        public DateTime Data { get; set; }

    }
}

