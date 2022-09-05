using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediRep
{
    public class Środki
    {
        private string nazwa, postać, jednostka_miary, jednostka;
        private int id,id_Pakietu;

        public static List<Środki> lista_środków_w_systemie = new List<Środki>();

        public string Nazwa
        {
            get => this.nazwa;
            set => this.nazwa = value;
        }
        public string Postać
        {
            get => this.postać;
            set => this.postać = value;
        }
        public string Jednostka_miary
        {
            get => this.jednostka_miary;
            set => this.jednostka_miary = value;
        }
        public string Jednostka
        {
            get => this.jednostka;
            set => this.jednostka = value;
        }

        public int Id_Pakietu
        {
            get => this.id_Pakietu;
            set => this.id_Pakietu = value;
        }
        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public string[] TabelaŚrodków()
        {
            string[] tbl = new string[4];
            tbl[0] = Nazwa;
            tbl[1] = Postać;
            tbl[2] = Jednostka_miary;
            tbl[3] = Jednostka;
            return tbl;
        }

        public override string ToString()
        {
            return  Nazwa + " " + Postać + " " + Jednostka_miary + " "  + Jednostka +" | "+ Id;
        }

        public bool CzyTenSamPracownik(Środki środek1, Środki środek2)
        {
            return środek1.id == środek2.id && środek1.nazwa == środek2.nazwa && środek1.postać == środek2.postać && środek1.jednostka_miary == środek2.jednostka_miary && środek1.jednostka == środek2.jednostka;
        }
    }
}
