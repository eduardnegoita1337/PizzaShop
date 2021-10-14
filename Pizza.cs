using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_NegoitaEduard
{
    public class Pizza
    {
        public string Denumire;
        public int Stoc;
        public float Pret;
        public int TimpPreparare; // in minute
         public Pizza(string _denumire, int _stoc, float _pret, int _timpPrep)
        {
            Denumire = _denumire;
            Stoc = _stoc;
            Pret = _pret;
            TimpPreparare = _timpPrep;
        }
    }
}
