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
    public partial class AjouterVol : Form
    {
        Vol ov;
        public AjouterVol()
        {
            InitializeComponent();
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            DeclarationsGlobales.viderTextBox(this);
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nbrVoy_Validating(object sender, CancelEventArgs e)
        {
            DeclarationsGlobales.ValidationTxtNumerique(txt_nbrVoy, "Le champ doit être numérique !!!", errorProviderTxt, e);
        }

        private void txt_PrixBillet_Validating(object sender, CancelEventArgs e)
        {
            DeclarationsGlobales.ValidationTxtNumerique(txt_PrixBillet, "Le prix doit être numérique !!!", errorProviderTxt, e);
        }

        private void cb_pilote_Validating(object sender, CancelEventArgs e)
        {
            DeclarationsGlobales.ValidationTxtVide(cb_pilote, "Il Faut choisir un Pilote !!!", errorProviderTxt, e);
        }

        private void cb_avion_Validating(object sender, CancelEventArgs e)
        {
            DeclarationsGlobales.ValidationTxtVide(cb_avion, "Il Faut choisir un Avion !!!", errorProviderTxt, e);
        }

        private void cb_villeDep_Validating(object sender, CancelEventArgs e)
        {
            DeclarationsGlobales.ValidationTxtVide(cb_villeDep, "Il Faut choisir une Ville !!!", errorProviderTxt, e);
        }

        private void cb_villeArr_Validating(object sender, CancelEventArgs e)
        {
            DeclarationsGlobales.ValidationTxtVide(cb_villeArr, "Il Faut choisir une Ville !!!", errorProviderTxt, e);
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)) //Pour vérifier la validation de tous les controles
            {
                Pilote op = DeclarationsGlobales.pilotes[cb_pilote.SelectedIndex];
                Avion oa = DeclarationsGlobales.avions[cb_avion.SelectedIndex];
                ov = new Vol(op, oa, dateVol.Value, cb_villeDep.Text, cb_villeArr.Text,int.Parse(txt_nbrVoy.Text), int.Parse(txt_PrixBillet.Text));
                DeclarationsGlobales.vols.Add(ov);
                MessageBox.Show("Ajout Réussit ", "Nouveau Vol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeclarationsGlobales.viderTextBox(this);
            }
        }

        private void AjouterVol_Load(object sender, EventArgs e)
        {
            //Remplir la liste des pilotes
            foreach (Pilote op in DeclarationsGlobales.pilotes)
                cb_pilote.Items.Add(op.Nom);
            //Remplir la liste des avions
            foreach (Avion oa in DeclarationsGlobales.avions)
                cb_avion.Items.Add(oa.Numero + " " + oa.Marque + " " + oa.Type);
            //Remplir la liste des ville départ
            cb_villeDep.Items.Add("Oujda");
            cb_villeDep.Items.Add("Casa");
            cb_villeDep.Items.Add("Rabat");
            cb_villeDep.Items.Add("Fes");
            cb_villeDep.Items.Add("Agadir");
            cb_villeDep.Items.Add("Dakhla");
            cb_villeDep.Items.Add("Tanja");
            //Remplir le liste des ville arrivée par les mm villes départ
            Object[] villes = new object[cb_villeDep.Items.Count];
            cb_villeDep.Items.CopyTo(villes, 0);
            cb_villeArr.Items.AddRange(villes);
        }

        private void cb_villeArr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_villeDep.Text.Equals(cb_villeArr.Text))
            {
                MessageBox.Show("La ville de Départ ne doit pas être le même que la ville arrivée !!", "Erreur choix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_villeArr.Focus();
            }
        }

        private void cb_villeDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_villeDep.Text.Equals(cb_villeArr.Text))
            {
                MessageBox.Show("La ville de Départ ne doit pas être le même que la ville arrivée !!", "Erreur choix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_villeDep.Focus();
            }
        }
    }
}
