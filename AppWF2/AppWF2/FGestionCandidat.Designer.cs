namespace AppWF2
{
    partial class FGestionCandidat
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
            this.bt_formSuivant = new System.Windows.Forms.Button();
            this.bt_premier = new System.Windows.Forms.Button();
            this.bt_precedent = new System.Windows.Forms.Button();
            this.bt_suivant = new System.Windows.Forms.Button();
            this.bt_dernier = new System.Windows.Forms.Button();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cc_master = new System.Windows.Forms.CheckBox();
            this.cc_licence = new System.Windows.Forms.CheckBox();
            this.cc_bac = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_div = new System.Windows.Forms.RadioButton();
            this.rb_marie = new System.Windows.Forms.RadioButton();
            this.rb_celib = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_formSuivant
            // 
            this.bt_formSuivant.Location = new System.Drawing.Point(236, 245);
            this.bt_formSuivant.Name = "bt_formSuivant";
            this.bt_formSuivant.Size = new System.Drawing.Size(200, 32);
            this.bt_formSuivant.TabIndex = 22;
            this.bt_formSuivant.Text = "Formulaire suivant";
            this.bt_formSuivant.UseVisualStyleBackColor = true;
            this.bt_formSuivant.Click += new System.EventHandler(this.bt_formSuivant_Click);
            // 
            // bt_premier
            // 
            this.bt_premier.Location = new System.Drawing.Point(43, 254);
            this.bt_premier.Name = "bt_premier";
            this.bt_premier.Size = new System.Drawing.Size(34, 23);
            this.bt_premier.TabIndex = 21;
            this.bt_premier.Text = "|<";
            this.bt_premier.UseVisualStyleBackColor = true;
            this.bt_premier.Click += new System.EventHandler(this.bt_premier_Click);
            // 
            // bt_precedent
            // 
            this.bt_precedent.Location = new System.Drawing.Point(83, 254);
            this.bt_precedent.Name = "bt_precedent";
            this.bt_precedent.Size = new System.Drawing.Size(35, 23);
            this.bt_precedent.TabIndex = 20;
            this.bt_precedent.Text = "<";
            this.bt_precedent.UseVisualStyleBackColor = true;
            this.bt_precedent.Click += new System.EventHandler(this.bt_precedent_Click);
            // 
            // bt_suivant
            // 
            this.bt_suivant.Location = new System.Drawing.Point(142, 254);
            this.bt_suivant.Name = "bt_suivant";
            this.bt_suivant.Size = new System.Drawing.Size(35, 23);
            this.bt_suivant.TabIndex = 19;
            this.bt_suivant.Text = ">";
            this.bt_suivant.UseVisualStyleBackColor = true;
            this.bt_suivant.Click += new System.EventHandler(this.bt_suivant_Click);
            // 
            // bt_dernier
            // 
            this.bt_dernier.Location = new System.Drawing.Point(183, 254);
            this.bt_dernier.Name = "bt_dernier";
            this.bt_dernier.Size = new System.Drawing.Size(34, 23);
            this.bt_dernier.TabIndex = 18;
            this.bt_dernier.Text = ">|";
            this.bt_dernier.UseVisualStyleBackColor = true;
            this.bt_dernier.Click += new System.EventHandler(this.bt_dernier_Click);
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.Location = new System.Drawing.Point(30, 200);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(101, 23);
            this.bt_ajouter.TabIndex = 17;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // bt_modifier
            // 
            this.bt_modifier.Location = new System.Drawing.Point(129, 200);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(101, 23);
            this.bt_modifier.TabIndex = 16;
            this.bt_modifier.Text = "Modifier";
            this.bt_modifier.UseVisualStyleBackColor = true;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.Location = new System.Drawing.Point(30, 229);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(101, 23);
            this.bt_supprimer.TabIndex = 15;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = true;
            this.bt_supprimer.Click += new System.EventHandler(this.bt_supprimer_Click);
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(129, 229);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(101, 23);
            this.bt_annuler.TabIndex = 14;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cc_master);
            this.groupBox2.Controls.Add(this.cc_licence);
            this.groupBox2.Controls.Add(this.cc_bac);
            this.groupBox2.Location = new System.Drawing.Point(236, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 107);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diplôme";
            // 
            // cc_master
            // 
            this.cc_master.AutoSize = true;
            this.cc_master.Location = new System.Drawing.Point(29, 74);
            this.cc_master.Name = "cc_master";
            this.cc_master.Size = new System.Drawing.Size(58, 17);
            this.cc_master.TabIndex = 2;
            this.cc_master.Text = "Master";
            this.cc_master.UseVisualStyleBackColor = true;
            // 
            // cc_licence
            // 
            this.cc_licence.AutoSize = true;
            this.cc_licence.Location = new System.Drawing.Point(29, 51);
            this.cc_licence.Name = "cc_licence";
            this.cc_licence.Size = new System.Drawing.Size(64, 17);
            this.cc_licence.TabIndex = 1;
            this.cc_licence.Text = "Licence";
            this.cc_licence.UseVisualStyleBackColor = true;
            // 
            // cc_bac
            // 
            this.cc_bac.AutoSize = true;
            this.cc_bac.Location = new System.Drawing.Point(29, 28);
            this.cc_bac.Name = "cc_bac";
            this.cc_bac.Size = new System.Drawing.Size(45, 17);
            this.cc_bac.TabIndex = 0;
            this.cc_bac.Text = "Bac";
            this.cc_bac.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_div);
            this.groupBox3.Controls.Add(this.rb_marie);
            this.groupBox3.Controls.Add(this.rb_celib);
            this.groupBox3.Location = new System.Drawing.Point(236, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SF";
            // 
            // rb_div
            // 
            this.rb_div.AutoSize = true;
            this.rb_div.Location = new System.Drawing.Point(28, 69);
            this.rb_div.Name = "rb_div";
            this.rb_div.Size = new System.Drawing.Size(62, 17);
            this.rb_div.TabIndex = 2;
            this.rb_div.TabStop = true;
            this.rb_div.Text = "Divorcé";
            this.rb_div.UseVisualStyleBackColor = true;
            // 
            // rb_marie
            // 
            this.rb_marie.AutoSize = true;
            this.rb_marie.Location = new System.Drawing.Point(28, 46);
            this.rb_marie.Name = "rb_marie";
            this.rb_marie.Size = new System.Drawing.Size(51, 17);
            this.rb_marie.TabIndex = 1;
            this.rb_marie.TabStop = true;
            this.rb_marie.Text = "Marié";
            this.rb_marie.UseVisualStyleBackColor = true;
            // 
            // rb_celib
            // 
            this.rb_celib.AutoSize = true;
            this.rb_celib.Checked = true;
            this.rb_celib.Location = new System.Drawing.Point(28, 23);
            this.rb_celib.Name = "rb_celib";
            this.rb_celib.Size = new System.Drawing.Size(74, 17);
            this.rb_celib.TabIndex = 0;
            this.rb_celib.TabStop = true;
            this.rb_celib.Text = "Célibataire";
            this.rb_celib.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_num);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_prenom);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Location = new System.Drawing.Point(30, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 171);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Personnel";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(73, 41);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(73, 106);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(100, 20);
            this.txt_prenom.TabIndex = 1;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(73, 71);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 0;
            // 
            // FGestionCandidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 304);
            this.Controls.Add(this.bt_formSuivant);
            this.Controls.Add(this.bt_premier);
            this.Controls.Add(this.bt_precedent);
            this.Controls.Add(this.bt_suivant);
            this.Controls.Add(this.bt_dernier);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.bt_modifier);
            this.Controls.Add(this.bt_supprimer);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FGestionCandidat";
            this.Text = "Formulaire Gestion de Candidat";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_formSuivant;
        private System.Windows.Forms.Button bt_premier;
        private System.Windows.Forms.Button bt_precedent;
        private System.Windows.Forms.Button bt_suivant;
        private System.Windows.Forms.Button bt_dernier;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cc_master;
        private System.Windows.Forms.CheckBox cc_licence;
        private System.Windows.Forms.CheckBox cc_bac;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_div;
        private System.Windows.Forms.RadioButton rb_marie;
        private System.Windows.Forms.RadioButton rb_celib;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
    }
}

