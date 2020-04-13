namespace AppWF1
{
    partial class FManipProp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ck_gras = new System.Windows.Forms.CheckBox();
            this.ch_italique = new System.Windows.Forms.CheckBox();
            this.ch_soulinge = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(530, 134);
            this.textBox1.TabIndex = 0;
            // 
            // ck_gras
            // 
            this.ck_gras.AutoSize = true;
            this.ck_gras.Location = new System.Drawing.Point(200, 167);
            this.ck_gras.Name = "ck_gras";
            this.ck_gras.Size = new System.Drawing.Size(48, 17);
            this.ck_gras.TabIndex = 1;
            this.ck_gras.Text = "Gras";
            this.ck_gras.UseVisualStyleBackColor = true;
            // 
            // ch_italique
            // 
            this.ch_italique.AutoSize = true;
            this.ch_italique.Location = new System.Drawing.Point(114, 167);
            this.ch_italique.Name = "ch_italique";
            this.ch_italique.Size = new System.Drawing.Size(60, 17);
            this.ch_italique.TabIndex = 2;
            this.ch_italique.Text = "Italique";
            this.ch_italique.UseVisualStyleBackColor = true;
            // 
            // ch_soulinge
            // 
            this.ch_soulinge.AutoSize = true;
            this.ch_soulinge.Location = new System.Drawing.Point(28, 167);
            this.ch_soulinge.Name = "ch_soulinge";
            this.ch_soulinge.Size = new System.Drawing.Size(67, 17);
            this.ch_soulinge.TabIndex = 3;
            this.ch_soulinge.Text = "Souligné";
            this.ch_soulinge.UseVisualStyleBackColor = true;
            // 
            // FManipProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 319);
            this.Controls.Add(this.ch_soulinge);
            this.Controls.Add(this.ch_italique);
            this.Controls.Add(this.ck_gras);
            this.Controls.Add(this.textBox1);
            this.Name = "FManipProp";
            this.Text = "FManipProp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ck_gras;
        private System.Windows.Forms.CheckBox ch_italique;
        private System.Windows.Forms.CheckBox ch_soulinge;
    }
}