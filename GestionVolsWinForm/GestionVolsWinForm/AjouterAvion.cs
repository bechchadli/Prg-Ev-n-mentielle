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
    public partial class AjouterAvion : Form
    {
        Avion oa;
        public AjouterAvion()
        {
            InitializeComponent();
        }

        private void cb_marque_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_type.Items.Clear();
            cb_type.Text = "";
            switch(cb_marque.SelectedIndex)
            {
                case 0:
                    cb_type.Items.Add("A300");
                    cb_type.Items.Add("A310");
                    cb_type.Items.Add("A320");
                    break;
                case 1:
                    cb_type.Items.Add("737");
                    cb_type.Items.Add("747");
                    cb_type.Items.Add("757");
                    break;
                case 2:
                    cb_type.Items.Add("AN-14");
                    cb_type.Items.Add("AN-24");
                    cb_type.Items.Add("AN-34");
                    break;
            }
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            DeclarationsGlobales.viderTextBox(this);
        }

        private void txt_numero_Validating(object sender, CancelEventArgs e)
        {
            DeclarationsGlobales.ValidationTxtNumerique(txt_numero, "Le numéro doit être numérique !!!", errorProviderTxt, e);
        }

        private void txt_capacite_Validating(object sender, CancelEventArgs e)
        {
            DeclarationsGlobales.ValidationTxtNumerique(txt_capacite, "La capacité doit être numérique !!!", errorProviderTxt, e);
        }

        private void cb_marque_Validating(object sender, CancelEventArgs e)
        {
            DeclarationsGlobales.ValidationTxtVide(cb_marque, "Il Faut choisir une marque !!!", errorProviderTxt, e);
        }

        private void cb_type_Validating(object sender, CancelEventArgs e)
        {
            DeclarationsGlobales.ValidationTxtVide(cb_type, "Il Faut choisir un type !!!", errorProviderTxt, e);
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)) //Pour vérifier la validation de tous les controles
            {
                oa = new Avion(int.Parse(txt_numero.Text), cb_marque.Text, cb_type.Text, int.Parse(txt_capacite.Text));
                DeclarationsGlobales.avions.Add(oa);
                MessageBox.Show("Ajout Réussit ", "Nouveau Avion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeclarationsGlobales.viderTextBox(this);
            }
        }
    }
}
