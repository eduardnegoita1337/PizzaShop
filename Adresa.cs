using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_NegoitaEduard
{
    public class Adresa
    {
        public string Oras;
        public string Strada;
        public int Numar;
        public Adresa( string _oras, string _strada, int _numar)
        {
            Oras = _oras;
            Strada = _strada;
            Numar = _numar;
        }
        public override string ToString()
        {
            return Oras + ", " + Strada + ", " + Numar;
        }
    }
}
