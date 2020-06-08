using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartieWinForm
{
    public partial class Form1 : Form
    {
        List<Pays> listPays = new List<Pays>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pays p = new Pays("Maroc"); Ville v;
            p.Ajouter(new Ville("Casablanca", 33599000));
            p.Ajouter(new Ville("Fes", 1112000));
            p.Ajouter(new Ville("Tange", 97400));

            v = new Ville("Rabat", 577000);
            p.Ajouter(v);
            p.Capitale = v;
            listPays.Add(p);

            p = new Pays("Tunisie");
            listPays.Add(p);

            p = new Pays("Jordanie");
            p.Ajouter(new Ville("Zarka", 395227));
            p.Ajouter(new Ville("Irbid", 250645));

            v = new Ville("Amman", 994199);
            p.Ajouter(v);
            p.Capitale = v;
            listPays.Add(p);

            foreach (Pays op in listPays) cb_pays.Items.Add(op.Nom);
        }

        private void cb_pays_SelectedIndexChanged(object sender, EventArgs e)
        {
                remplir(listPays[cb_pays.SelectedIndex].Villes);
        }

        private void bt_trier_Click(object sender, EventArgs e)
        {
            string trie = "Croissant";
            if (rb_decroissant.Checked) trie = "Décroissant";
            remplir(listPays[cb_pays.SelectedIndex].trierParPopulation(trie));
        }

        private void remplir(List<Ville> lv)
        {
            listVilles.Items.Clear();
            if (listPays[cb_pays.SelectedIndex].Villes.Count() == 0) listVilles.Items.Add("Aucune Ville !!");
            else
            {
                foreach (Ville v in lv)
                {
                    if (v.Nom.Equals(listPays[cb_pays.SelectedIndex].Capitale.Nom)) listVilles.Items.Add("-->" + v.ToString());
                    else listVilles.Items.Add(v.ToString());
                }
            }
            
        }

        private void bt_ordreInitial_Click(object sender, EventArgs e)
        {
            remplir(listPays[cb_pays.SelectedIndex].Villes);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir fermer ??", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
