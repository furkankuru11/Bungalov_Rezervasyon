using BungalovRezervasyon.UI;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Data;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace BungalovRezervasyon.DL
{
    public static class DataLayer
    {

        static MySqlConnection conn = new MySqlConnection("Server=localhost;Database=bungalov;Uid=root;Pwd=fk7153004;");

        public static int MusteriEkle(Musteri m)
        {
            try
            {
                
                    if (conn.State != System.Data.ConnectionState.Open)
                    
                        conn.Open();



                m.ID=Guid.NewGuid();
                MySqlCommand komut = new MySqlCommand("bungalov_MusteriEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID); 
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soyad", m.Soyad);
                komut.Parameters.AddWithValue("@telefon", m.Telefon);
                komut.Parameters.AddWithValue("@email", m.Mail);
                komut.Parameters.AddWithValue("@adres", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null && conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
             
            }
            
        }




    

    internal static DataSet MusteriGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                { 
                    komut = new MySqlCommand("bungalov_MusteriHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                   
                }
                else
                {

                    komut = new MySqlCommand("bungalov_MusteriBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();    
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int MusteriGuncelle(Musteri m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("bungalov_MusteriGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soyad", m.Soyad);
                komut.Parameters.AddWithValue("@telefon", m.Telefon);
                komut.Parameters.AddWithValue("@email", m.Mail);
                komut.Parameters.AddWithValue("@adres", m.Adres);
                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int MusteriSil(string m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("bungalov_MusteriSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int OdaSil(string id)
        {
            try   
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("bungalov_OdaSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int OdaEkle(Oda u)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("bungalov_OdaEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", u.ID);
                komut.Parameters.AddWithValue("@numara",   u.Numara);
                komut.Parameters.AddWithValue("@tip", u.Tip);
                komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
      

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static DataSet OdaGetir(string v)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(v))
                {
                    komut = new MySqlCommand("bungalov_OdaHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {

                    komut = new MySqlCommand("bungalov_OdaBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", v);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int OdaGuncelle(Oda o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("bungalov_OdaGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", o.ID);
                komut.Parameters.AddWithValue("@numara", o.Numara);
                komut.Parameters.AddWithValue("@tip", o.Tip);   
                komut.Parameters.AddWithValue("@fiyat", o.Fiyat);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int RezervasyonEkle(Rezervasyon r)
        {
            try
            {
                r.ID = Guid.NewGuid();
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("bungalov_RezervasyonEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@rid", r.ID);
                komut.Parameters.AddWithValue("@mid", r.MusteriID);
                komut.Parameters.AddWithValue("@oid", r.OdaID);
                komut.Parameters.AddWithValue("@bas_tarih", r.BaslangicTarihi);
                komut.Parameters.AddWithValue("@bit_tarih", r.BitisTarihi);
                komut.Parameters.AddWithValue("@r_tutar", r.Tutar);


                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static DataSet RezervasyonDetay()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("bungalov_RezervasyonDetay", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int RezervasyonGuncelle(Rezervasyon rezervasyon)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("bungalov_RezervasyonGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@rid", rezervasyon.ID);
                komut.Parameters.AddWithValue("@mid", rezervasyon.MusteriID);
                komut.Parameters.AddWithValue("@oid", rezervasyon.OdaID);
                komut.Parameters.AddWithValue("@bas_tarih", rezervasyon.BaslangicTarihi);
                komut.Parameters.AddWithValue("@bit_tarih", rezervasyon.BitisTarihi);
                komut.Parameters.AddWithValue("@r_tutar", rezervasyon.Tutar);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int RezervasyonSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("bungalov_RezervasyonSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int OdemeEkle(Odeme odeme)
        {
            try
            {
                odeme.ID = Guid.NewGuid();
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("bungalov_OdemeEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", odeme.ID);
                komut.Parameters.AddWithValue("@mid", odeme.MusteriID);
                komut.Parameters.AddWithValue("@tutar", odeme.Tutar);
                komut.Parameters.AddWithValue("@tur", odeme.OdemeTuru);
                komut.Parameters.AddWithValue("@tarih", odeme.Tarih);


                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("bungalov_OdemeDetay", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;



                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int OdemeGuncelle(Odeme odeme)
        {
            try
            {
                odeme.ID = Guid.NewGuid();
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("bungalov_OdemeGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", odeme.ID); 
                komut.Parameters.AddWithValue("@mid", odeme.MusteriID);
                komut.Parameters.AddWithValue("@tutar", odeme.Tutar);
                komut.Parameters.AddWithValue("@tur", odeme.OdemeTuru);
                komut.Parameters.AddWithValue("@tarih", odeme.Tarih);


                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int OdemeSil(string o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("bungalov_OdemeSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", o);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }
    }
}

