using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediationProjet1.MyAbstractFactory
{
    public class Consumer
    {

        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new AbstractFactory());
            Console.WriteLine();
        }

        public void ClientMethod(IFactoryAbstract factory)
        {
            Cinema cinema = new();
            factory.GetSalle(cinema);
            Console.WriteLine(cinema.Salle.ToString());
        }
    }
}
