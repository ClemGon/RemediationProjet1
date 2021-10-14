using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediationProjet1.MyAbstractFactory
{
    public interface IFactoryAbstract
    {
        public Cinema GetSalle(Cinema cinema);
    }
}
