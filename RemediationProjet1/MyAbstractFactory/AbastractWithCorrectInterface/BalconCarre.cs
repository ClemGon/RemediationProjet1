using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediationProjet1.MyAbstractFactory.AbastractWithCorrectInterface
{
    class BalconCarre : IAbstractBalcon
    {
        public string FunctionBalcon()
        {
            return "Je suis un balcon carré";
        }
    }
}
