using BungalovRezervasyon.BL;
using BungalovRezervasyon.DL;
using BungalovRezervasyon.UI;
using System;
using System.Data;
using System.Windows.Forms;


namespace BungalovRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Musteriler mf = new Musteriler();
        Odalar of = new Odalar();
        public bool Guncelle { get; set; } =false;
        public Odeme odeme=new Odeme();
        public Rezervasyon  rezervasyon=new Rezervasyon();
        private void btnOdalar_Click(object sender, EventArgs e)
        {
            of.ShowDialog();
        }
        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.RezervasyonDetay();
            if(ds!=null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        internal static DataSet MusteriGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.MusteriGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu :" + ex.Message);
                return null;
            }
        }

        private void odaKirala_Click(object sender, EventArgs e)
        {
            FrmKiralama frm = new FrmKiralama();
            {
                Text = "Satış Yap";
                rezervasyon = new Rezervasyon()
                {
                    ID = Guid.NewGuid(),
                };

            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
            tekrar:
                var sonuc = frm.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.RezervasyonEkle(frm.rezervasyon);
                     if (b)
                     {

                        DataSet ds = BLogic.RezervasyonDetay();
                        if (ds != null)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                        }

                    }
                     else
                     
                         goto tekrar;
                     

                }
            }
        }

        private void btnRezervasyonDuzenle_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmKiralama frm = new FrmKiralama();
            {
                Text = "Rezervasyon Güncelle";
                Guncelle = true;
                rezervasyon = new Rezervasyon()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    OdaID = Guid.Parse(row.Cells[2].Value.ToString()),
                    Tutar = double.Parse(row.Cells[3].Value.ToString()),
                    BaslangicTarihi =DateTime.Parse( row.Cells[4].Value.ToString()),
                    BitisTarihi =DateTime.Parse( row.Cells[5].Value.ToString()),
                };
                var sonuc = frm.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.RezervasyonGuncelle(frm.rezervasyon);
                    if (b)
                    {

                        row.Cells[6].Value = frm.rezervasyon.Tutar.ToString();
                        row.Cells[7].Value = frm.rezervasyon.BaslangicTarihi.ToString();
                        row.Cells[8].Value = frm.rezervasyon.BitisTarihi.ToString() ;
                        
                    }
                }
            }
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var id = row.Cells[0].Value.ToString();
            var sonuc = MessageBox.Show("Seçili Kayıt Silinsin mi ?", "Onayla", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.RezervasyonSil(id);


                if (b)
                {
                    DataSet ds = BLogic.RezervasyonDetay();
                    if (ds != null)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }




                }
            }
        }


        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
           
                FrmOdeme frm = new FrmOdeme();
                {
                    Text = "Ödeme Yap";
                    rezervasyon = new Rezervasyon()
                    {
                        ID = Guid.NewGuid(),
                    };

                }
                if (frm.ShowDialog() == DialogResult.OK)
                {
                tekrar:
                    var sonuc = frm.ShowDialog();
                    if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.OdemeGuncelle(frm.odeme);
                    if (b)
                    {

                        DataSet ds2 = BLogic.OdemeDetay();
                        if (ds2 != null)
                        {
                            dataGridView1.DataSource = ds2.Tables[0];
                        }

                    }
                    else

                        goto tekrar;


                }
            }
            
        }

        private void odemeDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmOdeme frmodeme = new FrmOdeme()
            {
                Text = "Ödeme Düzenle",
                Guncelleme = true,
                odeme = new Odeme()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    Tutar = double.Parse(row.Cells[3].Value.ToString()),
                    OdemeTuru = row.Cells[4].Value.ToString(),
                    Tarih = DateTime.Parse(row.Cells[5].Value.ToString()),
                }
            };

            var sonuc = frmodeme.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeGuncelle(frmodeme.odeme);
                if (b)
                {

                    row.Cells[1].Value = frmodeme.odeme.MusteriID;
                    row.Cells[3].Value = frmodeme.odeme.Tutar;
                    row.Cells[2].Value = frmodeme.odeme.Tarih;
                    row.Cells[4].Value = frmodeme.odeme.OdemeTuru;
                }



            }

        }

        private void odemeSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var id = row.Cells[0].Value.ToString();
            var sonuc = MessageBox.Show("Seçili Kayıt Silinsin mi ?", "Onayla", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdemeSil(id);


                if (b)
                {
                    DataSet ds = BLogic.OdemeDetay();
                    if (ds != null)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }




                }
            }
        }
    }

            } 
