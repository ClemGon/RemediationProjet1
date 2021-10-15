using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediationProjet1.MyAbstractFactory.AbastractWithCorrectInterface
{
    public class TerrasseRonde : IAbstractTerrasse
    {
        public string AutreFunctionTerrasse(IAbstractBalcon abstractBalcon)
        {
            var result = abstractBalcon.FunctionBalcon();

            return $"Récupération d'un balcon =====> ({result})";
        }

        public string FunctionTerrasse()
        {
            return "Je suis une terrasse ronde";
        }
    }
}
