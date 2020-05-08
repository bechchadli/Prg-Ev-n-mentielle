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
    public partial class ConsulterAvion : Form
    {
        public ConsulterAvion()
        {
            InitializeComponent();
        }

        private void ConsulterAvion_Load(object sender, EventArgs e)
        {
            treeViewAvion.Nodes.Add("AirBus");
            treeViewAvion.Nodes.Add("Boeing");
            treeViewAvion.Nodes.Add("Antonov");

            treeViewAvion.Nodes[0].Nodes.Add("A310");
            treeViewAvion.Nodes[0].Nodes.Add("A320");
            treeViewAvion.Nodes[0].Nodes.Add("A330");

            treeViewAvion.Nodes[1].Nodes.Add("737");
            treeViewAvion.Nodes[1].Nodes.Add("747");
            treeViewAvion.Nodes[1].Nodes.Add("757");

            treeViewAvion.Nodes[2].Nodes.Add("AN24");
            treeViewAvion.Nodes[2].Nodes.Add("1N26");
            treeViewAvion.Nodes[2].Nodes.Add("AN36");
        }
    }
}
