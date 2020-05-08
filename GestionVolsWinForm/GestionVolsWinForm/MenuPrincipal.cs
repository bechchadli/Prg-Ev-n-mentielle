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
    public partial class MenuPrincipal : Form
    {
        //Les Formulaires
        AjouterPilote fAP;
        AjouterAvion fAA;
        AjouterVol fAV;
        MajPilote fMAJP;
        MAJAvion fMAJA;
        MAJVol fMAJV;
        ConsulterAvion fCAv;
        ConsulterPilote fCVP;
        ConsulterVol fCVol;
        ConsulterVolsEntre2dates fCVDate;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            DeclarationsGlobales.deserialiser_tous();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Fermeture de l'application ?","Quitter",MessageBoxButtons.OK,MessageBoxIcon.Information);
            DeclarationsGlobales.serialiser_tous();
        }

        private void changerForm(Form fenfant)
        {
            foreach (Form f in this.MdiChildren)
                f.Hide();

            fenfant.MdiParent = this;
            fenfant.Dock = DockStyle.Fill;
            fenfant.Show();
        }
        private void ajouterPiloteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (fAP == null) fAP = new AjouterPilote();
            else if (fAP.IsDisposed) fAP = new AjouterPilote();
            changerForm(fAP);
            //foreach (Form f in this.MdiChildren)
            //    f.Hide();
            //fAP.MdiParent = this;
            //fAP.Dock = DockStyle.Fill;
            //fAP.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouterAvionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fAA == null) fAA = new AjouterAvion();
            else if (fAA.IsDisposed) fAA = new AjouterAvion();
            changerForm(fAA);
        }

        private void ajouterVolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fAV == null) fAV = new AjouterVol();
            else if (fAV.IsDisposed) fAV = new AjouterVol();
            changerForm(fAV);
        }

        private void mAJPiloteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fMAJP == null) fMAJP = new MajPilote();
            else if (fMAJP.IsDisposed) fMAJP = new MajPilote();
            changerForm(fMAJP);
        }

        private void mAJAvionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fMAJA == null) fMAJA = new MAJAvion();
            else if (fMAJA.IsDisposed) fMAJA = new MAJAvion();
            changerForm(fMAJA);
        }

        private void mAJVolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fMAJV == null) fMAJV = new MAJVol();
            else if (fMAJV.IsDisposed) fMAJV = new MAJVol();
            changerForm(fMAJV);
        }

        private void consulterVolsPiloteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCVP == null) fCVP = new ConsulterPilote();
            else if (fCVP.IsDisposed) fCVP = new ConsulterPilote();
            changerForm(fCVP);
            
        }

        private void consulterAvionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCAv == null) fCAv = new ConsulterAvion();
            else if (fCAv.IsDisposed) fCAv = new ConsulterAvion();
            changerForm(fCAv);
            
        }

        private void consulterVolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCVol == null) fCVol = new ConsulterVol();
            else if (fCVol.IsDisposed) fCVol = new ConsulterVol();
            changerForm(fCVol);
            
        }

        private void consulterEntreDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fCVDate == null) fCVDate = new ConsulterVolsEntre2dates();
            else if (fCVDate.IsDisposed) fCVDate = new ConsulterVolsEntre2dates();
            changerForm(fCVDate);
            
        }
    }
}
