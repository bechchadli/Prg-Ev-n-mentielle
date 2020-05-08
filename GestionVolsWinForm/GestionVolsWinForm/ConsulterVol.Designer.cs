namespace GestionVolsWinForm
{
    partial class ConsulterVol
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
            this.treeViewVols = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePilote = new System.Windows.Forms.TabPage();
            this.tabPageAvion = new System.Windows.Forms.TabPage();
            this.lb_matricule = new System.Windows.Forms.Label();
            this.lb_nom = new System.Windows.Forms.Label();
            this.lb_prenom = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_marque = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_capacite = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPagePilote.SuspendLayout();
            this.tabPageAvion.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewVols
            // 
            this.treeViewVols.Location = new System.Drawing.Point(3, 24);
            this.treeViewVols.Name = "treeViewVols";
            this.treeViewVols.Size = new System.Drawing.Size(143, 346);
            this.treeViewVols.TabIndex = 0;
            this.treeViewVols.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewVols_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste Des Vols";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Matricule :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prenom :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePilote);
            this.tabControl1.Controls.Add(this.tabPageAvion);
            this.tabControl1.Location = new System.Drawing.Point(175, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(272, 175);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPagePilote
            // 
            this.tabPagePilote.Controls.Add(this.lb_prenom);
            this.tabPagePilote.Controls.Add(this.lb_nom);
            this.tabPagePilote.Controls.Add(this.lb_matricule);
            this.tabPagePilote.Controls.Add(this.label4);
            this.tabPagePilote.Controls.Add(this.label3);
            this.tabPagePilote.Controls.Add(this.label2);
            this.tabPagePilote.Location = new System.Drawing.Point(4, 22);
            this.tabPagePilote.Name = "tabPagePilote";
            this.tabPagePilote.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePilote.Size = new System.Drawing.Size(264, 149);
            this.tabPagePilote.TabIndex = 0;
            this.tabPagePilote.Text = "Infos Pilote";
            this.tabPagePilote.UseVisualStyleBackColor = true;
            // 
            // tabPageAvion
            // 
            this.tabPageAvion.Controls.Add(this.lb_capacite);
            this.tabPageAvion.Controls.Add(this.label11);
            this.tabPageAvion.Controls.Add(this.lb_type);
            this.tabPageAvion.Controls.Add(this.lb_marque);
            this.tabPageAvion.Controls.Add(this.lb_numero);
            this.tabPageAvion.Controls.Add(this.label8);
            this.tabPageAvion.Controls.Add(this.label9);
            this.tabPageAvion.Controls.Add(this.label10);
            this.tabPageAvion.Location = new System.Drawing.Point(4, 22);
            this.tabPageAvion.Name = "tabPageAvion";
            this.tabPageAvion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAvion.Size = new System.Drawing.Size(264, 149);
            this.tabPageAvion.TabIndex = 1;
            this.tabPageAvion.Text = "Infos Avion";
            this.tabPageAvion.UseVisualStyleBackColor = true;
            // 
            // lb_matricule
            // 
            this.lb_matricule.AutoSize = true;
            this.lb_matricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matricule.ForeColor = System.Drawing.Color.Maroon;
            this.lb_matricule.Location = new System.Drawing.Point(119, 40);
            this.lb_matricule.Name = "lb_matricule";
            this.lb_matricule.Size = new System.Drawing.Size(0, 16);
            this.lb_matricule.TabIndex = 17;
            // 
            // lb_nom
            // 
            this.lb_nom.AutoSize = true;
            this.lb_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nom.ForeColor = System.Drawing.Color.Maroon;
            this.lb_nom.Location = new System.Drawing.Point(119, 66);
            this.lb_nom.Name = "lb_nom";
            this.lb_nom.Size = new System.Drawing.Size(0, 16);
            this.lb_nom.TabIndex = 18;
            // 
            // lb_prenom
            // 
            this.lb_prenom.AutoSize = true;
            this.lb_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prenom.ForeColor = System.Drawing.Color.Maroon;
            this.lb_prenom.Location = new System.Drawing.Point(119, 92);
            this.lb_prenom.Name = "lb_prenom";
            this.lb_prenom.Size = new System.Drawing.Size(0, 16);
            this.lb_prenom.TabIndex = 19;
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_type.ForeColor = System.Drawing.Color.Maroon;
            this.lb_type.Location = new System.Drawing.Point(119, 88);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(0, 16);
            this.lb_type.TabIndex = 25;
            // 
            // lb_marque
            // 
            this.lb_marque.AutoSize = true;
            this.lb_marque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_marque.ForeColor = System.Drawing.Color.Maroon;
            this.lb_marque.Location = new System.Drawing.Point(119, 62);
            this.lb_marque.Name = "lb_marque";
            this.lb_marque.Size = new System.Drawing.Size(0, 16);
            this.lb_marque.TabIndex = 24;
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero.ForeColor = System.Drawing.Color.Maroon;
            this.lb_numero.Location = new System.Drawing.Point(119, 36);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(0, 16);
            this.lb_numero.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Numero :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Marque :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Type :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Capacité :";
            // 
            // lb_capacite
            // 
            this.lb_capacite.AutoSize = true;
            this.lb_capacite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_capacite.ForeColor = System.Drawing.Color.Maroon;
            this.lb_capacite.Location = new System.Drawing.Point(130, 116);
            this.lb_capacite.Name = "lb_capacite";
            this.lb_capacite.Size = new System.Drawing.Size(0, 16);
            this.lb_capacite.TabIndex = 27;
            // 
            // ConsulterVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 371);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewVols);
            this.Name = "ConsulterVol";
            this.Text = "ConsulterVol";
            this.Load += new System.EventHandler(this.ConsulterVol_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePilote.ResumeLayout(false);
            this.tabPagePilote.PerformLayout();
            this.tabPageAvion.ResumeLayout(false);
            this.tabPageAvion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewVols;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePilote;
        private System.Windows.Forms.Label lb_prenom;
        private System.Windows.Forms.Label lb_nom;
        private System.Windows.Forms.Label lb_matricule;
        private System.Windows.Forms.TabPage tabPageAvion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_marque;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_capacite;
    }
}