using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWF1
{
    class Etudiant
    {
        private int id;
        private string nom;
        private string prenom;
        private bool etat;
        private bool bac;
        private bool licence;
        private bool master;

        public Etudiant() { }
        public Etudiant(int id, string nom, string prenom, bool etat)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.etat = etat;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public bool Etat { get => etat; set => etat = value; }
    }
}
