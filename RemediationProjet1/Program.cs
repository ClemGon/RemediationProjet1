using RemediationProjet1.AbstractFacoty;
using RemediationProjet1.MyAbstractFactory;
using System;

namespace RemediationProjet1
{
    class Program
    {
        static void Main()
        {
            Cinema cinema = new Cinema();
            AbstractFactory.GetSalle(cinema);
            Console.WriteLine(cinema.Salle.ToString());
           
        }
    }
}
