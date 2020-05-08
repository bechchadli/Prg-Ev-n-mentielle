namespace GestionVolsWinForm
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pilotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterPiloteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJPiloteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterVolsPiloteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterVolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJVolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterVolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterEntreDatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilotesToolStripMenuItem,
            this.avionsToolStripMenuItem,
            this.volsToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pilotesToolStripMenuItem
            // 
            this.pilotesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterPiloteToolStripMenuItem,
            this.mAJPiloteToolStripMenuItem,
            this.consulterVolsPiloteToolStripMenuItem});
            this.pilotesToolStripMenuItem.Name = "pilotesToolStripMenuItem";
            this.pilotesToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.pilotesToolStripMenuItem.Text = "Pilotes";
            // 
            // ajouterPiloteToolStripMenuItem
            // 
            this.ajouterPiloteToolStripMenuItem.Name = "ajouterPiloteToolStripMenuItem";
            this.ajouterPiloteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ajouterPiloteToolStripMenuItem.Text = "Ajouter Pilote";
            this.ajouterPiloteToolStripMenuItem.Click += new System.EventHandler(this.ajouterPiloteToolStripMenuItem_Click);
            // 
            // mAJPiloteToolStripMenuItem
            // 
            this.mAJPiloteToolStripMenuItem.Name = "mAJPiloteToolStripMenuItem";
            this.mAJPiloteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.mAJPiloteToolStripMenuItem.Text = "MAJ Pilote";
            this.mAJPiloteToolStripMenuItem.Click += new System.EventHandler(this.mAJPiloteToolStripMenuItem_Click);
            // 
            // consulterVolsPiloteToolStripMenuItem
            // 
            this.consulterVolsPiloteToolStripMenuItem.Name = "consulterVolsPiloteToolStripMenuItem";
            this.consulterVolsPiloteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consulterVolsPiloteToolStripMenuItem.Text = "Consulter Vols Pilote";
            this.consulterVolsPiloteToolStripMenuItem.Click += new System.EventHandler(this.consulterVolsPiloteToolStripMenuItem_Click);
            // 
            // avionsToolStripMenuItem
            // 
            this.avionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterAvionToolStripMenuItem,
            this.mAJAvionToolStripMenuItem,
            this.consulterAvionToolStripMenuItem});
            this.avionsToolStripMenuItem.Name = "avionsToolStripMenuItem";
            this.avionsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.avionsToolStripMenuItem.Text = "Avions";
            // 
            // ajouterAvionToolStripMenuItem
            // 
            this.ajouterAvionToolStripMenuItem.Name = "ajouterAvionToolStripMenuItem";
            this.ajouterAvionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ajouterAvionToolStripMenuItem.Text = "Ajouter Avion";
            this.ajouterAvionToolStripMenuItem.Click += new System.EventHandler(this.ajouterAvionToolStripMenuItem_Click);
            // 
            // mAJAvionToolStripMenuItem
            // 
            this.mAJAvionToolStripMenuItem.Name = "mAJAvionToolStripMenuItem";
            this.mAJAvionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.mAJAvionToolStripMenuItem.Text = "MAJ Avion";
            this.mAJAvionToolStripMenuItem.Click += new System.EventHandler(this.mAJAvionToolStripMenuItem_Click);
            // 
            // consulterAvionToolStripMenuItem
            // 
            this.consulterAvionToolStripMenuItem.Name = "consulterAvionToolStripMenuItem";
            this.consulterAvionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.consulterAvionToolStripMenuItem.Text = "Consulter Avion";
            this.consulterAvionToolStripMenuItem.Click += new System.EventHandler(this.consulterAvionToolStripMenuItem_Click);
            // 
            // volsToolStripMenuItem
            // 
            this.volsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterVolToolStripMenuItem,
            this.mAJVolToolStripMenuItem,
            this.consulterVolToolStripMenuItem,
            this.consulterEntreDatesToolStripMenuItem});
            this.volsToolStripMenuItem.Name = "volsToolStripMenuItem";
            this.volsToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.volsToolStripMenuItem.Text = "Vols";
            // 
            // ajouterVolToolStripMenuItem
            // 
            this.ajouterVolToolStripMenuItem.Name = "ajouterVolToolStripMenuItem";
            this.ajouterVolToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ajouterVolToolStripMenuItem.Text = "Ajouter Vol";
            this.ajouterVolToolStripMenuItem.Click += new System.EventHandler(this.ajouterVolToolStripMenuItem_Click);
            // 
            // mAJVolToolStripMenuItem
            // 
            this.mAJVolToolStripMenuItem.Name = "mAJVolToolStripMenuItem";
            this.mAJVolToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.mAJVolToolStripMenuItem.Text = "MAJ Vol";
            this.mAJVolToolStripMenuItem.Click += new System.EventHandler(this.mAJVolToolStripMenuItem_Click);
            // 
            // consulterVolToolStripMenuItem
            // 
            this.consulterVolToolStripMenuItem.Name = "consulterVolToolStripMenuItem";
            this.consulterVolToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.consulterVolToolStripMenuItem.Text = "Consulter Vol";
            this.consulterVolToolStripMenuItem.Click += new System.EventHandler(this.consulterVolToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // consulterEntreDatesToolStripMenuItem
            // 
            this.consulterEntreDatesToolStripMenuItem.Name = "consulterEntreDatesToolStripMenuItem";
            this.consulterEntreDatesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.consulterEntreDatesToolStripMenuItem.Text = "Consulter entre dates";
            this.consulterEntreDatesToolStripMenuItem.Click += new System.EventHandler(this.consulterEntreDatesToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 451);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Des Vols Avec Classes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pilotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterPiloteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterAvionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterVolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJPiloteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJAvionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJVolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterVolsPiloteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterAvionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterVolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterEntreDatesToolStripMenuItem;
    }
}

