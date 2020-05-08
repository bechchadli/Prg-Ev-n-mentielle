namespace GestionVolsWinForm
{
    partial class ConsulterPilote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPilote = new System.Windows.Forms.DataGridView();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVol = new System.Windows.Forms.DataGridView();
            this.NumVol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateVol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleArr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vavion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVol)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPilote
            // 
            this.dgvPilote.AllowUserToAddRows = false;
            this.dgvPilote.AllowUserToDeleteRows = false;
            this.dgvPilote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPilote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricule,
            this.Nom,
            this.Prenom});
            this.dgvPilote.Location = new System.Drawing.Point(113, 85);
            this.dgvPilote.Name = "dgvPilote";
            this.dgvPilote.ReadOnly = true;
            this.dgvPilote.Size = new System.Drawing.Size(345, 150);
            this.dgvPilote.TabIndex = 0;
            this.dgvPilote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPilote_CellClick);
            this.dgvPilote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPilote_CellContentClick);
            // 
            // Matricule
            // 
            this.Matricule.HeaderText = "Matricule";
            this.Matricule.Name = "Matricule";
            this.Matricule.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // dgvVol
            // 
            this.dgvVol.AllowUserToAddRows = false;
            this.dgvVol.AllowUserToDeleteRows = false;
            this.dgvVol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumVol,
            this.DateVol,
            this.VilleDep,
            this.VilleArr,
            this.Vavion});
            this.dgvVol.Location = new System.Drawing.Point(12, 241);
            this.dgvVol.Name = "dgvVol";
            this.dgvVol.ReadOnly = true;
            this.dgvVol.Size = new System.Drawing.Size(562, 142);
            this.dgvVol.TabIndex = 1;
            // 
            // NumVol
            // 
            this.NumVol.HeaderText = "Num Vol";
            this.NumVol.Name = "NumVol";
            this.NumVol.ReadOnly = true;
            // 
            // DateVol
            // 
            this.DateVol.HeaderText = "Date";
            this.DateVol.Name = "DateVol";
            this.DateVol.ReadOnly = true;
            // 
            // VilleDep
            // 
            this.VilleDep.HeaderText = "Ville Départ";
            this.VilleDep.Name = "VilleDep";
            this.VilleDep.ReadOnly = true;
            // 
            // VilleArr
            // 
            this.VilleArr.HeaderText = "Ville Arrivée";
            this.VilleArr.Name = "VilleArr";
            this.VilleArr.ReadOnly = true;
            // 
            // Vavion
            // 
            this.Vavion.HeaderText = "Avion";
            this.Vavion.Name = "Vavion";
            this.Vavion.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(96, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Consulter Les Infos Pilotes et leurs Vols";
            // 
            // ConsulterPilote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVol);
            this.Controls.Add(this.dgvPilote);
            this.Name = "ConsulterPilote";
            this.Text = "ConsulterPilote";
            this.Load += new System.EventHandler(this.ConsulterPilote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPilote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridView dgvVol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumVol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleArr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vavion;
        private System.Windows.Forms.Label label1;
    }
}