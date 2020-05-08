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
    
    public partial class MAJVol : Form
    {
        Vol ov;
        public MAJVol()
        {
            InitializeComponent();
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            DeclarationsGlobales.viderTextBox(this);
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Etes vous sur de vouloir supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rep == DialogResult.Yes)
            {
                DeclarationsGlobales.vols.Remove(ov);

                int i = cb_numero.SelectedIndex;
                cb_numero.Items.RemoveAt(cb_numero.SelectedIndex);

                if (i > 0) cb_numero.SelectedIndex = --i;
                else DeclarationsGlobales.viderTextBox(this);
            }
        }

        private void MAJVol_Load(object sender, EventArgs e)
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

            foreach (Vol ov in DeclarationsGlobales.vols)
                cb_numero.Items.Add(ov.Numero);

            if (cb_numero.Items.Count > 0) cb_numero.SelectedIndex = 0;
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            ov.Vpilote = DeclarationsGlobales.pilotes[cb_pilote.SelectedIndex];
            ov.Vavion = DeclarationsGlobales.avions[cb_avion.SelectedIndex];
            ov.DateVol = dateVol.Value;
            ov.VilleDepart = cb_villeDep.Text;
            ov.VilleArrivee = cb_villeArr.Text;
            ov.NbrVoyageur = int.Parse(txt_nbrVoy.Text);
            ov.PrixBillet = int.Parse(txt_PrixBillet.Text);
        }

        private void bt_premier_Click(object sender, EventArgs e)
        {
            if (cb_numero.Items.Count > 0) cb_numero.SelectedIndex = 0;
        }

        private void bt_precedent_Click(object sender, EventArgs e)
        {
            if (cb_numero.SelectedIndex > 0) cb_numero.SelectedIndex--;
            else MessageBox.Show("Vous êtes sur le premier Vol !");
        }

        private void bt_suivant_Click(object sender, EventArgs e)
        {
            if (cb_numero.SelectedIndex < DeclarationsGlobales.vols.Count - 1) cb_numero.SelectedIndex++;
            else MessageBox.Show("Vous êtes sur le dernier Vol !");
        }

        private void bt_dernier_Click(object sender, EventArgs e)
        {
            if (cb_numero.Items.Count > 0) cb_numero.SelectedIndex = DeclarationsGlobales.vols.Count - 1;
        }

        private void cb_numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            ov = DeclarationsGlobales.vols[cb_numero.SelectedIndex];
            cb_pilote.SelectedItem = ov.Vpilote.Nom;
            cb_avion.SelectedItem = ov.Vavion.Numero.ToString() + " " + ov.Vavion.Marque.ToString() + " " + ov.Vavion.Type.ToString();
            dateVol.Value = ov.DateVol;
            cb_villeDep.Text = ov.VilleDepart;
            cb_villeArr.Text = ov.VilleArrivee;
            txt_nbrVoy.Text = ov.NbrVoyageur.ToString();
            txt_PrixBillet.Text = ov.PrixBillet.ToString();
        }
    }
}
