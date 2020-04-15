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
    public partial class ManipLists : Form
    {
        public ManipLists()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_prenom.Items.Add("Homme");
            lb_prenom.Items.Add("Femme");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Candidat c in Program.candidats)
                cb_nom2.Items.Add(c.Nom);

            foreach (Candidat c in Program.candidats)
                lb_prenom3.Items.Add(c.Prenom);
        }

        private void bt_rechrcher_Click(object sender, EventArgs e)
        {
            foreach (var item in lb_prenom3.SelectedItems)
                MessageBox.Show(item.ToString());

           foreach (int p in lb_prenom3.SelectedIndices)
                MessageBox.Show(p.ToString());

            //MessageBox.Show(cb_nom4.SelectedIndex.ToString());
            //MessageBox.Show(cb_nom4.Text.ToString());
            //MessageBox.Show(cb_nom4.SelectedItem.ToString());
            //MessageBox.Show(cb_nom4.SelectedValue.ToString());
        }

        private void bt_afficher_Click(object sender, EventArgs e)
        {
            
        }

        private void lb_prenom3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cb_nom4.DataSource = Program.candidats;
            cb_nom4.DisplayMember = "Nom";
            cb_nom4.ValueMember = "Num";

        }

        private void cb_nom4_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool tr = false;
            foreach (Candidat c in Program.candidats)
            {
                if (int.Parse(cb_nom4.SelectedValue.ToString()) == c.Num)
                { MessageBox.Show("Candiadt trouvé numero : " + cb_nom4.SelectedValue.ToString()); tr = true; break; }
            }
            if (!tr) MessageBox.Show("Candiadt introuvable");
        }

        private void cb_nom_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Le texte de la liste : " + cb_nom.Text);
            MessageBox.Show("L'element choisi de la liste : " + cb_nom.SelectedItem);
            MessageBox.Show("L'indice de l'element de la liste : " + cb_nom.SelectedIndex);
            MessageBox.Show("La partie selectionnée du texte de la liste : " + cb_nom.SelectedText);
        }

        private void lb_prenom_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Le texte de la liste : " + lb_prenom.Text);
            MessageBox.Show("L'element choisi de la liste : " + lb_prenom.SelectedItem);
            MessageBox.Show("L'indice de l'element de la liste : " + lb_prenom.SelectedIndex);
            
        }
    }
}
