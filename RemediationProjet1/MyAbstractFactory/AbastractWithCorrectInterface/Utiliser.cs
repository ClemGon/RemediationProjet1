using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediationProjet1.MyAbstractFactory.AbastractWithCorrectInterface
{
    public class Utiliser
    {
        public void Launch()
        {
            Console.WriteLine("Utilisation de la factory carre :");
            ClientMethod(new ConcreteFactoryCarre());

            Console.WriteLine();

            Console.WriteLine("Utilisation de la factory ronde");
            ClientMethod(new ConcreteFactoryRonde());
        }

        public void ClientMethod(InterfaceFactory factory)
        {
            var Terrasse = factory.CreateTerrasse();
            var Balcon = factory.CreateBalcon();

            Console.WriteLine(Terrasse.FunctionTerrasse());
            Console.WriteLine(Terrasse.AutreFunctionTerrasse(Balcon));
        }

    }
}
