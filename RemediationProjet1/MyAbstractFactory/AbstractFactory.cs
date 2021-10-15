using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediationProjet1.MyAbstractFactory
{
    public class AbstractFactory : IFactoryAbstract
    {
        public Cinema GetSalle(Cinema cinema)
        {
            var salleCarré = new SalleCarre();
            var salleRonde = new SalleRonde();

            Random aleatoire = new();
            int entierUnChiffre = aleatoire.Next(2);

            if (entierUnChiffre == 1)
            {
                cinema.Salle = salleCarré;
                return cinema;
            }
            else
            {
                cinema.Salle = salleRonde;
                return cinema;
            }

        }
    }
}
