using BungalovRezervasyon.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BungalovRezervasyon.BL
{
    public static class BLogic
    {
        public static bool MusteriEkle(Musteri m)
        {
            try
            {
                int res = DataLayer.MusteriEkle(m);
                return (res > 0);
            }catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :"+ ex.Message);
                return false;
            }
        }

        internal static DataSet MusteriGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.MusteriGetir(filtre);
                return ds;
            }catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :"+ex.Message);
                return null;
            }
        }

        internal static bool MusteriGuncelle(Musteri m)
        {

            try
            {
                int res = DataLayer.MusteriGuncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return false;
            }
        }

        internal static bool MusteriSil(string id)
        {
            try
            {
                int res = DataLayer.MusteriSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return false;
            }
        }

        internal static bool OdaEkle(Oda oda)
        {
            try
            {
                int res = DataLayer.OdaEkle(oda);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return false;
            }
        }

        internal static DataSet OdaGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.OdaGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return null;
            }
        }

        internal static bool OdaGuncelle(Oda o)
        {
            try
            {
                int res = DataLayer.OdaGuncelle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return false;
            }
        }

        internal static bool OdaSil(string id)
        {
            try
            {
                int res = DataLayer.OdaSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return false;
            }
        }
                internal static bool OdemeEkle(Odeme odeme)
        {
            try
            {
                int res = DataLayer.OdemeEkle(odeme);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return false;
            }
        }


        internal static DataSet OdemeDetay()
        {
            try
            {
                DataSet ds = DataLayer.OdemeDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return null;
            }
        }


        internal static bool OdemeGuncelle(Odeme o)
        {
            try
            {
                int res = DataLayer.OdemeGuncelle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return false;
            }
        }

        internal static bool OdemeSil(string o)
        {
            try
            {
                int res = DataLayer.OdemeSil(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return false;
            }
        }

        internal static DataSet RezervasyonDetay()
        {
            try
            {
                DataSet ds = DataLayer.RezervasyonDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return null;
            }
        }

        internal static bool RezervasyonEkle(Rezervasyon r)
        {
            try
            {
                int res = DataLayer.RezervasyonEkle(r);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return false;
            }
        }

        internal static bool RezervasyonGuncelle(Rezervasyon r)
        {
            try
            {
                int res = DataLayer.RezervasyonGuncelle(r);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return false;
            }
        }

        internal static bool RezervasyonSil(string id)
        {
            try
            {
                int res = DataLayer.RezervasyonSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return false;
            }
        }
    }
}
