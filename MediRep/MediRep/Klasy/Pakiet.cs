using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediRep
{
    public class Pakiet
    {
        private string nazwa;
        private int id;

        public List<Środki> lista_środków = new List<Środki>();

        static public List<Pakiet> lista_pakietów = new List<Pakiet>();

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public string Nazwa
        {
            get => this.nazwa;
            set => this.nazwa = value;
        }
        public bool CzyTenSamPakiet(Pakiet pakiet1, Pakiet pakiet2)
        {
            return pakiet1.nazwa == pakiet2.nazwa;
        }
        public override string ToString()
        {
            return Nazwa.ToString();
        }
    }
}
