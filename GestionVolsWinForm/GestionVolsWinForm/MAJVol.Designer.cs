namespace GestionVolsWinForm
{
    partial class MAJVol
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
            this.dateVol = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_pilote = new System.Windows.Forms.ComboBox();
            this.cb_avion = new System.Windows.Forms.ComboBox();
            this.cb_villeDep = new System.Windows.Forms.ComboBox();
            this.cb_villeArr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nbrVoy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PrixBillet = new System.Windows.Forms.TextBox();
            this.bt_quitter = new System.Windows.Forms.Button();
            this.bt_premier = new System.Windows.Forms.Button();
            this.bt_precedent = new System.Windows.Forms.Button();
            this.bt_suivant = new System.Windows.Forms.Button();
            this.bt_dernier = new System.Windows.Forms.Button();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_numero = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateVol
            // 
            this.dateVol.Location = new System.Drawing.Point(176, 128);
            this.dateVol.Name = "dateVol";
            this.dateVol.Size = new System.Drawing.Size(200, 20);
            this.dateVol.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Prix Du Billet :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Pilote :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Date du Vol :";
            // 
            // cb_pilote
            // 
            this.cb_pilote.FormattingEnabled = true;
            this.cb_pilote.Location = new System.Drawing.Point(176, 74);
            this.cb_pilote.Name = "cb_pilote";
            this.cb_pilote.Size = new System.Drawing.Size(200, 21);
            this.cb_pilote.TabIndex = 53;
            // 
            // cb_avion
            // 
            this.cb_avion.FormattingEnabled = true;
            this.cb_avion.Location = new System.Drawing.Point(176, 100);
            this.cb_avion.Name = "cb_avion";
            this.cb_avion.Size = new System.Drawing.Size(200, 21);
            this.cb_avion.TabIndex = 52;
            // 
            // cb_villeDep
            // 
            this.cb_villeDep.FormattingEnabled = true;
            this.cb_villeDep.Location = new System.Drawing.Point(176, 155);
            this.cb_villeDep.Name = "cb_villeDep";
            this.cb_villeDep.Size = new System.Drawing.Size(200, 21);
            this.cb_villeDep.TabIndex = 51;
            // 
            // cb_villeArr
            // 
            this.cb_villeArr.FormattingEnabled = true;
            this.cb_villeArr.Location = new System.Drawing.Point(176, 181);
            this.cb_villeArr.Name = "cb_villeArr";
            this.cb_villeArr.Size = new System.Drawing.Size(200, 21);
            this.cb_villeArr.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Nombre Voyageurs :";
            // 
            // txt_nbrVoy
            // 
            this.txt_nbrVoy.Location = new System.Drawing.Point(176, 208);
            this.txt_nbrVoy.Name = "txt_nbrVoy";
            this.txt_nbrVoy.Size = new System.Drawing.Size(100, 20);
            this.txt_nbrVoy.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Avion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Ville Départ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ville Arrivé :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "MAJ Vol";
            // 
            // txt_PrixBillet
            // 
            this.txt_PrixBillet.Location = new System.Drawing.Point(176, 234);
            this.txt_PrixBillet.Name = "txt_PrixBillet";
            this.txt_PrixBillet.Size = new System.Drawing.Size(100, 20);
            this.txt_PrixBillet.TabIndex = 43;
            // 
            // bt_quitter
            // 
            this.bt_quitter.Location = new System.Drawing.Point(292, 274);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(70, 23);
            this.bt_quitter.TabIndex = 65;
            this.bt_quitter.Text = "Quitter";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // bt_premier
            // 
            this.bt_premier.Location = new System.Drawing.Point(111, 303);
            this.bt_premier.Name = "bt_premier";
            this.bt_premier.Size = new System.Drawing.Size(34, 23);
            this.bt_premier.TabIndex = 64;
            this.bt_premier.Text = "|<";
            this.bt_premier.UseVisualStyleBackColor = true;
            this.bt_premier.Click += new System.EventHandler(this.bt_premier_Click);
            // 
            // bt_precedent
            // 
            this.bt_precedent.Location = new System.Drawing.Point(151, 303);
            this.bt_precedent.Name = "bt_precedent";
            this.bt_precedent.Size = new System.Drawing.Size(35, 23);
            this.bt_precedent.TabIndex = 63;
            this.bt_precedent.Text = "<";
            this.bt_precedent.UseVisualStyleBackColor = true;
            this.bt_precedent.Click += new System.EventHandler(this.bt_precedent_Click);
            // 
            // bt_suivant
            // 
            this.bt_suivant.Location = new System.Drawing.Point(247, 303);
            this.bt_suivant.Name = "bt_suivant";
            this.bt_suivant.Size = new System.Drawing.Size(35, 23);
            this.bt_suivant.TabIndex = 62;
            this.bt_suivant.Text = ">";
            this.bt_suivant.UseVisualStyleBackColor = true;
            this.bt_suivant.Click += new System.EventHandler(this.bt_suivant_Click);
            // 
            // bt_dernier
            // 
            this.bt_dernier.Location = new System.Drawing.Point(288, 303);
            this.bt_dernier.Name = "bt_dernier";
            this.bt_dernier.Size = new System.Drawing.Size(34, 23);
            this.bt_dernier.TabIndex = 61;
            this.bt_dernier.Text = ">|";
            this.bt_dernier.UseVisualStyleBackColor = true;
            this.bt_dernier.Click += new System.EventHandler(this.bt_dernier_Click);
            // 
            // bt_modifier
            // 
            this.bt_modifier.Location = new System.Drawing.Point(64, 274);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(70, 23);
            this.bt_modifier.TabIndex = 60;
            this.bt_modifier.Text = "Modifier";
            this.bt_modifier.UseVisualStyleBackColor = true;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.Location = new System.Drawing.Point(140, 274);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(70, 23);
            this.bt_supprimer.TabIndex = 59;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = true;
            this.bt_supprimer.Click += new System.EventHandler(this.bt_supprimer_Click);
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(216, 274);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(70, 23);
            this.bt_annuler.TabIndex = 58;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Numero :";
            // 
            // cb_numero
            // 
            this.cb_numero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_numero.FormattingEnabled = true;
            this.cb_numero.Location = new System.Drawing.Point(176, 47);
            this.cb_numero.Name = "cb_numero";
            this.cb_numero.Size = new System.Drawing.Size(200, 21);
            this.cb_numero.TabIndex = 66;
            this.cb_numero.SelectedIndexChanged += new System.EventHandler(this.cb_numero_SelectedIndexChanged);
            // 
            // MAJVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 342);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_numero);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.bt_premier);
            this.Controls.Add(this.bt_precedent);
            this.Controls.Add(this.bt_suivant);
            this.Controls.Add(this.bt_dernier);
            this.Controls.Add(this.bt_modifier);
            this.Controls.Add(this.bt_supprimer);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.dateVol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_pilote);
            this.Controls.Add(this.cb_avion);
            this.Controls.Add(this.cb_villeDep);
            this.Controls.Add(this.cb_villeArr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nbrVoy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_PrixBillet);
            this.Name = "MAJVol";
            this.Text = "MAJVol";
            this.Load += new System.EventHandler(this.MAJVol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateVol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_pilote;
        private System.Windows.Forms.ComboBox cb_avion;
        private System.Windows.Forms.ComboBox cb_villeDep;
        private System.Windows.Forms.ComboBox cb_villeArr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nbrVoy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PrixBillet;
        private System.Windows.Forms.Button bt_quitter;
        private System.Windows.Forms.Button bt_premier;
        private System.Windows.Forms.Button bt_precedent;
        private System.Windows.Forms.Button bt_suivant;
        private System.Windows.Forms.Button bt_dernier;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_numero;
    }
}