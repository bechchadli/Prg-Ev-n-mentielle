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
    public partial class MajPilote : Form
    {
        Pilote op;
        public MajPilote()
        {
            InitializeComponent();
        }

        private void MajPilote_Load(object sender, EventArgs e)
        {
            foreach (Pilote op in DeclarationsGlobales.pilotes)
                cb_nom.Items.Add(op.Nom);

            if (cb_nom.Items.Count > 0) cb_nom.SelectedIndex = 0;
        }

        private void cb_nom_SelectedIndexChanged(object sender, EventArgs e)
        {
            op = DeclarationsGlobales.pilotes[cb_nom.SelectedIndex];
            txt_matricule.Text = op.Matricule.ToString();
            txt_prenom.Text = op.Prenom.ToString();
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            DeclarationsGlobales.viderTextBox(this);
        }

        private void bt_premier_Click(object sender, EventArgs e)
        {
            if (cb_nom.Items.Count > 0) cb_nom.SelectedIndex = 0;
        }

        private void bt_dernier_Click(object sender, EventArgs e)
        {
            if (cb_nom.Items.Count > 0) cb_nom.SelectedIndex = DeclarationsGlobales.pilotes.Count - 1;
        }

        private void bt_precedent_Click(object sender, EventArgs e)
        {
            if (cb_nom.SelectedIndex > 0) cb_nom.SelectedIndex--;
            else MessageBox.Show("Vous êtes sur le premier Pilote !");
        }

        private void bt_suivant_Click(object sender, EventArgs e)
        {
            if (cb_nom.SelectedIndex < DeclarationsGlobales.pilotes.Count - 1) cb_nom.SelectedIndex++;
            else MessageBox.Show("Vous êtes sur le dernier Pilote !");
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            cb_nom.Items[DeclarationsGlobales.pilotes.IndexOf(op)] = cb_nom.Text;//Midification du nom dans la liste des pilotes

            op.Matricule = int.Parse(txt_matricule.Text);
            op.Nom = cb_nom.Text;
            op.Prenom = txt_prenom.Text;
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Etes vous sur de vouloir supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rep == DialogResult.Yes)
            {
                DeclarationsGlobales.pilotes.Remove(op);

                int i = cb_nom.SelectedIndex;
                cb_nom.Items.RemoveAt(cb_nom.SelectedIndex);

                if (i > 0) cb_nom.SelectedIndex = --i;
                else DeclarationsGlobales.viderTextBox(this);
            }
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
