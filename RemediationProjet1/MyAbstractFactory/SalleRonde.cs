using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediationProjet1.MyAbstractFactory
{
    class SalleRonde : Salle, ISalleRonde
    {
        public string GetASalle()
        {
            return "Une salle carré";
        }
    }
}
