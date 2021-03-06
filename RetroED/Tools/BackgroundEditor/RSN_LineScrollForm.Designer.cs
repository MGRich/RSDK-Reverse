﻿namespace RetroED.Tools.BackgroundEditor
{
    partial class RSN_LineScrollForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeformNUD = new System.Windows.Forms.NumericUpDown();
            this.SPDNUD = new System.Windows.Forms.NumericUpDown();
            this.DeformLabel = new System.Windows.Forms.Label();
            this.LineNoNUD = new System.Windows.Forms.NumericUpDown();
            this.SPDLabel = new System.Windows.Forms.Label();
            this.LineNoLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeformNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPDNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineNoNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DeformNUD);
            this.panel1.Controls.Add(this.SPDNUD);
            this.panel1.Controls.Add(this.DeformLabel);
            this.panel1.Controls.Add(this.LineNoNUD);
            this.panel1.Controls.Add(this.SPDLabel);
            this.panel1.Controls.Add(this.LineNoLabel);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 187);
            this.panel1.TabIndex = 0;
            // 
            // DeformNUD
            // 
            this.DeformNUD.Location = new System.Drawing.Point(145, 93);
            this.DeformNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.DeformNUD.Name = "DeformNUD";
            this.DeformNUD.Size = new System.Drawing.Size(153, 22);
            this.DeformNUD.TabIndex = 15;
            this.DeformNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DeformNUD.ValueChanged += new System.EventHandler(this.CSPDNUD_ValueChanged);
            // 
            // SPDNUD
            // 
            this.SPDNUD.Location = new System.Drawing.Point(145, 62);
            this.SPDNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.SPDNUD.Name = "SPDNUD";
            this.SPDNUD.Size = new System.Drawing.Size(153, 22);
            this.SPDNUD.TabIndex = 13;
            this.SPDNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SPDNUD.ValueChanged += new System.EventHandler(this.SPDNUD_ValueChanged);
            // 
            // DeformLabel
            // 
            this.DeformLabel.AutoSize = true;
            this.DeformLabel.Location = new System.Drawing.Point(12, 98);
            this.DeformLabel.Name = "DeformLabel";
            this.DeformLabel.Size = new System.Drawing.Size(58, 17);
            this.DeformLabel.TabIndex = 14;
            this.DeformLabel.Text = "Deform:";
            // 
            // LineNoNUD
            // 
            this.LineNoNUD.Location = new System.Drawing.Point(145, 33);
            this.LineNoNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LineNoNUD.Name = "LineNoNUD";
            this.LineNoNUD.Size = new System.Drawing.Size(153, 22);
            this.LineNoNUD.TabIndex = 12;
            this.LineNoNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LineNoNUD.ValueChanged += new System.EventHandler(this.LineNoNUD_ValueChanged);
            // 
            // SPDLabel
            // 
            this.SPDLabel.AutoSize = true;
            this.SPDLabel.Location = new System.Drawing.Point(12, 64);
            this.SPDLabel.Name = "SPDLabel";
            this.SPDLabel.Size = new System.Drawing.Size(127, 17);
            this.SPDLabel.TabIndex = 11;
            this.SPDLabel.Text = "Constant H Speed:";
            // 
            // LineNoLabel
            // 
            this.LineNoLabel.AutoSize = true;
            this.LineNoLabel.Location = new System.Drawing.Point(12, 35);
            this.LineNoLabel.Name = "LineNoLabel";
            this.LineNoLabel.Size = new System.Drawing.Size(122, 17);
            this.LineNoLabel.TabIndex = 10;
            this.LineNoLabel.Text = "Relative H Speed:";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(203, 161);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(284, 161);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(145, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(153, 22);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Line Number:";
            // 
            // RSN_LineScrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 187);
            this.Controls.Add(this.panel1);
            this.Name = "RSN_LineScrollForm";
            this.Text = "Line-Scroll Properties";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeformNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPDNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineNoNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.NumericUpDown DeformNUD;
        private System.Windows.Forms.NumericUpDown SPDNUD;
        private System.Windows.Forms.Label DeformLabel;
        private System.Windows.Forms.NumericUpDown LineNoNUD;
        private System.Windows.Forms.Label SPDLabel;
        private System.Windows.Forms.Label LineNoLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}