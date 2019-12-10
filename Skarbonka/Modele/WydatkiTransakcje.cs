using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skarbonka.Modele
{
    class WydatkiTransakcje
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Dla { get; set; }
        public string Opis { get; set; }
        [BsonRef("konta")]
        public Konta Konto { get; set; }
        [BsonRef("wydatki_kategorie")]

        public PrzychodKat Kategoria { get; set; }
        public double Ilosc { get; set; }
        public string Koszt { get; set; }
        public DateTime Data { get; set; }
    }
}
