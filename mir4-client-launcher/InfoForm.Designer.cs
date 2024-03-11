﻿namespace Mir_4_Launcher
{
    partial class InfoForm
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
            InfoCloseImage = new PictureBox();
            SpecialThanksLabel = new Label();
            NyylLabel = new Label();
            Firev2Label = new Label();
            MentalLabel = new Label();
            GurgelLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)InfoCloseImage).BeginInit();
            SuspendLayout();
            // 
            // InfoCloseImage
            // 
            InfoCloseImage.BackColor = Color.Transparent;
            InfoCloseImage.Image = Properties.Resources.Close;
            InfoCloseImage.Location = new Point(584, 12);
            InfoCloseImage.Name = "InfoCloseImage";
            InfoCloseImage.Size = new Size(11, 10);
            InfoCloseImage.TabIndex = 4;
            InfoCloseImage.TabStop = false;
            InfoCloseImage.Click += InfoCloseImage_Click;
            // 
            // SpecialThanksLabel
            // 
            SpecialThanksLabel.AutoSize = true;
            SpecialThanksLabel.BackColor = Color.Transparent;
            SpecialThanksLabel.Font = new Font("Segoe UI", 25F);
            SpecialThanksLabel.Location = new Point(183, -2);
            SpecialThanksLabel.Name = "SpecialThanksLabel";
            SpecialThanksLabel.Size = new Size(238, 46);
            SpecialThanksLabel.TabIndex = 5;
            SpecialThanksLabel.Text = "Special Thanks";
            // 
            // NyylLabel
            // 
            NyylLabel.AutoSize = true;
            NyylLabel.Font = new Font("Segoe UI", 15F);
            NyylLabel.Location = new Point(274, 55);
            NyylLabel.Name = "NyylLabel";
            NyylLabel.Size = new Size(52, 28);
            NyylLabel.TabIndex = 6;
            NyylLabel.Text = "Nyyl";
            NyylLabel.Click += NyylLabel_Click;
            // 
            // Firev2Label
            // 
            Firev2Label.AutoSize = true;
            Firev2Label.Font = new Font("Segoe UI", 15F);
            Firev2Label.Location = new Point(270, 105);
            Firev2Label.Name = "Firev2Label";
            Firev2Label.Size = new Size(65, 28);
            Firev2Label.TabIndex = 7;
            Firev2Label.Text = "Firev2";
            Firev2Label.Click += Firev2Label_Click;
            // 
            // MentalLabel
            // 
            MentalLabel.AutoSize = true;
            MentalLabel.Font = new Font("Segoe UI", 15F);
            MentalLabel.Location = new Point(265, 155);
            MentalLabel.Name = "MentalLabel";
            MentalLabel.Size = new Size(77, 28);
            MentalLabel.TabIndex = 9;
            MentalLabel.Text = "MentaL";
            MentalLabel.Click += MentalLabel_Click;
            // 
            // GurgelLabel
            // 
            GurgelLabel.AutoSize = true;
            GurgelLabel.Font = new Font("Segoe UI", 15F);
            GurgelLabel.Location = new Point(265, 205);
            GurgelLabel.Name = "GurgelLabel";
            GurgelLabel.Size = new Size(71, 28);
            GurgelLabel.TabIndex = 10;
            GurgelLabel.Text = "Gurgel";
            GurgelLabel.Click += GurgelLabel_Click;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(607, 262);
            Controls.Add(GurgelLabel);
            Controls.Add(MentalLabel);
            Controls.Add(Firev2Label);
            Controls.Add(NyylLabel);
            Controls.Add(SpecialThanksLabel);
            Controls.Add(InfoCloseImage);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "InfoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InfoForm";
            ((System.ComponentModel.ISupportInitialize)InfoCloseImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox InfoCloseImage;
        private Label SpecialThanksLabel;
        private Label NyylLabel;
        private Label Firev2Label;
        private Label MentalLabel;
        private Label GurgelLabel;
    }
}