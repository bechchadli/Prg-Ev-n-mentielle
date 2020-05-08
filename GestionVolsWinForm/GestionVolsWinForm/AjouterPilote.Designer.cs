namespace GestionVolsWinForm
{
    partial class AjouterPilote
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
            this.bt_valider = new System.Windows.Forms.Button();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.bt_quitter = new System.Windows.Forms.Button();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_matricule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProviderTxt = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(96, 201);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(75, 23);
            this.bt_valider.TabIndex = 0;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(177, 201);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_annuler.TabIndex = 1;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // bt_quitter
            // 
            this.bt_quitter.Location = new System.Drawing.Point(258, 201);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(75, 23);
            this.bt_quitter.TabIndex = 2;
            this.bt_quitter.Text = "Quitter";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(177, 141);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(100, 20);
            this.txt_prenom.TabIndex = 3;
            this.txt_prenom.Validating += new System.ComponentModel.CancelEventHandler(this.txt_prenom_Validating);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(177, 115);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 20);
            this.txt_nom.TabIndex = 4;
            this.txt_nom.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nom_Validating);
            // 
            // txt_matricule
            // 
            this.txt_matricule.Location = new System.Drawing.Point(177, 89);
            this.txt_matricule.Name = "txt_matricule";
            this.txt_matricule.Size = new System.Drawing.Size(100, 20);
            this.txt_matricule.TabIndex = 5;
            this.txt_matricule.Validating += new System.ComponentModel.CancelEventHandler(this.txt_matricule_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(76, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ajouter Un Nouveau Pilote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Matricule :";
            // 
            // errorProviderTxt
            // 
            this.errorProviderTxt.ContainerControl = this;
            // 
            // AjouterPilote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 321);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_matricule);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.bt_valider);
            this.Name = "AjouterPilote";
            this.Text = "AjouterPilote";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Button bt_quitter;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_matricule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProviderTxt;
    }
}