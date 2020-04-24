using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionExe1DGV
{
    public partial class Form1 : Form
    {
        private List<Etudiant> etudiants;
        private BinaryFormatter bf = new BinaryFormatter();
        Etudiant et;

        public Form1()
        {
            InitializeComponent();
        }

        private void serialiser_tous()
        {
            FileStream fichier1 = new FileStream("Monfichier.dat", FileMode.Create, FileAccess.Write);
            bf.Serialize(fichier1, etudiants);
            fichier1.Close();
        }
        private void deserialiser_tous()
        {
            try
            {
                FileStream fichier = new FileStream("Monfichier.dat", FileMode.Open, FileAccess.Read);
                etudiants = (List<Etudiant>)bf.Deserialize(fichier);
                fichier.Close();

                foreach(Etudiant e in etudiants)
                {
                    DGV.Rows.Add(e.Num, e.Nom, e.Prenom, e.Sexe, e.Filiere, e.Age);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Impoossible d'ouvrir le Fichier");
                etudiants = new List<Etudiant>();
                
            }

        }

        private void creerDGV(DataGridView dgvParm)
        {
            dgvParm.ColumnCount = 6;

            DataGridViewColumn dc = dgvParm.Columns[0];
            dc.Name = "Num";
            dc.HeaderText = "Numero";
            dc.ReadOnly = true;

            dc = dgvParm.Columns[1];
            dc.Name = "Nom";
            dc.HeaderText = "Nom";
            dc.ReadOnly = true;

            dc = dgvParm.Columns[2];
            dc.Name = "Prenom";
            dc.HeaderText = "Prenom";
            dc.ReadOnly = true;

            dc = dgvParm.Columns[3];
            dc.Name = "Sexe";
            dc.HeaderText = "Sexe";
            dc.ReadOnly = true;

            dc = dgvParm.Columns[4];
            dc.Name = "Filiere";
            dc.HeaderText = "Filière";
            dc.ReadOnly = true;

            dc = dgvParm.Columns[5];
            dc.Name = "Age";
            dc.HeaderText = "Age";
            dc.ReadOnly = true;            
        }

        private void vider()
        {
            txt_nom.Clear();
            txt_num.Clear();
            txt_pre.Clear();
            txt_age.Clear();
            cb_sexe.Text = "";
            rb_tdi.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            creerDGV(DGV);

            DataGridViewCheckBoxColumn dgvck = new DataGridViewCheckBoxColumn();
            DGV.Name = "Choix";
            dgvck.HeaderText = "Selectionner";
            DGV.Columns.Add(dgvck);

            creerDGV(DGV_restaurer);

            cb_sexe.Items.Add("Femme");
            cb_sexe.Items.Add("Homme");

            deserialiser_tous();
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            string filiere;
            if (rb_tdi.Checked) filiere = "TDI";
            else if (rb_tri.Checked) filiere = "TRI";
            else filiere = "TDM";

            et = new Etudiant(int.Parse(txt_num.Text), txt_nom.Text, txt_pre.Text, cb_sexe.Text, filiere, int.Parse(txt_age.Text));
            etudiants.Add(et);

            DGV.Rows.Add(txt_num.Text, txt_nom.Text, txt_pre.Text, cb_sexe.Text, filiere, txt_age.Text);
            
            vider();
        }

        private void bt_fermer_Click(object sender, EventArgs e)
        {          
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Fermeture de l'application");
            serialiser_tous();
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rep = MessageBox.Show("Etes vous sur de vouloir supprimer ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rep == DialogResult.Yes)
                {
                    etudiants.RemoveAt(DGV.CurrentRow.Index);
                    DGV.Rows.Remove(DGV.CurrentRow);
                }   
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Aucune ligne n'est selectionnée !!!!!");
            }
            
        }

        private void bt_afficher_Click(object sender, EventArgs e)
        {
            try
            {
                txt_num.Text = DGV.CurrentRow.Cells[0].Value.ToString();
                txt_nom.Text = DGV.CurrentRow.Cells[1].Value.ToString();
                txt_pre.Text = DGV.CurrentRow.Cells[2].Value.ToString();
                txt_age.Text = DGV.CurrentRow.Cells[5].Value.ToString();
                cb_sexe.Text = DGV.CurrentRow.Cells[3].Value.ToString();
                switch(DGV.CurrentRow.Cells[4].Value.ToString())
                {
                    case "TDI":
                        rb_tdi.Checked = true;
                        break;
                    case "TRI":
                        rb_tri.Checked = true;
                        break;
                    case "TSGE":
                        rb_tsge.Checked = true;
                        break;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Aucune ligne n'est selectionnée !!!!!");
            }
        }

        private void bt_vider_Click(object sender, EventArgs e)
        {
            vider();
        }

        private void bt_rech_Click(object sender, EventArgs e)
        {
            if (txt_num.Text.Equals("")) MessageBox.Show("Il faut saisir un num !!!!");
            else
            {
                et = null;
                foreach (Etudiant oe in etudiants)
                {
                    if (int.Parse(txt_num.Text) == oe.Num) { et = oe; break; }
                }
                if (et == null) MessageBox.Show("Cet etudiant n'existe pas !!!");
                else
                {
                    //txt_num.Text = et.Num.ToString();
                    txt_nom.Text = et.Nom;
                    txt_pre.Text = et.Prenom;
                    txt_age.Text = et.Age.ToString();
                    cb_sexe.Text = et.Sexe;
                    switch (et.Filiere)
                    {
                        case "TDI":
                            rb_tdi.Checked = true;
                            break;
                        case "TRI":
                            rb_tri.Checked = true;
                            break;
                        case "TSGE":
                            rb_tsge.Checked = true;
                            break;
                    }
                    //Ajouter le code pour selectionner la ligne ds le DGV                  
                    DGV.CurrentCell = DGV.Rows[etudiants.IndexOf(et)].Cells[0];
                    
                }
            }
        }

        private void enregstrer_txt()
        {
            StreamWriter op = new StreamWriter("Fichier.txt");
            foreach (DataGridViewRow ob in DGV.Rows)
            {
                if(bool.Parse(ob.Cells[6].FormattedValue.ToString()) == true)
                {
                    string line = ob.Cells[0].Value + ";" + ob.Cells[1].Value + ";" + ob.Cells[2].Value + ";" + ob.Cells[3].Value + ";" + ob.Cells[4].Value + ";" + ob.Cells[5].Value;
                    op.WriteLine(line);
                }                
            }
            op.Close();
        }
        private void serialiser()
        {
            List<Etudiant> maliste = new List<Etudiant>();

            foreach (DataGridViewRow ob in DGV.Rows)
            {
                if (bool.Parse(ob.Cells[6].FormattedValue.ToString()) == true)
                {
                    et = new Etudiant(int.Parse(ob.Cells[0].Value.ToString()), ob.Cells[1].Value.ToString(), ob.Cells[2].Value.ToString(), ob.Cells[3].Value.ToString(), ob.Cells[4].Value.ToString(), int.Parse(ob.Cells[5].Value.ToString()));
                    maliste.Add(et);
                }
            }

            FileStream fichier1 = new FileStream("Monfichier2.dat", FileMode.Create, FileAccess.Write);
            bf.Serialize(fichier1, maliste);
            fichier1.Close();
        }
        private void bt_sauvg_Click(object sender, EventArgs e)
        {
            if (rb_txt.Checked)
            {
                enregstrer_txt();
            }
            else
            {
                serialiser();
            }
        }
        private void restaurer_txt()
        {
            StreamReader sr = new StreamReader("Fichier.txt");
            string s;

            while ((s = sr.ReadLine()) != null)
            {
                string[] chaine = s.Split(';');
                DGV_restaurer.Rows.Add(chaine[0].ToString(), chaine[1].ToString(), chaine[2].ToString(), chaine[3].ToString(), chaine[4].ToString(), chaine[5].ToString());
            }
            sr.Close();
        }

        private void deserialiser()
        {
            try
            {
                List<Etudiant> maliste;

                FileStream fichier = new FileStream("Monfichier2.dat", FileMode.Open, FileAccess.Read);
                maliste = (List<Etudiant>)bf.Deserialize(fichier);
                fichier.Close();

                foreach (Etudiant e in maliste)
                {
                    DGV_restaurer.Rows.Add(e.Num, e.Nom, e.Prenom, e.Sexe, e.Filiere, e.Age);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Impoossible d'ouvrir le Fichier");
            }

        }
        
        
        private void bt_restaurer_Click(object sender, EventArgs e)
        {
            DGV_restaurer.Rows.Clear();

            if (rb_txt.Checked)
            {
                restaurer_txt();
            }
            else
            {
                deserialiser();
            }
        }
    }
}
