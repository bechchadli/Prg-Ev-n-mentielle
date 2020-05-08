namespace GestionVolsWinForm
{
    partial class MAJAvion
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
            this.cb_marque = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_capacite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_premier = new System.Windows.Forms.Button();
            this.bt_precedent = new System.Windows.Forms.Button();
            this.bt_suivant = new System.Windows.Forms.Button();
            this.bt_dernier = new System.Windows.Forms.Button();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.cb_numero = new System.Windows.Forms.ComboBox();
            this.bt_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_marque
            // 
            this.cb_marque.FormattingEnabled = true;
            this.cb_marque.Items.AddRange(new object[] {
            "Airbus",
            "Boeing",
            "Antonov"});
            this.cb_marque.Location = new System.Drawing.Point(172, 140);
            this.cb_marque.Name = "cb_marque";
            this.cb_marque.Size = new System.Drawing.Size(121, 21);
            this.cb_marque.TabIndex = 33;
            this.cb_marque.SelectedIndexChanged += new System.EventHandler(this.cb_marque_SelectedIndexChanged);
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(172, 166);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 21);
            this.cb_type.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Capacité :";
            // 
            // txt_capacite
            // 
            this.txt_capacite.Location = new System.Drawing.Point(172, 193);
            this.txt_capacite.Name = "txt_capacite";
            this.txt_capacite.Size = new System.Drawing.Size(100, 20);
            this.txt_capacite.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Numero :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Marque :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(159, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "MAJ Avion";
            // 
            // bt_premier
            // 
            this.bt_premier.Location = new System.Drawing.Point(88, 297);
            this.bt_premier.Name = "bt_premier";
            this.bt_premier.Size = new System.Drawing.Size(34, 23);
            this.bt_premier.TabIndex = 44;
            this.bt_premier.Text = "|<";
            this.bt_premier.UseVisualStyleBackColor = true;
            this.bt_premier.Click += new System.EventHandler(this.bt_premier_Click);
            // 
            // bt_precedent
            // 
            this.bt_precedent.Location = new System.Drawing.Point(128, 297);
            this.bt_precedent.Name = "bt_precedent";
            this.bt_precedent.Size = new System.Drawing.Size(35, 23);
            this.bt_precedent.TabIndex = 43;
            this.bt_precedent.Text = "<";
            this.bt_precedent.UseVisualStyleBackColor = true;
            this.bt_precedent.Click += new System.EventHandler(this.bt_precedent_Click);
            // 
            // bt_suivant
            // 
            this.bt_suivant.Location = new System.Drawing.Point(234, 297);
            this.bt_suivant.Name = "bt_suivant";
            this.bt_suivant.Size = new System.Drawing.Size(35, 23);
            this.bt_suivant.TabIndex = 42;
            this.bt_suivant.Text = ">";
            this.bt_suivant.UseVisualStyleBackColor = true;
            this.bt_suivant.Click += new System.EventHandler(this.bt_suivant_Click);
            // 
            // bt_dernier
            // 
            this.bt_dernier.Location = new System.Drawing.Point(275, 297);
            this.bt_dernier.Name = "bt_dernier";
            this.bt_dernier.Size = new System.Drawing.Size(34, 23);
            this.bt_dernier.TabIndex = 41;
            this.bt_dernier.Text = ">|";
            this.bt_dernier.UseVisualStyleBackColor = true;
            this.bt_dernier.Click += new System.EventHandler(this.bt_dernier_Click);
            // 
            // bt_modifier
            // 
            this.bt_modifier.Location = new System.Drawing.Point(57, 268);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(67, 23);
            this.bt_modifier.TabIndex = 40;
            this.bt_modifier.Text = "Modifier";
            this.bt_modifier.UseVisualStyleBackColor = true;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.Location = new System.Drawing.Point(130, 268);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(67, 23);
            this.bt_supprimer.TabIndex = 39;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = true;
            this.bt_supprimer.Click += new System.EventHandler(this.bt_supprimer_Click);
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(202, 268);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(67, 23);
            this.bt_annuler.TabIndex = 38;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // cb_numero
            // 
            this.cb_numero.FormattingEnabled = true;
            this.cb_numero.Location = new System.Drawing.Point(172, 113);
            this.cb_numero.Name = "cb_numero";
            this.cb_numero.Size = new System.Drawing.Size(121, 21);
            this.cb_numero.TabIndex = 46;
            this.cb_numero.SelectedIndexChanged += new System.EventHandler(this.cb_numero_SelectedIndexChanged);
            // 
            // bt_quitter
            // 
            this.bt_quitter.Location = new System.Drawing.Point(275, 268);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(67, 23);
            this.bt_quitter.TabIndex = 47;
            this.bt_quitter.Text = "Quitter";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // MAJAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 386);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.cb_numero);
            this.Controls.Add(this.bt_premier);
            this.Controls.Add(this.bt_precedent);
            this.Controls.Add(this.bt_suivant);
            this.Controls.Add(this.bt_dernier);
            this.Controls.Add(this.bt_modifier);
            this.Controls.Add(this.bt_supprimer);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.cb_marque);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_capacite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MAJAvion";
            this.Text = "MAJAvion";
            this.Load += new System.EventHandler(this.MAJAvion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_marque;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_capacite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_premier;
        private System.Windows.Forms.Button bt_precedent;
        private System.Windows.Forms.Button bt_suivant;
        private System.Windows.Forms.Button bt_dernier;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.ComboBox cb_numero;
        private System.Windows.Forms.Button bt_quitter;
    }
}