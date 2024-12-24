namespace randevu2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMusteri = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnMusteri
            // 
            btnMusteri.BackColor = Color.FromArgb(205, 155, 155);
            btnMusteri.Font = new Font("SimSun", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMusteri.ForeColor = SystemColors.ButtonHighlight;
            btnMusteri.Location = new Point(133, 79);
            btnMusteri.Name = "btnMusteri";
            btnMusteri.Size = new Size(268, 177);
            btnMusteri.TabIndex = 1;
            btnMusteri.Text = "MÜSTERILER";
            btnMusteri.UseVisualStyleBackColor = false;
            btnMusteri.Click += btnMusteri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(139, 95, 101);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(98, 23);
            label1.Name = "label1";
            label1.Size = new Size(341, 20);
            label1.TabIndex = 2;
            label1.Text = "HOŞ GELDİNİZ RANDEVU ALMAK İÇİN TIKLAYINIZ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(560, 344);
            Controls.Add(label1);
            Controls.Add(btnMusteri);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMusteri;
        private Label label1;
    }
}
