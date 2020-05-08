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
    public partial class ConsulterVolsEntre2dates : Form
    {
        public ConsulterVolsEntre2dates()
        {
            InitializeComponent();
        }

        private void ConsulterVolsEntre2dates_Load(object sender, EventArgs e)
        {
            remplir_tout();
        }
        void remplir_tout()
        {
            dgvVol.Rows.Clear();
            foreach (Vol v in DeclarationsGlobales.vols)
            {
                dgvVol.Rows.Add(v.Numero, v.DateVol, v.VilleDepart, v.VilleArrivee, v.Vavion.ToString(), v.Vpilote.Nom);
            }
        }
        void remplir_date()
        {
            dgvVol.Rows.Clear();
            foreach (Vol v in DeclarationsGlobales.vols)
            {
                if (v.DateVol.Day >= dtpDebut.Value.Day && v.DateVol.Day <= dtpFin.Value.Day)
                    dgvVol.Rows.Add(v.Numero, v.DateVol, v.VilleDepart, v.VilleArrivee, v.Vavion.ToString(), v.Vpilote.Nom);
            }
        }
        private void rb_entreDates_CheckedChanged(object sender, EventArgs e)
        {
            
            if(rb_entreDates.Checked)
            {
                dtpDebut.Enabled = true;
                dtpFin.Enabled = true;
                remplir_date();
            }
            else
            {
                dtpDebut.Enabled = false;
                dtpFin.Enabled = false;
                remplir_tout();
            }
        }

        private void dtpDebut_ValueChanged(object sender, EventArgs e)
        {
             remplir_date();
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            remplir_date();
        }
    }
}
