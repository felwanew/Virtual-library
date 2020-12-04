using System;
using System.Collections.Generic;
using System.Text;

namespace VirtuelleBibliothek
{
    public class Exemplar
    {
        public int ExemplarID { get; set; }
        public Buch ExemplarBuch = new Buch();
        public bool IstVerliehen { get; set; }
        public DateTime EndeAusleih { get; internal set; }

        public Exemplar()
        {
            IstVerliehen = false;
        }
    }
}
