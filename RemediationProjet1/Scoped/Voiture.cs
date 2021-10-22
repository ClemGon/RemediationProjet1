using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediationProjet1.Scoped
{
    public class Voiture
    {
        public int Longueur { get; set; }

        public string Nom { get; set; }

        public Voiture()
        {
            Longueur = 20;
            Nom = "Tesla";
        }
    }
}
