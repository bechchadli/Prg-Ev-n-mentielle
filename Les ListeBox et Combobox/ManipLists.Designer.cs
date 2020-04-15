namespace AppWF2
{
    partial class ManipLists
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
            this.lb_prenom = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_nom2 = new System.Windows.Forms.ComboBox();
            this.lb_prenom3 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_rechrcher = new System.Windows.Forms.Button();
            this.bt_afficher = new System.Windows.Forms.Button();
            this.cb_nom4 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_nom
            // 
            this.cb_nom.FormattingEnabled = true;
            this.cb_nom.Items.AddRange(new object[] {
            "aaaa",
            "bbbb",
            "cccc",
            "dddd",
            "rrrrrr"});
            this.cb_nom.Location = new System.Drawing.Point(150, 51);
            this.cb_nom.Name = "cb_nom";
            this.cb_nom.Size = new System.Drawing.Size(121, 21);
            this.cb_nom.TabIndex = 0;
            this.cb_nom.SelectedIndexChanged += new System.EventHandler(this.cb_nom_SelectedIndexChanged);
            // 
            // lb_prenom
            // 
            this.lb_prenom.FormattingEnabled = true;
            this.lb_prenom.Location = new System.Drawing.Point(150, 119);
            this.lb_prenom.Name = "lb_prenom";
            this.lb_prenom.Size = new System.Drawing.Size(120, 95);
            this.lb_prenom.TabIndex = 1;
            this.lb_prenom.SelectedIndexChanged += new System.EventHandler(this.lb_prenom_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_nom2
            // 
            this.cb_nom2.FormattingEnabled = true;
            this.cb_nom2.Location = new System.Drawing.Point(308, 49);
            this.cb_nom2.Name = "cb_nom2";
            this.cb_nom2.Size = new System.Drawing.Size(121, 21);
            this.cb_nom2.TabIndex = 3;
            // 
            // lb_prenom3
            // 
            this.lb_prenom3.FormattingEnabled = true;
            this.lb_prenom3.Items.AddRange(new object[] {
            "aaa",
            "bbb",
            "ddd",
            "ttt",
            "eee",
            "dddd",
            "yyyy",
            "uuuu",
            "ssss",
            "qqqqq",
            "kkkkkk"});
            this.lb_prenom3.Location = new System.Drawing.Point(308, 174);
            this.lb_prenom3.MultiColumn = true;
            this.lb_prenom3.Name = "lb_prenom3";
            this.lb_prenom3.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_prenom3.Size = new System.Drawing.Size(394, 69);
            this.lb_prenom3.TabIndex = 4;
            this.lb_prenom3.SelectedIndexChanged += new System.EventHandler(this.lb_prenom3_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_rechrcher
            // 
            this.bt_rechrcher.Location = new System.Drawing.Point(309, 266);
            this.bt_rechrcher.Name = "bt_rechrcher";
            this.bt_rechrcher.Size = new System.Drawing.Size(393, 23);
            this.bt_rechrcher.TabIndex = 6;
            this.bt_rechrcher.Text = "Rechercher";
            this.bt_rechrcher.UseVisualStyleBackColor = true;
            this.bt_rechrcher.Click += new System.EventHandler(this.bt_rechrcher_Click);
            // 
            // bt_afficher
            // 
            this.bt_afficher.Location = new System.Drawing.Point(24, 49);
            this.bt_afficher.Name = "bt_afficher";
            this.bt_afficher.Size = new System.Drawing.Size(120, 23);
            this.bt_afficher.TabIndex = 7;
            this.bt_afficher.Text = "Afficher";
            this.bt_afficher.UseVisualStyleBackColor = true;
            this.bt_afficher.Click += new System.EventHandler(this.bt_afficher_Click);
            // 
            // cb_nom4
            // 
            this.cb_nom4.FormattingEnabled = true;
            this.cb_nom4.Location = new System.Drawing.Point(581, 51);
            this.cb_nom4.Name = "cb_nom4";
            this.cb_nom4.Size = new System.Drawing.Size(121, 21);
            this.cb_nom4.TabIndex = 8;
            this.cb_nom4.SelectedIndexChanged += new System.EventHandler(this.cb_nom4_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(581, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManipLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cb_nom4);
            this.Controls.Add(this.bt_afficher);
            this.Controls.Add(this.bt_rechrcher);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lb_prenom3);
            this.Controls.Add(this.cb_nom2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_prenom);
            this.Controls.Add(this.cb_nom);
            this.Name = "ManipLists";
            this.Text = "ManipLists";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_nom;
        private System.Windows.Forms.ListBox lb_prenom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_nom2;
        private System.Windows.Forms.ListBox lb_prenom3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_rechrcher;
        private System.Windows.Forms.Button bt_afficher;
        private System.Windows.Forms.ComboBox cb_nom4;
        private System.Windows.Forms.Button button3;
    }
}