﻿namespace tubes_alpro
{
    partial class METODE_PEMBAYARAN
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(315, 50);
            label1.Name = "label1";
            label1.Size = new Size(279, 35);
            label1.TabIndex = 0;
            label1.Text = "METODE PEMBAYARAN ";
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(128, 64, 0);
            button1.Location = new Point(273, 146);
            button1.Name = "button1";
            button1.Size = new Size(367, 40);
            button1.TabIndex = 1;
            button1.Text = "CASH";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Bisque;
            button2.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(128, 64, 0);
            button2.Location = new Point(273, 223);
            button2.Name = "button2";
            button2.Size = new Size(367, 40);
            button2.TabIndex = 2;
            button2.Text = "QRIS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // METODE_PEMBAYARAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(909, 405);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "METODE_PEMBAYARAN";
            Text = "METODE_PEMBAYARAN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}