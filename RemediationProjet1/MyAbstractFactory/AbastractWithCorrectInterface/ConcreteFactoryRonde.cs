using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediationProjet1.MyAbstractFactory.AbastractWithCorrectInterface
{
    public class ConcreteFactoryRonde : InterfaceFactory
    {
        public IAbstractBalcon CreateBalcon()
        {
            return new BalconRond();
        }

        public IAbstractTerrasse CreateTerrasse()
        {
            return new TerrasseRonde();
        }
    }
}
