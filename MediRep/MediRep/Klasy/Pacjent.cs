using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediRep.Klasy
{
    public class Pacjent
    {
        private string imię, nazwisko, pesel;
        private int id;

        public static List<Pacjent> lista_pacjętów = new List<Pacjent>();

        public string Imię
        {
            get => this.imię;
            set => this.imię = value;
        }

        public string Nazwisko
        {
            get => this.nazwisko;
            set => this.nazwisko = value;
        }

        public string Pesel
        {
            get => this.pesel;
            set => this.pesel = value;
        }
        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public override string ToString()
        {
            return Imię + " " + Nazwisko;
        }
    }
}
