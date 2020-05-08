namespace GestionVolsWinForm
{
    partial class AjouterAvion
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.bt_quitter = new System.Windows.Forms.Button();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.bt_valider = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_capacite = new System.Windows.Forms.TextBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.cb_marque = new System.Windows.Forms.ComboBox();
            this.errorProviderTxt = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Numero :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Marque :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(105, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ajouter Un Nouveau Avion";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(206, 117);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 16;
            this.txt_numero.Validating += new System.ComponentModel.CancelEventHandler(this.txt_numero_Validating);
            // 
            // bt_quitter
            // 
            this.bt_quitter.Location = new System.Drawing.Point(287, 229);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(75, 23);
            this.bt_quitter.TabIndex = 13;
            this.bt_quitter.Text = "Quitter";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(206, 229);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(75, 23);
            this.bt_annuler.TabIndex = 12;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(125, 229);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(75, 23);
            this.bt_valider.TabIndex = 11;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Capacité :";
            // 
            // txt_capacite
            // 
            this.txt_capacite.Location = new System.Drawing.Point(206, 196);
            this.txt_capacite.Name = "txt_capacite";
            this.txt_capacite.Size = new System.Drawing.Size(100, 20);
            this.txt_capacite.TabIndex = 21;
            this.txt_capacite.Validating += new System.ComponentModel.CancelEventHandler(this.txt_capacite_Validating);
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(206, 169);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 21);
            this.cb_type.TabIndex = 23;
            this.cb_type.Validating += new System.ComponentModel.CancelEventHandler(this.cb_type_Validating);
            // 
            // cb_marque
            // 
            this.cb_marque.FormattingEnabled = true;
            this.cb_marque.Items.AddRange(new object[] {
            "Airbus",
            "Boeing",
            "Antonov"});
            this.cb_marque.Location = new System.Drawing.Point(206, 143);
            this.cb_marque.Name = "cb_marque";
            this.cb_marque.Size = new System.Drawing.Size(121, 21);
            this.cb_marque.TabIndex = 24;
            this.cb_marque.SelectedIndexChanged += new System.EventHandler(this.cb_marque_SelectedIndexChanged);
            this.cb_marque.Validating += new System.ComponentModel.CancelEventHandler(this.cb_marque_Validating);
            // 
            // errorProviderTxt
            // 
            this.errorProviderTxt.ContainerControl = this;
            // 
            // AjouterAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 336);
            this.Controls.Add(this.cb_marque);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_capacite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.bt_valider);
            this.Name = "AjouterAvion";
            this.Text = "AjouterAvion";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button bt_quitter;
        private System.Windows.Forms.Button bt_annuler;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_capacite;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.ComboBox cb_marque;
        private System.Windows.Forms.ErrorProvider errorProviderTxt;
    }
}