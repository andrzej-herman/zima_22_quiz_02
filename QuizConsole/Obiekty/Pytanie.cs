using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole.Obiekty
{
    public class Pytanie
    {
        public int Id { get; set; }
        public string Tresc { get; set; }
        public int Kategoria { get; set; }
        public string Odp_01 { get; set; }
        public string Odp_02 { get; set; }
        public string Odp_03 { get; set; }
        public string Odp_04 { get; set; }

        public void WyswietlPytanie()
        {
            // kod który wuswietla pytanie graczowi
        }

        public int PodajKategoriePytania()
        {
            return Kategoria;
        }

    }
}
