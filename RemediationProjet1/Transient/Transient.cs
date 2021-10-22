using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediationProjet1.Transient
{
    public class Transient
    {
        private Transient() { }
        private static Transient _instance;

        public static Transient GetInstance()
        {
            _instance = new Transient();   
            return _instance;
        }
    }
}
