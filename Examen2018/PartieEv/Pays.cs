using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartieWinForm
{
    class Pays
    {
        private string nom;
        private Ville capitale;
        private List<Ville> villes = new List<Ville>();

        public Pays(string nom)
        {
            this.Nom = nom;
        }

        public Pays(string nom, Ville capitale):this(nom)
        {
            this.Capitale = capitale;
        }

        public string Nom
        {
            get { return nom; }
            set
            {
                try
                {
                    Regex regex = new Regex(@"^\D{4,}");
                    if (!regex.IsMatch(value))
                        throw new Exception("Le nom du pays ne doit pas contenir des chiffres et doit avoir au moins 4 car !!!!!!");
                    this.nom = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public List<Ville> Villes { get => villes; set => villes = value; }
        public Ville Capitale
        {
            get { return capitale; }
            set
            {
                //bool tr = false;
                //foreach (Ville v in villes)
                //{
                //    if (value.Nom.Equals(v.Nom)) { tr = true; break; }
                //}
                //if (!tr)
                //{
                //    villes.Add(value);
                //}
                int p = Rechercher(value.Nom);
                if (p==-1)
                {
                    villes.Add(value);
                }
                this.capitale = value;
            }
        } 
        public int NombreVilles { get { return villes.Count(); } }
        public int Rechercher(string nomVille)
        {
            foreach (Ville v in villes)
            {
                if (nomVille.Equals(v.Nom)) { return villes.IndexOf(v); }
            }
            return -1;
        }
        public void Ajouter(Ville ville)
        {
            if (Rechercher(ville.Nom) == -1) villes.Add(ville);
        }

        public void Supprimer(string nomVille)
        {
            int p = Rechercher(nomVille);
            if(p!=-1)
            {
                villes.RemoveAt(p);
                if (nomVille.Equals(this.capitale.Nom)) this.capitale = null;
            }
        }

        public List<Ville> trierParPopulation(string ordre)
        {
            List<Ville> lv = new List<Ville>();
            lv.AddRange(villes);
            Ville v;
            bool trie;
            int cpt = 0;
            do
            {
                trie = true;
                for (int i = 0; i < lv.Count() - (1 + cpt); i++)
                {
                    if (lv[i].Population > lv[i + 1].Population)
                    {
                        v = lv[i];
                        lv[i] = lv[i + 1];
                        lv[i + 1] = v;
                        trie = false;
                    }
                }
                cpt++;
            } while (!trie);

            if (ordre.Equals("Décroissant")) lv.Reverse();
            return lv;

            //List<Ville> villeTriee = new List<Ville>();
            //Ville v;
            //do
            //{
            //    v = lv[0];
            //    for (int i = 1; i < lv.Count(); i++)
            //    {
            //        if (v.Population < lv[i].Population) v = lv[i];
            //    }
            //    villeTriee.Add(v);
            //    lv.Remove(v);
            //} while (lv.Count() > 0);

            //if (ordre.Equals("Décroissant")) villeTriee.Reverse();
            //return villeTriee;

        }

        public int PopulationTotale()
        {
            int total = 0;
            foreach (Ville v in villes) total += v.Population;
            return total;
        }
    }
}
