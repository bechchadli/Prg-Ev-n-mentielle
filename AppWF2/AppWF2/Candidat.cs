using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppWF2
{
    [Serializable]
    class Candidat
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
        private bool bac;

        public bool Bac
        {
            get { return bac; }
            set { bac = value; }
        }
        private bool licence;

        public bool Licence
        {
            get { return licence; }
            set { licence = value; }
        }
        private bool master;

        public bool Master
        {
            get { return master; }
            set { master = value; }
        }
        private string sf;

        public string Sf
        {
            get { return sf; }
            set { sf = value; }
        }

        public Candidat() { }
        public Candidat(int num, string nom, string prenom, bool bac, bool licence, bool master, string sf)
        {
            this.num = num;
            this.nom = nom;
            this.prenom = prenom;
            this.bac = bac;
            this.licence = licence;
            this.master = master;
            this.sf = sf;
        }

    }
}
