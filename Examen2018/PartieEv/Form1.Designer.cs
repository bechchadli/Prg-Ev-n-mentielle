namespace PartieWinForm
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
            this.cb_pays = new System.Windows.Forms.ComboBox();
            this.listVilles = new System.Windows.Forms.ListBox();
            this.rb_croissant = new System.Windows.Forms.RadioButton();
            this.rb_decroissant = new System.Windows.Forms.RadioButton();
            this.bt_trier = new System.Windows.Forms.Button();
            this.bt_ordreInitial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_pays
            // 
            this.cb_pays.FormattingEnabled = true;
            this.cb_pays.Location = new System.Drawing.Point(98, 59);
            this.cb_pays.Name = "cb_pays";
            this.cb_pays.Size = new System.Drawing.Size(121, 21);
            this.cb_pays.TabIndex = 0;
            this.cb_pays.SelectedIndexChanged += new System.EventHandler(this.cb_pays_SelectedIndexChanged);
            // 
            // listVilles
            // 
            this.listVilles.FormattingEnabled = true;
            this.listVilles.Location = new System.Drawing.Point(98, 86);
            this.listVilles.Name = "listVilles";
            this.listVilles.Size = new System.Drawing.Size(120, 95);
            this.listVilles.TabIndex = 1;
            // 
            // rb_croissant
            // 
            this.rb_croissant.AutoSize = true;
            this.rb_croissant.Checked = true;
            this.rb_croissant.Location = new System.Drawing.Point(17, 19);
            this.rb_croissant.Name = "rb_croissant";
            this.rb_croissant.Size = new System.Drawing.Size(68, 17);
            this.rb_croissant.TabIndex = 2;
            this.rb_croissant.TabStop = true;
            this.rb_croissant.Text = "Croissant";
            this.rb_croissant.UseVisualStyleBackColor = true;
            // 
            // rb_decroissant
            // 
            this.rb_decroissant.AutoSize = true;
            this.rb_decroissant.Location = new System.Drawing.Point(17, 42);
            this.rb_decroissant.Name = "rb_decroissant";
            this.rb_decroissant.Size = new System.Drawing.Size(81, 17);
            this.rb_decroissant.TabIndex = 3;
            this.rb_decroissant.TabStop = true;
            this.rb_decroissant.Text = "Décroissant";
            this.rb_decroissant.UseVisualStyleBackColor = true;
            // 
            // bt_trier
            // 
            this.bt_trier.Location = new System.Drawing.Point(252, 137);
            this.bt_trier.Name = "bt_trier";
            this.bt_trier.Size = new System.Drawing.Size(75, 23);
            this.bt_trier.TabIndex = 4;
            this.bt_trier.Text = "Trier";
            this.bt_trier.UseVisualStyleBackColor = true;
            this.bt_trier.Click += new System.EventHandler(this.bt_trier_Click);
            // 
            // bt_ordreInitial
            // 
            this.bt_ordreInitial.Location = new System.Drawing.Point(252, 166);
            this.bt_ordreInitial.Name = "bt_ordreInitial";
            this.bt_ordreInitial.Size = new System.Drawing.Size(75, 23);
            this.bt_ordreInitial.TabIndex = 5;
            this.bt_ordreInitial.Text = "Ordre Initial";
            this.bt_ordreInitial.UseVisualStyleBackColor = true;
            this.bt_ordreInitial.Click += new System.EventHandler(this.bt_ordreInitial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pays : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Villes : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_croissant);
            this.groupBox1.Controls.Add(this.rb_decroissant);
            this.groupBox1.Location = new System.Drawing.Point(235, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 231);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_ordreInitial);
            this.Controls.Add(this.bt_trier);
            this.Controls.Add(this.listVilles);
            this.Controls.Add(this.cb_pays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_pays;
        private System.Windows.Forms.ListBox listVilles;
        private System.Windows.Forms.RadioButton rb_croissant;
        private System.Windows.Forms.RadioButton rb_decroissant;
        private System.Windows.Forms.Button bt_trier;
        private System.Windows.Forms.Button bt_ordreInitial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

