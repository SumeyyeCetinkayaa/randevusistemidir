namespace randevu2
{
    partial class CustomerForm
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
            txtMusteriAdi = new TextBox();
            nudSadakatPuani = new NumericUpDown();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnListele = new Button();
            btnHesaplaSadakat = new Button();
            txtMusteriID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            dgvMusteriler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudSadakatPuani).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // txtMusteriAdi
            // 
            txtMusteriAdi.AccessibleDescription = "";
            txtMusteriAdi.AccessibleName = "";
            txtMusteriAdi.Location = new Point(275, 168);
            txtMusteriAdi.Name = "txtMusteriAdi";
            txtMusteriAdi.Size = new Size(193, 27);
            txtMusteriAdi.TabIndex = 0;
            // 
            // nudSadakatPuani
            // 
            nudSadakatPuani.Location = new Point(32, 442);
            nudSadakatPuani.Name = "nudSadakatPuani";
            nudSadakatPuani.Size = new Size(190, 27);
            nudSadakatPuani.TabIndex = 2;
            nudSadakatPuani.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(205, 155, 155);
            btnEkle.Font = new Font("SimSun", 12F);
            btnEkle.ForeColor = SystemColors.ButtonHighlight;
            btnEkle.Location = new Point(712, 349);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(124, 45);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click_1;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(205, 155, 155);
            btnGuncelle.Font = new Font("SimSun", 12F);
            btnGuncelle.ForeColor = SystemColors.ButtonHighlight;
            btnGuncelle.Location = new Point(712, 408);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(124, 45);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(205, 155, 155);
            btnSil.Font = new Font("SimSun", 12F);
            btnSil.ForeColor = SystemColors.ButtonHighlight;
            btnSil.Location = new Point(954, 408);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(124, 45);
            btnSil.TabIndex = 6;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click_1;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.FromArgb(205, 155, 155);
            btnListele.Font = new Font("SimSun", 12F);
            btnListele.ForeColor = SystemColors.ButtonHighlight;
            btnListele.Location = new Point(954, 347);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(124, 45);
            btnListele.TabIndex = 7;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click_1;
            // 
            // btnHesaplaSadakat
            // 
            btnHesaplaSadakat.Font = new Font("SimSun", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHesaplaSadakat.Location = new Point(32, 367);
            btnHesaplaSadakat.Name = "btnHesaplaSadakat";
            btnHesaplaSadakat.Size = new Size(190, 56);
            btnHesaplaSadakat.TabIndex = 8;
            btnHesaplaSadakat.Text = "SADAKAT PUANI";
            btnHesaplaSadakat.UseVisualStyleBackColor = true;
            btnHesaplaSadakat.Click += btnHesaplaSadakat_Click_1;
            // 
            // txtMusteriID
            // 
            txtMusteriID.Location = new Point(275, 119);
            txtMusteriID.Name = "txtMusteriID";
            txtMusteriID.Size = new Size(193, 27);
            txtMusteriID.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 13.2000008F);
            label1.Location = new Point(22, 126);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 10;
            label1.Text = "musteriID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 13.2000008F);
            label2.Location = new Point(22, 172);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 11;
            label2.Text = "Ad/Soyad:  ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 13.2000008F);
            label3.Location = new Point(22, 220);
            label3.Name = "label3";
            label3.Size = new Size(250, 23);
            label3.TabIndex = 12;
            label3.Text = "Iletisim Bilgileri: ";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(275, 220);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(193, 119);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.BackgroundColor = Color.FromArgb(139, 95, 101);
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(607, 38);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.Size = new Size(567, 206);
            dgvMusteriler.TabIndex = 14;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1221, 560);
            Controls.Add(dgvMusteriler);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMusteriID);
            Controls.Add(btnHesaplaSadakat);
            Controls.Add(btnListele);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(nudSadakatPuani);
            Controls.Add(txtMusteriAdi);
            Name = "CustomerForm";
            Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)nudSadakatPuani).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMusteriAdi;
        private NumericUpDown nudSadakatPuani;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnListele;
        private Button btnHesaplaSadakat;
        private TextBox txtMusteriID;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private DataGridView dgvMusteriler;
    }
}