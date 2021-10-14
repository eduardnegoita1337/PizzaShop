using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_NegoitaEduard
{
    public class Client
    {
        public string Nume;
        public string Prenume;
        public Adresa Adresa;
        public string NrTel;
        public Client( string _nume, string _prenume, Adresa a, string _nrtel)
        {
            Nume = _nume;
            Prenume = _prenume;
            Adresa = a;
            NrTel = _nrtel;
        }


    }
}
