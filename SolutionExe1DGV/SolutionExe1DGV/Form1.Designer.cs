namespace SolutionExe1DGV
{
    partial class Form1
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sauvg = new System.Windows.Forms.Button();
            this.bt_afficher = new System.Windows.Forms.Button();
            this.bt_rech = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.bt_restaurer = new System.Windows.Forms.Button();
            this.rb_tsge = new System.Windows.Forms.RadioButton();
            this.rb_tri = new System.Windows.Forms.RadioButton();
            this.rb_tdi = new System.Windows.Forms.RadioButton();
            this.cb_sexe = new System.Windows.Forms.ComboBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_pre = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_bin = new System.Windows.Forms.RadioButton();
            this.rb_txt = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.bt_fermer = new System.Windows.Forms.Button();
            this.bt_vider = new System.Windows.Forms.Button();
            this.DGV_restaurer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_restaurer)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, -1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 29);
            this.label6.TabIndex = 38;
            this.label6.Text = "Inscription";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Sexe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Filère : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Age :";
            // 
            // bt_sauvg
            // 
            this.bt_sauvg.Location = new System.Drawing.Point(94, 46);
            this.bt_sauvg.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sauvg.Name = "bt_sauvg";
            this.bt_sauvg.Size = new System.Drawing.Size(76, 25);
            this.bt_sauvg.TabIndex = 32;
            this.bt_sauvg.Text = "Sauvegarder";
            this.bt_sauvg.UseVisualStyleBackColor = true;
            this.bt_sauvg.Click += new System.EventHandler(this.bt_sauvg_Click);
            // 
            // bt_afficher
            // 
            this.bt_afficher.Location = new System.Drawing.Point(429, 215);
            this.bt_afficher.Margin = new System.Windows.Forms.Padding(2);
            this.bt_afficher.Name = "bt_afficher";
            this.bt_afficher.Size = new System.Drawing.Size(76, 25);
            this.bt_afficher.TabIndex = 31;
            this.bt_afficher.Text = "Afficher";
            this.bt_afficher.UseVisualStyleBackColor = true;
            this.bt_afficher.Click += new System.EventHandler(this.bt_afficher_Click);
            // 
            // bt_rech
            // 
            this.bt_rech.Location = new System.Drawing.Point(343, 215);
            this.bt_rech.Margin = new System.Windows.Forms.Padding(2);
            this.bt_rech.Name = "bt_rech";
            this.bt_rech.Size = new System.Drawing.Size(76, 25);
            this.bt_rech.TabIndex = 30;
            this.bt_rech.Text = "Rechercher";
            this.bt_rech.UseVisualStyleBackColor = true;
            this.bt_rech.Click += new System.EventHandler(this.bt_rech_Click);
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.Location = new System.Drawing.Point(256, 215);
            this.bt_supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(76, 25);
            this.bt_supprimer.TabIndex = 29;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = true;
            this.bt_supprimer.Click += new System.EventHandler(this.bt_supprimer_Click);
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.Location = new System.Drawing.Point(165, 215);
            this.bt_ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(76, 25);
            this.bt_ajouter.TabIndex = 28;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = true;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // bt_restaurer
            // 
            this.bt_restaurer.Location = new System.Drawing.Point(94, 15);
            this.bt_restaurer.Margin = new System.Windows.Forms.Padding(2);
            this.bt_restaurer.Name = "bt_restaurer";
            this.bt_restaurer.Size = new System.Drawing.Size(76, 25);
            this.bt_restaurer.TabIndex = 27;
            this.bt_restaurer.Text = "Restaurer";
            this.bt_restaurer.UseVisualStyleBackColor = true;
            this.bt_restaurer.Click += new System.EventHandler(this.bt_restaurer_Click);
            // 
            // rb_tsge
            // 
            this.rb_tsge.AutoSize = true;
            this.rb_tsge.Location = new System.Drawing.Point(421, 139);
            this.rb_tsge.Margin = new System.Windows.Forms.Padding(2);
            this.rb_tsge.Name = "rb_tsge";
            this.rb_tsge.Size = new System.Drawing.Size(54, 17);
            this.rb_tsge.TabIndex = 26;
            this.rb_tsge.Text = "TSGE";
            this.rb_tsge.UseVisualStyleBackColor = true;
            // 
            // rb_tri
            // 
            this.rb_tri.AutoSize = true;
            this.rb_tri.Location = new System.Drawing.Point(323, 139);
            this.rb_tri.Margin = new System.Windows.Forms.Padding(2);
            this.rb_tri.Name = "rb_tri";
            this.rb_tri.Size = new System.Drawing.Size(43, 17);
            this.rb_tri.TabIndex = 25;
            this.rb_tri.Text = "TRI";
            this.rb_tri.UseVisualStyleBackColor = true;
            // 
            // rb_tdi
            // 
            this.rb_tdi.AutoSize = true;
            this.rb_tdi.Checked = true;
            this.rb_tdi.Location = new System.Drawing.Point(222, 139);
            this.rb_tdi.Margin = new System.Windows.Forms.Padding(2);
            this.rb_tdi.Name = "rb_tdi";
            this.rb_tdi.Size = new System.Drawing.Size(43, 17);
            this.rb_tdi.TabIndex = 24;
            this.rb_tdi.TabStop = true;
            this.rb_tdi.Text = "TDI";
            this.rb_tdi.UseVisualStyleBackColor = true;
            // 
            // cb_sexe
            // 
            this.cb_sexe.FormattingEnabled = true;
            this.cb_sexe.Location = new System.Drawing.Point(219, 112);
            this.cb_sexe.Margin = new System.Windows.Forms.Padding(2);
            this.cb_sexe.Name = "cb_sexe";
            this.cb_sexe.Size = new System.Drawing.Size(181, 21);
            this.cb_sexe.TabIndex = 23;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(219, 163);
            this.txt_age.Margin = new System.Windows.Forms.Padding(2);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(68, 20);
            this.txt_age.TabIndex = 22;
            // 
            // txt_pre
            // 
            this.txt_pre.Location = new System.Drawing.Point(219, 88);
            this.txt_pre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pre.Name = "txt_pre";
            this.txt_pre.Size = new System.Drawing.Size(167, 20);
            this.txt_pre.TabIndex = 21;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(219, 63);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(167, 20);
            this.txt_nom.TabIndex = 20;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(35, 249);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(764, 127);
            this.DGV.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_txt);
            this.groupBox1.Controls.Add(this.rb_bin);
            this.groupBox1.Controls.Add(this.bt_restaurer);
            this.groupBox1.Controls.Add(this.bt_sauvg);
            this.groupBox1.Location = new System.Drawing.Point(509, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 77);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option :";
            // 
            // rb_bin
            // 
            this.rb_bin.AutoSize = true;
            this.rb_bin.Location = new System.Drawing.Point(6, 30);
            this.rb_bin.Name = "rb_bin";
            this.rb_bin.Size = new System.Drawing.Size(89, 17);
            this.rb_bin.TabIndex = 0;
            this.rb_bin.TabStop = true;
            this.rb_bin.Text = "Ficher Binaire";
            this.rb_bin.UseVisualStyleBackColor = true;
            // 
            // rb_txt
            // 
            this.rb_txt.AutoSize = true;
            this.rb_txt.Checked = true;
            this.rb_txt.Location = new System.Drawing.Point(6, 53);
            this.rb_txt.Name = "rb_txt";
            this.rb_txt.Size = new System.Drawing.Size(86, 17);
            this.rb_txt.TabIndex = 1;
            this.rb_txt.TabStop = true;
            this.rb_txt.Text = "Fichier Texte";
            this.rb_txt.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Numero :";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(219, 38);
            this.txt_num.Margin = new System.Windows.Forms.Padding(2);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(167, 20);
            this.txt_num.TabIndex = 41;
            // 
            // bt_fermer
            // 
            this.bt_fermer.Location = new System.Drawing.Point(690, 215);
            this.bt_fermer.Name = "bt_fermer";
            this.bt_fermer.Size = new System.Drawing.Size(109, 25);
            this.bt_fermer.TabIndex = 43;
            this.bt_fermer.Text = "Fermer";
            this.bt_fermer.UseVisualStyleBackColor = true;
            this.bt_fermer.Click += new System.EventHandler(this.bt_fermer_Click);
            // 
            // bt_vider
            // 
            this.bt_vider.Location = new System.Drawing.Point(85, 215);
            this.bt_vider.Name = "bt_vider";
            this.bt_vider.Size = new System.Drawing.Size(75, 25);
            this.bt_vider.TabIndex = 44;
            this.bt_vider.Text = "Vider";
            this.bt_vider.UseVisualStyleBackColor = true;
            this.bt_vider.Click += new System.EventHandler(this.bt_vider_Click);
            // 
            // DGV_restaurer
            // 
            this.DGV_restaurer.AllowUserToAddRows = false;
            this.DGV_restaurer.AllowUserToDeleteRows = false;
            this.DGV_restaurer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_restaurer.Location = new System.Drawing.Point(35, 399);
            this.DGV_restaurer.Name = "DGV_restaurer";
            this.DGV_restaurer.ReadOnly = true;
            this.DGV_restaurer.Size = new System.Drawing.Size(764, 125);
            this.DGV_restaurer.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 536);
            this.Controls.Add(this.DGV_restaurer);
            this.Controls.Add(this.bt_vider);
            this.Controls.Add(this.bt_fermer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_afficher);
            this.Controls.Add(this.bt_rech);
            this.Controls.Add(this.bt_supprimer);
            this.Controls.Add(this.bt_ajouter);
            this.Controls.Add(this.rb_tsge);
            this.Controls.Add(this.rb_tri);
            this.Controls.Add(this.rb_tdi);
            this.Controls.Add(this.cb_sexe);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_pre);
            this.Controls.Add(this.txt_nom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_restaurer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_sauvg;
        private System.Windows.Forms.Button bt_afficher;
        private System.Windows.Forms.Button bt_rech;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Button bt_restaurer;
        private System.Windows.Forms.RadioButton rb_tsge;
        private System.Windows.Forms.RadioButton rb_tri;
        private System.Windows.Forms.RadioButton rb_tdi;
        private System.Windows.Forms.ComboBox cb_sexe;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_pre;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_txt;
        private System.Windows.Forms.RadioButton rb_bin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Button bt_fermer;
        private System.Windows.Forms.Button bt_vider;
        private System.Windows.Forms.DataGridView DGV_restaurer;
    }
}

