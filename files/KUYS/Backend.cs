using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using KUYS;

namespace Backend
{
    // Kayıt işlemleriyle ilgili gerekli bütün fonksiyonlar bu sınıfın içinde yer alır
    public class Kayit
    {
        // TODO: Hata Ayıklama Düzelt!
        // Veri tabanına kayıt girdisi eklemeyi sağlayan fonksiyon
        public static void Ekle(string Id, string Ad, string Sinif, string Numara, string KitapAdi, string KitapYazari, string Kitaplik, string KitapRafi, string KitapAlinmaTarihi, string KitapSonTeslimTarihi, string TeslimDurumu)
        {
            // Veri tabanı bağlantılarını yap
            string dbPath = "database/kutuphane.db";
            string connectionStrings = $"Data Source={dbPath};Version=3";
            using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
            {
                // Hata ayıklamak için try-catch yöntemini kullan
                try
                {
                    // Veri tabanı bağlantısı oluşturulduktan sonra sorguyu oluştur
                    connection.Open();
                    string AddQuery = $"INSERT INTO Kayıt ('ID', 'Ad - Soyad', 'Sınıf', 'Numara', 'Kitap Adı', 'Kitap Yazarı', 'Kitaplık', 'Kitap Rafı', 'Kitap Alınma Tarihi', 'Kitap Son Teslim Tarihi', 'Teslim Durumu') VALUES ('{Id}', '{Ad}', '{Sinif}', '{Numara}', '{KitapAdi}', '{KitapYazari}', '{Kitaplik}', '{KitapRafi}', '{KitapAlinmaTarihi}', '{KitapSonTeslimTarihi}', '{TeslimDurumu}')";
                    using (SQLiteCommand command = new SQLiteCommand(AddQuery, connection))
                    {
                        // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemler yap
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, e.Source);
                }
            }
        }

