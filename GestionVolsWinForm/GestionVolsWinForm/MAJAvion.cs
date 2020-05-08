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
    public partial class MAJAvion : Form
    {
        Avion oa;
        public MAJAvion()
        {
            InitializeComponent();
        }

        private void MAJAvion_Load(object sender, EventArgs e)
        {
            foreach (Avion oa in DeclarationsGlobales.avions)
                cb_numero.Items.Add(oa.Numero);

            if (cb_numero.Items.Count > 0) cb_numero.SelectedIndex = 0;
        }

        private void cb_numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            oa = DeclarationsGlobales.avions[cb_numero.SelectedIndex];
            cb_marque.Text = oa.Marque.ToString();

            cb_type.Items.Clear();
            cb_type.Text = "";
            switch (cb_marque.SelectedIndex)
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
            cb_type.Text = oa.Type.ToString();
            txt_capacite.Text = oa.Capacite.ToString();
        }

        private void bt_annuler_Click(object sender, EventArgs e)
        {
            DeclarationsGlobales.viderTextBox(this);
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Etes vous sur de vouloir supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rep == DialogResult.Yes)
            {
                DeclarationsGlobales.avions.Remove(oa);

                int i = cb_numero.SelectedIndex;
                cb_numero.Items.RemoveAt(cb_numero.SelectedIndex);

                if (i > 0) cb_numero.SelectedIndex = --i;
                else DeclarationsGlobales.viderTextBox(this);
            }
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            
            oa.Numero = int.Parse(cb_numero.Text);
            oa.Marque = cb_marque.Text;
            oa.Type = cb_type.Text;
            oa.Capacite = int.Parse(txt_capacite.Text);

            cb_numero.Items[DeclarationsGlobales.avions.IndexOf(oa)] = cb_numero.Text;
        }

        private void bt_premier_Click(object sender, EventArgs e)
        {
            if (cb_numero.Items.Count > 0) cb_numero.SelectedIndex = 0;
        }

        private void bt_precedent_Click(object sender, EventArgs e)
        {
            if (cb_numero.SelectedIndex > 0) cb_numero.SelectedIndex--;
            else MessageBox.Show("Vous êtes sur le premier Avion !");
        }

        private void bt_suivant_Click(object sender, EventArgs e)
        {
            if (cb_numero.SelectedIndex < DeclarationsGlobales.avions.Count - 1) cb_numero.SelectedIndex++;
            else MessageBox.Show("Vous êtes sur le dernier Avion !");
        }

        private void bt_dernier_Click(object sender, EventArgs e)
        {
            if (cb_numero.Items.Count > 0) cb_numero.SelectedIndex = DeclarationsGlobales.avions.Count - 1;
        }

        private void cb_marque_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_type.Items.Clear();
            cb_type.Text = "";
            switch (cb_marque.SelectedIndex)
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
    }
}
