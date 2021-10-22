using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediationProjet1.Scoped
{
    public class Scoped
    {
        static Dictionary<Scoped, Object> scopeds = new Dictionary<Scoped, Object>();
        private static Object monObject;

        public Scoped()
        {
            
        }

        public void Instance(Object obj)
        {
            monObject = obj;
            if (!scopeds.ContainsValue(obj))
            {
                scopeds.Add(this, obj);
            }
        }

        public Object GetInstance()
        {

            if (scopeds.ContainsKey(this))
            {
                return scopeds.GetValueOrDefault(this);
            }
            else
            {
                var result = (monObject.GetType()).GetConstructors().First();
                monObject = result.Invoke(null);
                scopeds.Add(this, monObject);

                return monObject;
            }
        }

    }
}