        // Kayıt güncelleme ile ilgili fonksiyonların bulunduğu sınıf
        public class Guncelle
        {
            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir kayıt girdisinin ID değerini güncellemeyi sağlayan fonksiyon
            public static void Id(string EskiId, string YeniId)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısı oluşturulduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateIdQuery = $"UPDATE Kayıt SET ID = '{YeniId}' WHERE ID = '{EskiId}'";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateIdQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }

            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir kayıt girdisinin İsim-Soyisim değerini güncellemeyi sağlayan fonksiyon
            public static void Ad(string Id, string YeniAd)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısı oluşturulduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateIsimSoyisimQuery = $"UPDATE Kayıt SET 'Ad - Soyad' = '{YeniAd}' WHERE ID = '{Id}'";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateIsimSoyisimQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }

            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir kayıt girdisinin Sınıf değerini güncellemeyi sağlayan fonksiyon
            public static void Sinif(string Id, string YeniSinif)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısını oluşturduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateSinifQuery = $"UPDATE Kayıt SET 'Sınıf' = '{YeniSinif}' WHERE ID = '{Id}'";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateSinifQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }

            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir kayıt girdisinin Numara değerini güncellemeyi sağlayan fonksiyon
            public static void Numara(string Id, string YeniNumara)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısını oluşturduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateNumaraQuery = $"UPDATE Kayıt SET 'Numara' = '{YeniNumara}' WHERE ID = '{Id}'";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateNumaraQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }

            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir kayıt girdisinin Kitap Adı değerini güncellemeyi sağlayan fonksiyon
            public static void KitapAdi(string Id, string YeniKitapAdi)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısını oluşturduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateKitapAdiQuery = $"UPDATE Kayıt SET 'Kitap Adı' = '{YeniKitapAdi}' WHERE ID = '{Id}'";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateKitapAdiQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }

            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir kayıt girdisinin Kitap Yazarı değerini güncellemeyi sağlayan fonksiyon
            public static void KitapYazari(string Id, string YeniKitapYazari)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısını oluşturduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateKitapYazariQuery = $"UPDATE Kayıt SET 'Kitap Yazarı' = '{YeniKitapYazari}' WHERE ID = '{Id}'";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateKitapYazariQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }

            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir kayıt girdisinin Kitaplık değerini güncellemeyi sağlayan fonksiyon
            public static void Kitaplik(string Id, string YeniKitaplik)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısını oluşturduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateKitaplikQuery = $"UPDATE Kayıt SET 'Kitaplık' = '{YeniKitaplik}' WHERE ID = '{Id}'";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateKitaplikQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }

            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir kayıt girdisinin Kitap Rafı değerini güncellemeyi sağlayan fonksiyon
            public static void KitapRafi(string Id, string YeniKitapRafi)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısını oluşturduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateKitapRafiQuery = $"UPDATE Kayıt SET 'Kitap Rafı' = '{YeniKitapRafi}' WHERE ID = '{Id}'";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateKitapRafiQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }

            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir kayıt girdisinin Kitap Son Teslim Tarihi değerini güncellemeyi sağlayan fonksiyon
            public static void SonTeslimTarihi(string Id, string YeniSonTeslimTarihi)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısını oluşturduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateSonTeslimTarihiQuery = $"UPDATE Kayıt SET 'Kitap Son Teslim Tarihi' = '{YeniSonTeslimTarihi}' WHERE ID = '{Id}'";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateSonTeslimTarihiQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }

            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir kayıt girdisinin Teslim Durumu değerini güncellemeyi sağlayan fonksiyon
            public static void TeslimDurumu(string Id, string YeniTeslimDurumu)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısını oluşturduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateTeslimDurumuQuery = $"UPDATE Kayıt SET 'Teslim Durumu' = '{YeniTeslimDurumu}' WHERE ID = '{Id}'";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateTeslimDurumuQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }
        }

        // TODO: Hata Ayıklama Düzelt!
        // Veri tabanından kayıt girdisi silmeyi sağlayan fonksiyon
        public static void Sil(string Id)
        {
            // Veri tabanı bağlantılarını yap
            string dbPath = "database/kutuphane.db";
            string connectionStrings = $"Data Source={dbPath};Version=3";
            using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
            {
                // Hata yakalamak için try-catch yöntemini kullan
                try
                {
                    // Veri tabanı bağlantısı oluşturulduktan sonra sorguyu oluştur
                    connection.Open();
                    string DeleteQuery = $"DELETE FROM Kayıt WHERE ID = '{Id}'";
                    using (SQLiteCommand command = new SQLiteCommand(DeleteQuery, connection))
                    {
                        // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemler yap
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, e.Source);
                }
            }
        }
    }

    public class Kitap
    {
        // TODO: Hata Ayıklama Düzelt!
        // Veri tabanına Kitap girdisi eklemeyi sağlayan fonksiyon
        public static void Ekle(string Id, string KitapAdi, string KitapYazari, string Kitaplik, string KitapRafi)
        {
            // Veri tabanı bağlantılarını yap
            string dbPath = "database/kutuphane.db";
            string connectionStrings = $"Data Source={dbPath};Version=3";
            using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
            {
                // Hata ayıklamak için try-catch yöntemini kullan
                try
                {
                    // Veri tabanı bağlantısı oluşturulduktan sonra sorguyu oluştur
                    connection.Open();
                    string AddQuery = $"INSERT INTO Kitap ('ID', 'Kitap Adı', 'Kitap Yazarı', 'Kitaplık', 'Kitap Rafı') VALUES ('{Id}', '{KitapAdi}', '{KitapYazari}', '{Kitaplik}', '{KitapRafi}')";
                    using (SQLiteCommand command = new SQLiteCommand(AddQuery, connection))
                    {
                        // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemler yap
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, e.Source);
                }
            }
        }

        // Kitap güncelleme ile ilgili fonksiyonların bulunduğu sınıf
        public class Guncelle
        {
            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir Kitap girdisinin ID değerini güncellemeyi sağlayan fonksiyon
            public static void Id(string EskiId, string YeniId)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısı oluşturulduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateIdQuery = $"""UPDATE Kitap SET "ID" = '{YeniId}' WHERE "ID" = '{EskiId}'""";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateIdQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }

            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir Kitap girdisinin Kitap Adı değerini güncellemeyi sağlayan fonksiyon
            public static void KitapAdi(string Id, string YeniKitapAdi)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısını oluşturduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateKitapAdiQuery = $"""UPDATE Kitap SET "Kitap Adı" = '{YeniKitapAdi}' WHERE "ID" = '{Id}'""";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateKitapAdiQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }

            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir Kitap girdisinin Kitap Yazarı değerini güncellemeyi sağlayan fonksiyon
            public static void KitapYazari(string Id, string YeniKitapYazari)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısını oluşturduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateKitapYazariQuery = $"""UPDATE Kitap SET "Kitap Yazarı" = '{YeniKitapYazari}' WHERE "ID" = '{Id}'""";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateKitapYazariQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }

            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir Kitap girdisinin Kitaplık değerini güncellemeyi sağlayan fonksiyon
            public static void Kitaplik(string Id, string YeniKitaplik)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısını oluşturduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateKitaplikQuery = $"""UPDATE Kitap SET "Kitaplık" = '{YeniKitaplik}' WHERE "ID" = '{Id}'""";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateKitaplikQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }

            // TODO: Hata Ayıklama Düzelt!
            // Veri tabanındaki bir Kitap girdisinin Kitap Rafı değerini güncellemeyi sağlayan fonksiyon
            public static void KitapRafi(string Id, string YeniKitapRafi)
            {
                // Veri tabanı bağlantılarını yap
                string dbPath = "database/kutuphane.db";
                string connectionStrings = $"Data Source={dbPath};Version=3";
                using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
                {
                    // Hata ayıklamak için try-catch yöntemini kullan
                    try
                    {
                        // Veri tabanı bağlantısını oluşturduktan sonra sorguyu oluştur
                        connection.Open();
                        string UpdateKitapRafiQuery = $"""UPDATE Kitap SET "Kitap Rafı" = '{YeniKitapRafi}' WHERE "ID" = '{Id}'""";
                        using (SQLiteCommand command = new SQLiteCommand(UpdateKitapRafiQuery, connection))
                        {
                            // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemleri yap
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, e.Source);
                    }
                }
            }
        }

        // TODO: Hata Ayıklama Düzelt!
        // Veri tabanından Kitap girdisi silmeyi sağlayan fonksiyon
        public static void Sil(string Id)
        {
            // Veri tabanı bağlantılarını yap
            string dbPath = "database/kutuphane.db";
            string connectionStrings = $"Data Source={dbPath};Version=3";
            using (SQLiteConnection connection = new SQLiteConnection(connectionStrings))
            {
                // Hata yakalamak için try-catch yöntemini kullan
                try
                {
                    // Veri tabanı bağlantısı oluşturulduktan sonra sorguyu oluştur
                    connection.Open();
                    string DeleteQuery = $"""DELETE FROM Kitap WHERE "ID" = '{Id}'""";
                    using (SQLiteCommand command = new SQLiteCommand(DeleteQuery, connection))
                    {
                        // Oluşturulan sorguyu çalıştır ve bağlantıyı kapat
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                // Hata burada yakalanır. Hata yakalandıktan sonra gerekli işlemler yap
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, e.Source);
                }
            }
        }
    }
}