namespace AppWF1
{
    partial class FAjouterEtudiant
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_pre = new System.Windows.Forms.TextBox();
            this.bt_valider = new System.Windows.Forms.Button();
            this.bt_rech = new System.Windows.Forms.Button();
            this.rb_num = new System.Windows.Forms.RadioButton();
            this.rb_nom = new System.Windows.Forms.RadioButton();
            this.rb_femme = new System.Windows.Forms.RadioButton();
            this.rb_homme = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ch_master = new System.Windows.Forms.CheckBox();
            this.ch_licence = new System.Windows.Forms.CheckBox();
            this.ch_bac = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(162, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter des Etudiants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prenom :";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(133, 80);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 4;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(133, 129);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 5;
            // 
            // txt_pre
            // 
            this.txt_pre.Location = new System.Drawing.Point(133, 171);
            this.txt_pre.Name = "txt_pre";
            this.txt_pre.Size = new System.Drawing.Size(100, 20);
            this.txt_pre.TabIndex = 6;
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(288, 80);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(75, 26);
            this.bt_valider.TabIndex = 7;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // bt_rech
            // 
            this.bt_rech.Location = new System.Drawing.Point(288, 126);
            this.bt_rech.Name = "bt_rech";
            this.bt_rech.Size = new System.Drawing.Size(75, 23);
            this.bt_rech.TabIndex = 8;
            this.bt_rech.Text = "Rechercher";
            this.bt_rech.UseVisualStyleBackColor = true;
            this.bt_rech.Click += new System.EventHandler(this.bt_rech_Click);
            // 
            // rb_num
            // 
            this.rb_num.AutoSize = true;
            this.rb_num.Checked = true;
            this.rb_num.Location = new System.Drawing.Point(17, 19);
            this.rb_num.Name = "rb_num";
            this.rb_num.Size = new System.Drawing.Size(62, 17);
            this.rb_num.TabIndex = 9;
            this.rb_num.TabStop = true;
            this.rb_num.Text = "Numero";
            this.rb_num.UseVisualStyleBackColor = true;
            // 
            // rb_nom
            // 
            this.rb_nom.AutoSize = true;
            this.rb_nom.Location = new System.Drawing.Point(17, 42);
            this.rb_nom.Name = "rb_nom";
            this.rb_nom.Size = new System.Drawing.Size(47, 17);
            this.rb_nom.TabIndex = 10;
            this.rb_nom.Text = "Nom";
            this.rb_nom.UseVisualStyleBackColor = true;
            // 
            // rb_femme
            // 
            this.rb_femme.AutoSize = true;
            this.rb_femme.Location = new System.Drawing.Point(6, 39);
            this.rb_femme.Name = "rb_femme";
            this.rb_femme.Size = new System.Drawing.Size(59, 17);
            this.rb_femme.TabIndex = 11;
            this.rb_femme.Text = "Femme";
            this.rb_femme.UseVisualStyleBackColor = true;
            // 
            // rb_homme
            // 
            this.rb_homme.AutoSize = true;
            this.rb_homme.Checked = true;
            this.rb_homme.Location = new System.Drawing.Point(6, 22);
            this.rb_homme.Name = "rb_homme";
            this.rb_homme.Size = new System.Drawing.Size(61, 17);
            this.rb_homme.TabIndex = 12;
            this.rb_homme.TabStop = true;
            this.rb_homme.Text = "Homme";
            this.rb_homme.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_nom);
            this.groupBox1.Controls.Add(this.rb_num);
            this.groupBox1.Location = new System.Drawing.Point(288, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 77);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher Par";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_homme);
            this.groupBox2.Controls.Add(this.rb_femme);
            this.groupBox2.Location = new System.Drawing.Point(133, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(94, 67);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ch_master);
            this.groupBox3.Controls.Add(this.ch_licence);
            this.groupBox3.Controls.Add(this.ch_bac);
            this.groupBox3.Location = new System.Drawing.Point(77, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 92);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Diplômes :";
            // 
            // ch_master
            // 
            this.ch_master.AutoSize = true;
            this.ch_master.Location = new System.Drawing.Point(23, 65);
            this.ch_master.Name = "ch_master";
            this.ch_master.Size = new System.Drawing.Size(58, 17);
            this.ch_master.TabIndex = 18;
            this.ch_master.Text = "Master";
            this.ch_master.UseVisualStyleBackColor = true;
            // 
            // ch_licence
            // 
            this.ch_licence.AutoSize = true;
            this.ch_licence.Location = new System.Drawing.Point(23, 42);
            this.ch_licence.Name = "ch_licence";
            this.ch_licence.Size = new System.Drawing.Size(64, 17);
            this.ch_licence.TabIndex = 19;
            this.ch_licence.Text = "Licence";
            this.ch_licence.UseVisualStyleBackColor = true;
            // 
            // ch_bac
            // 
            this.ch_bac.AutoSize = true;
            this.ch_bac.Location = new System.Drawing.Point(23, 19);
            this.ch_bac.Name = "ch_bac";
            this.ch_bac.Size = new System.Drawing.Size(45, 17);
            this.ch_bac.TabIndex = 20;
            this.ch_bac.Text = "Bac";
            this.ch_bac.UseVisualStyleBackColor = true;
            // 
            // FAjouterEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 403);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_rech);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.txt_pre);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAjouterEtudiant";
            this.Text = "Gestion des Etudiants";
            this.Load += new System.EventHandler(this.FAjouterEtudiant_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_pre;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Button bt_rech;
        private System.Windows.Forms.RadioButton rb_num;
        private System.Windows.Forms.RadioButton rb_nom;
        private System.Windows.Forms.RadioButton rb_femme;
        private System.Windows.Forms.RadioButton rb_homme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ch_master;
        private System.Windows.Forms.CheckBox ch_licence;
        private System.Windows.Forms.CheckBox ch_bac;
    }
}

