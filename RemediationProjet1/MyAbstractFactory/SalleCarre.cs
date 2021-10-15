using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediationProjet1.MyAbstractFactory
{
    public class SalleCarre : Salle, ISalleCarre
    {
        public string GetASalle()
        {
            return "Une salle carré";
        }
    }
}
