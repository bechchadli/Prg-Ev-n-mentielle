using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2018V1
{
    class Ville
    {
        private string nom;
        private int population;

        public Ville() { }
        public Ville(string nom, int population)
        {
            this.nom = nom;
            this.population = population;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Population { get => population; set => population = value; }
        public override string ToString()
        {
            return this.nom + "(" + this.population.ToString() + " Habitants)";
        }
    }
}
