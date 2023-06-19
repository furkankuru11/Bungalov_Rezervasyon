using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungalovRezervasyon
{
    public class Musteri
    {
       

        public Guid ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        
        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }

    }
    public class Rezervasyon
    {
        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        public Guid OdaID { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public double Tutar { get; set; }
    }
    public class Oda
    {

        public Guid ID { get; set; }
        public double Numara { get; set; }
        public string Tip { get; set; }
        public double Fiyat { get; set; }
        public override string ToString()
        {
            return $"{Tip}{Fiyat}";
        }


    }

    public class Odeme
    {
        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        public DateTime Tarih { get; set; }
        public string OdemeTuru { get; set; }

        public double Tutar { get; set; }


    }
    public class KiralamaGecmisi
    {
        public Guid ID { get; set; }
        public string MusteriID { get; set; }
        public string OdaID { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
    }
}
