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
    public partial class ConsulterVol : Form
    {
        public ConsulterVol()
        {
            InitializeComponent();
        }

        private void ConsulterVol_Load(object sender, EventArgs e)
        {
            int p;
            foreach(Vol v in DeclarationsGlobales.vols)
            {
                treeViewVols.Nodes.Add(v.Numero.ToString());
                p = DeclarationsGlobales.vols.IndexOf(v);
                treeViewVols.Nodes[p].Nodes.Add(v.Vpilote.Nom);
                treeViewVols.Nodes[p].Nodes.Add(v.Vavion.ToString());
                treeViewVols.Nodes[p].Nodes.Add(v.DateVol.ToString());
                treeViewVols.Nodes[p].Nodes.Add(v.VilleDepart);
                treeViewVols.Nodes[p].Nodes.Add(v.VilleArrivee);
                //treeViewVols.Nodes[p].Nodes.Add(v.NbrVoyageur.ToString());
                //treeViewVols.Nodes[p].Nodes.Add(v.PrixBillet.ToString());
            }
                
        }

        private void treeViewVols_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Pilote op;
            Avion ov;
            if (treeViewVols.SelectedNode.Level == 1)
            {
                if(treeViewVols.SelectedNode.Index == 0)
                {
                    tabControl1.SelectedIndex = 0;
                    op = DeclarationsGlobales.vols[treeViewVols.SelectedNode.Parent.Index].Vpilote;
                    lb_matricule.Text = op.Matricule.ToString();
                    lb_nom.Text = op.Nom;
                    lb_prenom.Text = op.Prenom;
                }
                else if (treeViewVols.SelectedNode.Index == 1)
                {
                    tabControl1.SelectedIndex = 1;
                    ov = DeclarationsGlobales.vols[treeViewVols.SelectedNode.Parent.Index].Vavion;
                    lb_numero.Text = ov.Numero.ToString();
                    lb_marque.Text = ov.Marque;
                    lb_type.Text = ov.Type;
                    lb_capacite.Text = ov.Capacite.ToString();
                }
                else
                {
                    lb_matricule.Text = "";
                    lb_nom.Text = "";
                    lb_prenom.Text = "";
                    lb_numero.Text = "";
                    lb_marque.Text = "";
                    lb_type.Text = "";
                    lb_capacite.Text = "";
                }
            }
            
               
        }
    }
}
