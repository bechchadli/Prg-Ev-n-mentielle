using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen2018V1
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
                    Regex regex = new Regex(@"[0-9]{4,}");
                    if (!regex.IsMatch(value))
                        throw new Exception("Le nom du pays ne doit pas contenir des chiffres et doit avoir au moins 4 car !!!!!!");
                    this.nom = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
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
            //Ville v;
            //bool trie = true; int cpt = 0;
            //do
            //{
            //    for (int i = 0; i < villes.Count() - (1+cpt) ; i++)
            //    {
            //        if (villes[i].Population > villes[i + 1].Population)
            //        {
            //            v = villes[i];
            //            villes[i] = villes[i + 1];
            //            villes[i + 1] = v;
            //            trie = false;
            //        }
            //    }
            //    cpt++;
            //} while (!trie);

            //if (ordre.Equals("decroissant")) villes.Reverse();
            //return villes;

            List<Ville> villeTriee = new List<Ville>();
            Ville v;
            do
            {
                v = villes[0];
                for (int i = 1; i < villes.Count(); i++)
                {
                    if (v.Population < villes[i].Population) v = villes[i];
                }
                villeTriee.Add(v);
                villes.Remove(v);
            } while (villes.Count() > 1);

            if (ordre.Equals("decroissant")) villeTriee.Reverse();
            return villeTriee;

        }

        public int PopulationTotale()
        {
            int total = 0;
            foreach (Ville v in villes) total += v.Population;
            return total;
        }
    }
}
