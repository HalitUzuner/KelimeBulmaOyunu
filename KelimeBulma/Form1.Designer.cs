﻿namespace KelimeBulma
{
    partial class Form1
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
            this.btnHarfVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHarfVer
            // 
            this.btnHarfVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHarfVer.Location = new System.Drawing.Point(12, 109);
            this.btnHarfVer.Name = "btnHarfVer";
            this.btnHarfVer.Size = new System.Drawing.Size(73, 56);
            this.btnHarfVer.TabIndex = 0;
            this.btnHarfVer.Text = "Harf Al";
            this.btnHarfVer.UseVisualStyleBackColor = true;
            this.btnHarfVer.Click += new System.EventHandler(this.btnHarfVer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 363);
            this.Controls.Add(this.btnHarfVer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHarfVer;

    }
}

