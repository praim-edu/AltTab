﻿namespace com.praim.altTab
{
    partial class StandardForm
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
            this.SuspendLayout();
            // 
            // StandardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::com.praim.altTab.Properties.Resources.Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(85, 85);
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StandardForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CSWinFormLayeredWindow";
            this.TopMost = true;
            this.Click += new System.EventHandler(this.StandardForm_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StandardForm_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

