namespace GestionVolsWinForm
{
    partial class AjouterVol
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
            this.components = new System.ComponentModel.Container();
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
            this.bt_annuler = new System.Windows.Forms.Button();
            this.bt_valider = new System.Windows.Forms.Button();
            this.cb_pilote = new System.Windows.Forms.ComboBox();
            this.cb_avion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateVol = new System.Windows.Forms.DateTimePicker();
            this.errorProviderTxt = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_villeDep
            // 
            this.cb_villeDep.FormattingEnabled = true;
            this.cb_villeDep.Location = new System.Drawing.Point(220, 172);
            this.cb_villeDep.Name = "cb_villeDep";
            this.cb_villeDep.Size = new System.Drawing.Size(200, 21);
            this.cb_villeDep.TabIndex = 36;
            this.cb_villeDep.SelectedIndexChanged += new System.EventHandler(this.cb_villeDep_SelectedIndexChanged);
            this.cb_villeDep.Validating += new System.ComponentModel.CancelEventHandler(this.cb_villeDep_Validating);
            // 
            // cb_villeArr
            // 
            this.cb_villeArr.FormattingEnabled = true;
            this.cb_villeArr.Location = new System.Drawing.Point(220, 198);
            this.cb_villeArr.Name = "cb_villeArr";
            this.cb_villeArr.Size = new System.Drawing.Size(200, 21);
            this.cb_villeArr.TabIndex = 35;
            this.cb_villeArr.SelectedIndexChanged += new System.EventHandler(this.cb_villeArr_SelectedIndexChanged);
            this.cb_villeArr.Validating += new System.ComponentModel.CancelEventHandler(this.cb_villeArr_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nombre Voyageurs :";
            // 
            // txt_nbrVoy
            // 
            this.txt_nbrVoy.Location = new System.Drawing.Point(220, 225);
            this.txt_nbrVoy.Name = "txt_nbrVoy";
            this.txt_nbrVoy.Size = new System.Drawing.Size(100, 20);
            this.txt_nbrVoy.TabIndex = 33;
            this.txt_nbrVoy.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nbrVoy_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Avion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ville Départ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ville Arrivé :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(115, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ajouter Un Nouveau Vol";
            // 
            // txt_PrixBillet
            // 
            this.txt_PrixBillet.Location = new System.Drawing.Point(220, 251);
            this.txt_PrixBillet.Name = "txt_PrixBillet";
            this.txt_PrixBillet.Size = new System.Drawing.Size(100, 20);
            this.txt_PrixBillet.TabIndex = 28;
            this.txt_PrixBillet.Validating += new System.ComponentModel.CancelEventHandler(this.txt_PrixBillet_Validating);
            // 
            // bt_quitter
            // 
            this.bt_quitter.Location = new System.Drawing.Point(278, 306);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(75, 23);
            this.bt_quitter.TabIndex = 27;
            this.bt_quitter.Text = "Quitter";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(197, 306);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_annuler.TabIndex = 26;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(116, 306);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(75, 23);
            this.bt_valider.TabIndex = 25;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // cb_pilote
            // 
            this.cb_pilote.FormattingEnabled = true;
            this.cb_pilote.Location = new System.Drawing.Point(220, 91);
            this.cb_pilote.Name = "cb_pilote";
            this.cb_pilote.Size = new System.Drawing.Size(200, 21);
            this.cb_pilote.TabIndex = 38;
            this.cb_pilote.Validating += new System.ComponentModel.CancelEventHandler(this.cb_pilote_Validating);
            // 
            // cb_avion
            // 
            this.cb_avion.FormattingEnabled = true;
            this.cb_avion.Location = new System.Drawing.Point(220, 117);
            this.cb_avion.Name = "cb_avion";
            this.cb_avion.Size = new System.Drawing.Size(200, 21);
            this.cb_avion.TabIndex = 37;
            this.cb_avion.Validating += new System.ComponentModel.CancelEventHandler(this.cb_avion_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Date du Vol :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Pilote :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Prix Du Billet :";
            // 
            // dateVol
            // 
            this.dateVol.Location = new System.Drawing.Point(220, 145);
            this.dateVol.Name = "dateVol";
            this.dateVol.Size = new System.Drawing.Size(200, 20);
            this.dateVol.TabIndex = 42;
            // 
            // errorProviderTxt
            // 
            this.errorProviderTxt.ContainerControl = this;
            // 
            // AjouterVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 357);
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
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.bt_valider);
            this.Name = "AjouterVol";
            this.Text = "AjouterVol";
            this.Load += new System.EventHandler(this.AjouterVol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.ComboBox cb_pilote;
        private System.Windows.Forms.ComboBox cb_avion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateVol;
        private System.Windows.Forms.ErrorProvider errorProviderTxt;
    }
}