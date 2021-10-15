using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediationProjet1.MyAbstractFactory.AbastractWithCorrectInterface
{
    public class ConcreteFactoryCarre : InterfaceFactory
    {
        public IAbstractBalcon CreateBalcon()
        {
            return new BalconCarre();
        }

        public IAbstractTerrasse CreateTerrasse()
        {
            return new TerasseCarre();
        }
    }
}
