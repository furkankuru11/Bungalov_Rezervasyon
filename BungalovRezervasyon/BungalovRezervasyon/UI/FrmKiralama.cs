using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BungalovRezervasyon.UI
{
    public partial class FrmKiralama : Form
    {
        public FrmKiralama()
        {
            InitializeComponent();
        }


        public Musteri musteri = new Musteri();
        public Oda Oda { get; set; }
        public Rezervasyon rezervasyon =new Rezervasyon();
        public bool Guncelleme { get;  set; }=false;

        private void Kiralama_Load(object sender, EventArgs e)
        {
            txtRezervasyonID.Text=rezervasyon.ID.ToString();
            if (Guncelleme)
            {
                txtMusteri.Text=rezervasyon.MusteriID.ToString();
                txtUrun.Text=rezervasyon.OdaID.ToString();
                totalFiyat.Value = (decimal)rezervasyon.Tutar;
                baslangicT.Text=rezervasyon.BaslangicTarihi.ToString();
                bitisT.Text=rezervasyon.BitisTarihi.ToString();
            }


        }

        private void urunSecButton_Click(object sender, EventArgs e)
        {
           Odalar frm =new Odalar();
 
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //Oda = frm.Oda;
                txtUrun.Text = frm.oda.ID.ToString();
                totalFiyat.Text=frm.oda.Fiyat.ToString();
            }
            
        }
        private void musteriSecButton_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {

                txtMusteri.Text = frm.musteri.ID.ToString();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            if (totalFiyat.Value == 0)
            {
                errorProvider1.SetError(totalFiyat, "Lütfen Fiyat Giriniz");
                totalFiyat.Focus();
                return;

            }
            else
            {
                errorProvider1.SetError(totalFiyat, "");
            }
            
            rezervasyon.ID=Guid.Parse(txtRezervasyonID.Text);
            rezervasyon.MusteriID = Guid.Parse(txtMusteri.Text);
            rezervasyon.OdaID = Guid.Parse(txtUrun.Text);
            rezervasyon.Tutar = (double)totalFiyat.Value;
            rezervasyon.BaslangicTarihi =baslangicT.Value;
            rezervasyon.BitisTarihi = bitisT.Value;
            
            
            
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}
    

