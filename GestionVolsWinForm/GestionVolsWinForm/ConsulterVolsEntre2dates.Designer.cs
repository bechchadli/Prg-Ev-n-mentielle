namespace GestionVolsWinForm
{
    partial class ConsulterVolsEntre2dates
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
            this.dgvVol = new System.Windows.Forms.DataGridView();
            this.NumVol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateVol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleArr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vavion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pilote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_entreDates = new System.Windows.Forms.RadioButton();
            this.rb_tout = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVol)).BeginInit();
            this.SuspendLayout();
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
            this.Vavion,
            this.pilote});
            this.dgvVol.Location = new System.Drawing.Point(12, 168);
            this.dgvVol.Name = "dgvVol";
            this.dgvVol.ReadOnly = true;
            this.dgvVol.Size = new System.Drawing.Size(646, 142);
            this.dgvVol.TabIndex = 2;
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
            // pilote
            // 
            this.pilote.HeaderText = "Pilote";
            this.pilote.Name = "pilote";
            this.pilote.ReadOnly = true;
            // 
            // dtpFin
            // 
            this.dtpFin.Enabled = false;
            this.dtpFin.Location = new System.Drawing.Point(380, 75);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 3;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // dtpDebut
            // 
            this.dtpDebut.Enabled = false;
            this.dtpDebut.Location = new System.Drawing.Point(380, 39);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDebut.TabIndex = 4;
            this.dtpDebut.ValueChanged += new System.EventHandler(this.dtpDebut_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date début :";
            // 
            // rb_entreDates
            // 
            this.rb_entreDates.AutoSize = true;
            this.rb_entreDates.Location = new System.Drawing.Point(60, 81);
            this.rb_entreDates.Name = "rb_entreDates";
            this.rb_entreDates.Size = new System.Drawing.Size(168, 17);
            this.rb_entreDates.TabIndex = 7;
            this.rb_entreDates.Text = "Afficher Les Vols entre Dates :";
            this.rb_entreDates.UseVisualStyleBackColor = true;
            this.rb_entreDates.CheckedChanged += new System.EventHandler(this.rb_entreDates_CheckedChanged);
            // 
            // rb_tout
            // 
            this.rb_tout.AutoSize = true;
            this.rb_tout.Checked = true;
            this.rb_tout.Location = new System.Drawing.Point(60, 39);
            this.rb_tout.Name = "rb_tout";
            this.rb_tout.Size = new System.Drawing.Size(129, 17);
            this.rb_tout.TabIndex = 8;
            this.rb_tout.TabStop = true;
            this.rb_tout.Text = "Afficher tous les Vols :";
            this.rb_tout.UseVisualStyleBackColor = true;
            // 
            // ConsulterVolsEntre2dates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 322);
            this.Controls.Add(this.rb_tout);
            this.Controls.Add(this.rb_entreDates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dgvVol);
            this.Name = "ConsulterVolsEntre2dates";
            this.Text = "ConsulterVolsEntre2dates";
            this.Load += new System.EventHandler(this.ConsulterVolsEntre2dates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumVol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleArr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vavion;
        private System.Windows.Forms.DataGridViewTextBoxColumn pilote;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_entreDates;
        private System.Windows.Forms.RadioButton rb_tout;
    }
}