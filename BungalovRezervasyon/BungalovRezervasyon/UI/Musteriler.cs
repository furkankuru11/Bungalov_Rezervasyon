using BungalovRezervasyon.BL;
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
    public partial class Musteriler : Form
    {
        public bool Guncelle { get; set; } = false; 
        public Musteri musteri=new Musteri();

        public Musteriler()
        {
            InitializeComponent();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            

            DataSet ds = BLogic.MusteriGetir("");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
            
        }
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Müşteri Ekle",
                musteri = new Musteri()
                {
                    ID = Guid.NewGuid(),
                },
            };
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriEkle(frmMusteri.musteri);
                if (b)
                {

                    DataSet ds = BLogic.MusteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }



            }
        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
           DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Müşteri Güncelle",
                Guncelle = true,
                musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString(),
                }
        };

            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriGuncelle(frmMusteri.musteri);
                if (b)
                {

                    DataSet ds = BLogic.MusteriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }



            }

        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MusteriGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var id = row.Cells[0].Value.ToString();
            var sonuc = MessageBox.Show("Seçili Kayıt Silinsin mi ?", "Onayla", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriSil(id);


                if (b)
                {
                    DataSet ds = BLogic.MusteriGetir("");
                    if (ds != null)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }




                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
           
                musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString(),
                };
                DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}
