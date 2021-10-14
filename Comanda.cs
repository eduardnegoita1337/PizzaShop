using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_NegoitaEduard
{
   public class Comanda
    {
        public int IdComanda;
        public Client Client;
        public List<Pizza> Pizzas;
        public float ValoareComanda;
        public DateTime DataComanda;
        public Comanda( int _id, Client c, List<Pizza> p, float valoare, DateTime data)
        {
            IdComanda = _id;
            Client = c;
            Pizzas = p;
            ValoareComanda = valoare;
            DataComanda = data;
        }

    }
}
