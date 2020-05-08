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
    public partial class ConsulterPilote : Form
    {
        public ConsulterPilote()
        {
            InitializeComponent();
        }

        private void ConsulterPilote_Load(object sender, EventArgs e)
        {
            foreach (Pilote p in DeclarationsGlobales.pilotes)
                dgvPilote.Rows.Add(p.Matricule, p.Nom, p.Prenom);

        }

        private void dgvPilote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPilote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPilote.CurrentRow != null)
            {
                dgvVol.Rows.Clear();
                foreach (Vol v in DeclarationsGlobales.vols)
                {
                    if (v.Vpilote.Matricule == int.Parse(dgvPilote.CurrentRow.Cells[0].Value.ToString()))
                        dgvVol.Rows.Add(v.Numero, v.DateVol, v.VilleDepart, v.VilleArrivee, v.Vavion.Numero + " " + v.Vavion.Marque + " " + v.Vavion.Type); ;
                }
            }
        }
    }
}
