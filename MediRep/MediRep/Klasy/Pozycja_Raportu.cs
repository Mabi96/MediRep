using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediRep
{
    class Pozycja_Raportu
    {
        private string nazwa, postać, jednostka_miary, jednostka, dawka;
        private int id, id_środka, id_raportu, id_pakietu;
        private decimal ilość_podana, ilość_pobrana;

        static public List<Pozycja_Raportu> lista_Pozycji = new List<Pozycja_Raportu>();

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public string Postać { get => postać; set => postać = value; }
        public string Jednostka_miary { get => jednostka_miary; set => jednostka_miary = value; }
        public string Jednostka { get => jednostka; set => jednostka = value; }
        public string Dawka { get => dawka; set => dawka = value; }
        public int Id { get => id; set => id = value; }
        public int Id_środka { get => id_środka; set => id_środka = value; }
        public int Id_raportu { get => id_raportu; set => id_raportu = value; }
        public int Id_pakietu { get => id_pakietu; set => id_pakietu = value; }
        public decimal Ilość_podana { get => ilość_podana; set => ilość_podana = value; }
        public decimal Ilość_pobrana { get => ilość_pobrana; set => ilość_pobrana = value; }
    }
}
