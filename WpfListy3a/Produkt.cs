using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfListy3a
{
   
    public class Produkt
    {
        public string Nazwa { get; set; }
        public int Cena { get; set; }
        public string Opis { get; set;}
        public bool Dostepny { get; set;}
        public String KategoriaProduktu { get; set;}

        public Produkt(string nazwa, int cena, string opis)
        {
            Nazwa = nazwa;
            Cena = cena;
            Opis = opis;
            Dostepny = true;
            KategoriaProduktu = "Przybory";
        }

        public Produkt(string nazwa, int cena, string opis, bool dostepny) : this(nazwa, cena, opis)
        {
            Dostepny = dostepny;
        }

        public Produkt(string nazwa, int cena, string opis, bool dostepny, string kategoriaProduktu) : this(nazwa, cena, opis, dostepny)
        {
            KategoriaProduktu = kategoriaProduktu;
        }
    }
}
