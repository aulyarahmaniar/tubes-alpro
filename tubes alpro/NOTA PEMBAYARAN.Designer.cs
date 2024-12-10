namespace tubes_alpro
{
    partial class NOTA_PEMBAYARAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NOTA_PEMBAYARAN));
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(422, 52);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(87, 114);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(715, 270);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(386, 9);
            label2.Name = "label2";
            label2.Size = new Size(111, 35);
            label2.TabIndex = 2;
            label2.Text = "RECEIPT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(373, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 64, 0);
            label3.Location = new Point(770, 9);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 4;
            label3.Text = "Back to home page";
            // 
            // NOTA_PEMBAYARAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(909, 405);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NOTA_PEMBAYARAN";
            Text = "NOTA_PEMBAYARAN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}