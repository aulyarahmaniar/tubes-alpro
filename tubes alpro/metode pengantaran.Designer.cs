namespace tubes_alpro
{
    partial class metode_pengantaran
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(128, 64, 0);
            button1.Location = new Point(293, 150);
            button1.Margin = new Padding(3, 5, 3, 5);
            button1.Name = "button1";
            button1.Size = new Size(367, 48);
            button1.TabIndex = 1;
            button1.Text = "TAKE AWAY";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Bisque;
            button2.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(128, 64, 0);
            button2.Location = new Point(293, 228);
            button2.Margin = new Padding(3, 5, 3, 5);
            button2.Name = "button2";
            button2.Size = new Size(367, 48);
            button2.TabIndex = 2;
            button2.Text = "DINE IN";
            button2.UseVisualStyleBackColor = false;
            // 
            // metode_pengantaran
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(925, 444);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Sitka Heading", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 5, 3, 5);
            Name = "metode_pengantaran";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "metode_pengantaran";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
    }
}