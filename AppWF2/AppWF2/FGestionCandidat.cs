using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWF2
{
    public partial class FGestionCandidat : Form
    {
        //Déclaration globale au niveau formulaire
        Candidat c;
        int p = 0;
        public FGestionCandidat()
        {
            InitializeComponent();
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            vider();
        }
        private void vider()
        {
            txt_num.Clear();
            txt_nom.Clear();
            txt_prenom.Clear();
            cc_bac.Checked = false;
            cc_licence.Checked = false;
            cc_master.Checked = false;
            rb_celib.Checked = true;
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            c = new Candidat(int.Parse(txt_num.Text), txt_nom.Text, txt_prenom.Text, cc_bac.Checked, cc_licence.Checked, cc_master.Checked, SF());
            Program.candidats.Add(c);

            vider();
        }

        private void bt_premier_Click(object sender, EventArgs e)
        {
            p = 0;
            naviguer();
        }

        private void bt_dernier_Click(object sender, EventArgs e)
        {
            p = Program.candidats.Count - 1;
            naviguer();
        }

        private void bt_precedent_Click(object sender, EventArgs e)
        {
            if (p > 0) { p--; naviguer(); }
            else MessageBox.Show("Vous êtes sur le premier Candidat !");
        }

        private void bt_suivant_Click(object sender, EventArgs e)
        {
            if (p < Program.candidats.Count - 1) { p++; naviguer(); }
            else MessageBox.Show("Vous êtes sur le dernier Candidat !");
        }

        private void naviguer()
        {
            c = Program.candidats[p];
            txt_num.Text = c.Num.ToString();
            txt_nom.Text = c.Nom.ToString();
            txt_prenom.Text = c.Prenom.ToString();
            cc_bac.Checked = c.Bac;
            cc_licence.Checked = c.Licence;
            cc_master.Checked = c.Master;

            string sf = c.Sf;
            switch (sf)
            {
                case "C":
                    rb_celib.Checked = true;
                    break;
                case "M":
                    rb_marie.Checked = true;
                    break;
                case "D":
                    rb_div.Checked = true;
                    break;
            }
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            
            
            c.Num = int.Parse(txt_num.Text);
            c.Nom = txt_nom.Text;
            c.Prenom = txt_prenom.Text;
            c.Bac = cc_bac.Checked;
            c.Licence = cc_licence.Checked;
            c.Master = cc_master.Checked;
            c.Sf = SF();
            vider();
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            Program.candidats.Remove(c);
            //Program.candidats.RemoveAt(p);
            vider();
        }

        private string SF()
        {
            string sf;
            if (rb_celib.Checked) sf = "C"; else if (rb_marie.Checked) sf = "M"; else sf = "D";
            return sf;
        }

        private void bt_formSuivant_Click(object sender, EventArgs e)
        {
            ConsulterCandidat fConsulterCandidat = new ConsulterCandidat();
            fConsulterCandidat.Show();
        }
    }
}
