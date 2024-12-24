using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace randevu2
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        public static class DatabaseHelper
        {
            private static readonly string ConnectionString = "Host=localhost;Port=5432;Database=randevu2;Username=postgres;Password=0000;Pooling=true;Timeout=30;CommandTimeout=30;";

            public static NpgsqlConnection GetConnection()
            {
                try
                {
                    var connection = new NpgsqlConnection(ConnectionString);
                    return connection;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Veritabanı bağlantısı kurulamadı: {ex.Message}");
                    throw;
                }
            }
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("INSERT INTO Musteri (Isim, IletisimBilgisi,  SadakatPuani) VALUES (@isim, @iletisim, @sadakat)", conn))
                    {
                        cmd.Parameters.AddWithValue("isim", txtMusteriAdi.Text);
                        cmd.Parameters.AddWithValue("iletisim", richTextBox1.Text);
                        cmd.Parameters.AddWithValue("sadakat", (int)nudSadakatPuani.Value);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Müşteri başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            


            }
        }


        private void LoadCustomersAndCheckTrigger()
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=0000;Database=randevu2";

            // Müşteri tablosundan verileri çekmek için SQL sorgusu
            string musterilerSorgu = @"
        SELECT 
            ""musteriid"" AS ""Müşteri ID"",
            ""isim"" AS ""İsim"",
            ""iletisimbilgisi"" AS ""İletişim Bilgisi"",
            ""sadakatpuani"" AS ""Sadakat Puanı""
        FROM ""musteri"";
    ";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Müşteri listesini çek
                    using (NpgsqlCommand cmd = new NpgsqlCommand(musterilerSorgu, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            dgvMusteriler.DataSource = table;
                        }
                    }

                    // Sadakat puanı 1 olan müşterileri kontrol et
                    CheckLowLoyaltyCustomers(conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckLowLoyaltyCustomers(NpgsqlConnection conn)
        {
            // Sadakat puanı 1 olan müşterileri kontrol eden sorgu
            string lowLoyaltyQuery = @"
        SELECT 
            ""isim""
        FROM ""musteri""
        WHERE ""sadakatpuani"" = 1;
    ";

            using (NpgsqlCommand cmd = new NpgsqlCommand(lowLoyaltyQuery, conn))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string customerName = reader["isim"].ToString();
                        MessageBox.Show($"Sadakat puanı 1 olan müşteri eklendi: {customerName}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }



        private void SadakatPuaniEkle(int musteriId, int puan)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT SadakatPuaniGuncelle(@musteriId, @puan)", conn))
                    {
                        cmd.Parameters.AddWithValue("musteriId", musteriId);
                        cmd.Parameters.AddWithValue("puan", puan);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sadakat puanı başarıyla güncellendi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var da = new NpgsqlDataAdapter("SELECT * FROM Musteri", conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMusteriler.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("DELETE FROM Musteri WHERE MusteriID = @id", conn))
                    {
                        if (int.TryParse(txtMusteriID.Text, out int musteriId))
                        {
                            cmd.Parameters.AddWithValue("id", musteriId);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Müşteri başarıyla silindi.");
                            }
                            else
                            {
                                MessageBox.Show("Silinecek müşteri bulunamadı.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Geçerli bir Müşteri ID'si girin.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        private void btnHesaplaSadakat_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtMusteriID.Text, out int musteriId))
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand("SELECT SadakatPuani FROM Musteri WHERE MusteriID = @id", conn))
                        {
                            cmd.Parameters.AddWithValue("id", musteriId);
                            var result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                MessageBox.Show("Sadakat Puanı: " + result.ToString());
                            }
                            else
                            {
                                MessageBox.Show("Sadakat puanı bulunamadı.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}");
                    }
                }
            }

        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("UPDATE Musteri SET Isim = @isim, IletisimBilgisi = @iletisim, SadakatPuani = @sadakat WHERE MusteriID = @id", conn))
                    {
                        if (int.TryParse(txtMusteriID.Text, out int musteriId))
                        {
                            cmd.Parameters.AddWithValue("isim", txtMusteriAdi.Text);
                            cmd.Parameters.AddWithValue("iletisim", richTextBox1.Text);
                            cmd.Parameters.AddWithValue("sadakat", (int)nudSadakatPuani.Value);
                            cmd.Parameters.AddWithValue("id", musteriId);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Müşteri başarıyla güncellendi.");
                            }
                            else
                            {
                                MessageBox.Show("Güncellenecek müşteri bulunamadı.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Geçerli bir Müşteri ID'si girin.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        private void RandevuTamamlandigindaFaturaOlustur(int randevuId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT FaturaOlustur(@RandevuID)", conn))
                    {
                        cmd.Parameters.AddWithValue("RandevuID", randevuId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Fatura oluşturuldu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        private void KritikStokKontrol(int seviye)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM KritikStokKontrolu(@seviye)", conn))
                    {
                        cmd.Parameters.AddWithValue("seviye", seviye);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show($"Ürün: {reader["Ad"]}, Stok: {reader["StokMiktari"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        private void CalisanIsYukuHesapla(DateTime tarih)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM CalisanIsYuku(@tarih)", conn))
                    {
                        cmd.Parameters.AddWithValue("tarih", tarih);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show($"Çalışan: {reader["CalisanAd"]}, İş Yükü: {reader["IsYuku"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }
    }
}

