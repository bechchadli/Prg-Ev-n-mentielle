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
    public partial class RechercherCandidat : Form
    {
        public RechercherCandidat()
        {
            InitializeComponent();
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            //c = new Candidat(int.Parse(txt_num2.Text), cb_nom2.Text, txt_prenom2.Text, cc_bac.Checked, cc_licence.Checked, cc_master.Checked, SF());
            //Program.candidats.Add(c);

            //vider();
        }

        private void bt_afficher_Click(object sender, EventArgs e)
        {
            foreach(Candidat oc in Program.candidats)
            {
                switch(oc.Sf)
                {
                    case "C":
                        Celibataire.Items.Add(oc.Nom);
                        break;
                    case "D":
                        Divorce.Items.Add(oc.Nom);
                        break;
                    case "M":
                        Marie.Items.Add(oc.Nom);
                        break;
                }
            }
        }

        private void bt_vider_Click(object sender, EventArgs e)
        {
            Celibataire.Items.Clear();
            Marie.Items.Clear();
            Divorce.Items.Clear();
        }

        private void Celibataire_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Candidat oc in Program.candidats)
            {
                if(Celibataire.Text.Equals(oc.Nom))
                {
                    txt_detail_num.Text = oc.Num.ToString();
                    txt_detail_nom.Text = oc.Nom;
                    txt_detail_prenom.Text = oc.Prenom;
                }
            }
        }

        private void Marie_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Candidat oc in Program.candidats)
            {
                if (Marie.Text.Equals(oc.Nom))
                {
                    txt_detail_num.Text = oc.Num.ToString();
                    txt_detail_nom.Text = oc.Nom;
                    txt_detail_prenom.Text = oc.Prenom;
                }
            }
        }

        private void Divorce_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Candidat oc in Program.candidats)
            {
                if (Divorce.Text.Equals(oc.Nom))
                {
                    txt_detail_num.Text = oc.Num.ToString();
                    txt_detail_nom.Text = oc.Nom;
                    txt_detail_prenom.Text = oc.Prenom;
                }
            }
        }

        private void rb_bac_CheckedChanged(object sender, EventArgs e)
        {
            cb_nom.Items.Clear();
            cb_nom.Text = "";
            if (rb_bac.Checked)
            {
                foreach(Candidat oc in Program.candidats)
                {
                    if (oc.Bac) cb_nom.Items.Add(oc.Nom);
                }
            }
        }

        private void rb_licence_CheckedChanged(object sender, EventArgs e)
        {
            cb_nom.Items.Clear();
            cb_nom.Text = "";
            if (rb_licence.Checked)
            {
                foreach (Candidat oc in Program.candidats)
                {
                    if (oc.Licence) cb_nom.Items.Add(oc.Nom);
                }
            }
        }

        private void rb_master_CheckedChanged(object sender, EventArgs e)
        {
            cb_nom.Items.Clear();
            cb_nom.Text = "";
            if (rb_master.Checked)
            {
                foreach (Candidat oc in Program.candidats)
                {
                    if (oc.Master) cb_nom.Items.Add(oc.Nom);
                }
            }
        }

        private void cb_nom_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Candidat oc in Program.candidats)
            {
                if (oc.Nom.Equals(cb_nom.Text))
                {
                    txt_Num.Text = oc.Num.ToString();
                    txt_prenom.Text = oc.Prenom;
                }
            }
        }
    }
}
