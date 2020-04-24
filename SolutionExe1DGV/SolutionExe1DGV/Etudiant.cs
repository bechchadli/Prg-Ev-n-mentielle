using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionExe1DGV
{
    [Serializable]
    class Etudiant
    {
        private int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        private string sexe;

        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
        
        private string filiere;

        public string Filiere
        {
            get { return filiere; }
            set { filiere = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Etudiant() { }
        public Etudiant(int num, string nom, string prenom,string sexe, string filiere, int age)
        {
            this.num = num;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.filiere = filiere;
            this.age = age;
        }
    }
}
