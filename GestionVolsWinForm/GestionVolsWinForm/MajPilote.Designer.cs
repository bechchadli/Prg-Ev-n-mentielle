namespace GestionVolsWinForm
{
    partial class MajPilote
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
            this.cb_nom = new System.Windows.Forms.ComboBox();
            this.txt_matricule = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.bt_premier = new System.Windows.Forms.Button();
            this.bt_precedent = new System.Windows.Forms.Button();
            this.bt_suivant = new System.Windows.Forms.Button();
            this.bt_dernier = new System.Windows.Forms.Button();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_nom
            // 
            this.cb_nom.FormattingEnabled = true;
            this.cb_nom.Location = new System.Drawing.Point(142, 124);
            this.cb_nom.Name = "cb_nom";
            this.cb_nom.Size = new System.Drawing.Size(121, 21);
            this.cb_nom.TabIndex = 29;
            this.cb_nom.SelectedIndexChanged += new System.EventHandler(this.cb_nom_SelectedIndexChanged);
            // 
            // txt_matricule
            // 
            this.txt_matricule.Location = new System.Drawing.Point(142, 91);
            this.txt_matricule.Name = "txt_matricule";
            this.txt_matricule.Size = new System.Drawing.Size(100, 20);
            this.txt_matricule.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nom";
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(142, 156);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(100, 20);
            this.txt_prenom.TabIndex = 24;
            // 
            // bt_premier
            // 
            this.bt_premier.Location = new System.Drawing.Point(82, 259);
            this.bt_premier.Name = "bt_premier";
            this.bt_premier.Size = new System.Drawing.Size(34, 23);
            this.bt_premier.TabIndex = 37;
            this.bt_premier.Text = "|<";
            this.bt_premier.UseVisualStyleBackColor = true;
            this.bt_premier.Click += new System.EventHandler(this.bt_premier_Click);
            // 
            // bt_precedent
            // 
            this.bt_precedent.Location = new System.Drawing.Point(122, 259);
            this.bt_precedent.Name = "bt_precedent";
            this.bt_precedent.Size = new System.Drawing.Size(35, 23);
            this.bt_precedent.TabIndex = 36;
            this.bt_precedent.Text = "<";
            this.bt_precedent.UseVisualStyleBackColor = true;
            this.bt_precedent.Click += new System.EventHandler(this.bt_precedent_Click);
            // 
            // bt_suivant
            // 
            this.bt_suivant.Location = new System.Drawing.Point(218, 259);
            this.bt_suivant.Name = "bt_suivant";
            this.bt_suivant.Size = new System.Drawing.Size(35, 23);
            this.bt_suivant.TabIndex = 35;
            this.bt_suivant.Text = ">";
            this.bt_suivant.UseVisualStyleBackColor = true;
            this.bt_suivant.Click += new System.EventHandler(this.bt_suivant_Click);
            // 
            // bt_dernier
            // 
            this.bt_dernier.Location = new System.Drawing.Point(259, 259);
            this.bt_dernier.Name = "bt_dernier";
            this.bt_dernier.Size = new System.Drawing.Size(34, 23);
            this.bt_dernier.TabIndex = 34;
            this.bt_dernier.Text = ">|";
            this.bt_dernier.UseVisualStyleBackColor = true;
            this.bt_dernier.Click += new System.EventHandler(this.bt_dernier_Click);
            // 
            // bt_modifier
            // 
            this.bt_modifier.Location = new System.Drawing.Point(35, 230);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(70, 23);
            this.bt_modifier.TabIndex = 32;
            this.bt_modifier.Text = "Modifier";
            this.bt_modifier.UseVisualStyleBackColor = true;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.Location = new System.Drawing.Point(111, 230);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(70, 23);
            this.bt_supprimer.TabIndex = 31;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = true;
            this.bt_supprimer.Click += new System.EventHandler(this.bt_supprimer_Click);
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(187, 230);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(70, 23);
            this.bt_annuler.TabIndex = 30;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(138, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "MAJ  Pilote";
            // 
            // bt_quitter
            // 
            this.bt_quitter.Location = new System.Drawing.Point(263, 230);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(70, 23);
            this.bt_quitter.TabIndex = 39;
            this.bt_quitter.Text = "Quitter";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // MajPilote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 308);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_premier);
            this.Controls.Add(this.bt_precedent);
            this.Controls.Add(this.bt_suivant);
            this.Controls.Add(this.bt_dernier);
            this.Controls.Add(this.bt_modifier);
            this.Controls.Add(this.bt_supprimer);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.cb_nom);
            this.Controls.Add(this.txt_matricule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_prenom);
            this.Name = "MajPilote";
            this.Text = "MajPilote";
            this.Load += new System.EventHandler(this.MajPilote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_nom;
        private System.Windows.Forms.TextBox txt_matricule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Button bt_premier;
        private System.Windows.Forms.Button bt_precedent;
        private System.Windows.Forms.Button bt_suivant;
        private System.Windows.Forms.Button bt_dernier;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_quitter;
    }
}