using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWF1
{
    public partial class FAjouterEtudiant : Form
    {
        List<Etudiant> etudiants = new List<Etudiant>();
        public FAjouterEtudiant()
        {
            InitializeComponent();
        }

        
        private void bt_valider_Click(object sender, EventArgs e)
        {
            Etudiant oe = new Etudiant(int.Parse(txt_num.Text), txt_nom.Text, txt_pre.Text, rb_homme.Checked);
            etudiants.Add(oe);
            MessageBox.Show("Ajout réussit ");

            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Clear();
                }
            }
            
        }

        private void FAjouterEtudiant_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_rech_Click(object sender, EventArgs e)
        {
            Etudiant re = null;

           
                foreach (Etudiant oe in etudiants)
                    {
                        if (((int.Parse(txt_num.Text) == oe.Id) && (rb_num.Checked)) || (txt_nom.Text.Equals(oe.Nom) && (rb_nom.Checked)))
                        {
                            re = oe;
                            break;
                        }
                    }
          
            if (re == null)
                MessageBox.Show("Cet etudiant n'existe pas !!!!!");
            else
            {
                txt_num.Text = re.Id.ToString();
                txt_nom.Text = re.Nom;
                txt_pre.Text = re.Prenom;
                if (re.Etat) rb_homme.Checked = true;
                else rb_femme.Checked = true;
            }
        }
    }
}
