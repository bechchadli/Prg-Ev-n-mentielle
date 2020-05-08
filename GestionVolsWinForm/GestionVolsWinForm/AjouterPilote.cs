using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVolsWinForm
{
    public partial class AjouterPilote : Form
    {
        Pilote op;
        public AjouterPilote()
        {
            InitializeComponent();
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled)) //Pour vérifier la validation de tous les controles
            {
                op = new Pilote(int.Parse(txt_matricule.Text), txt_nom.Text, txt_prenom.Text);
                DeclarationsGlobales.pilotes.Add(op);
                MessageBox.Show("Ajout Réussit ", "Nouveau Pilote", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeclarationsGlobales.viderTextBox(this);
            }
            
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            DeclarationsGlobales.viderTextBox(this);
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nom_Validating(object sender, CancelEventArgs e)
        {
            //if(string.IsNullOrEmpty(txt_nom.Text))
            //{
            //    e.Cancel = true;
            //    errorProviderMatricule.SetError(txt_nom, "Il Faut saisir le Nom !!!");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProviderMatricule.SetError(txt_nom, null);
            //}

            DeclarationsGlobales.ValidationTxtVide(txt_nom, "Il Faut saisir le Nom !!!", errorProviderTxt, e);
        }

        private void txt_prenom_Validating(object sender, CancelEventArgs e)
        {
           DeclarationsGlobales.ValidationTxtVide(txt_prenom, "Il Faut saisir le Prenom !!!",errorProviderTxt, e);
        }

        private void txt_matricule_Validating(object sender, CancelEventArgs e)
        {
            DeclarationsGlobales.ValidationTxtNumerique(txt_matricule, "Le matricul doit être numérique !!!", errorProviderTxt, e);
        }
    }
}
