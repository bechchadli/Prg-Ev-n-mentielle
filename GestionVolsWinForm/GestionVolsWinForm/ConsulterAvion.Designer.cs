﻿namespace GestionVolsWinForm
{
    partial class ConsulterAvion
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
            this.treeViewAvion = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewAvion
            // 
            this.treeViewAvion.Location = new System.Drawing.Point(0, 1);
            this.treeViewAvion.Name = "treeViewAvion";
            this.treeViewAvion.Size = new System.Drawing.Size(131, 452);
            this.treeViewAvion.TabIndex = 0;
            // 
            // ConsulterAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.treeViewAvion);
            this.Name = "ConsulterAvion";
            this.Text = "ConsulterAvion";
            this.Load += new System.EventHandler(this.ConsulterAvion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewAvion;
    }
}