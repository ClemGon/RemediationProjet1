using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediationProjet1.MyAbstractFactory.AbastractWithCorrectInterface
{
    public interface IAbstractTerrasse
    {
        string FunctionTerrasse();

        string AutreFunctionTerrasse(IAbstractBalcon abstractBalcon);

    }
}
