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
    public partial class Odalar : Form
    {
        public bool Guncelle { get; private set; }=false;
        public Oda oda =new Oda();

        public Odalar()
        {
            InitializeComponent();
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            DataSet ug = BLogic.OdaGetir("");
            if (ug != null)
                dataGridView2.DataSource = ug.Tables[0];
        }
        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
           
            FrmOdalar frm = new FrmOdalar()
            {
                Text = "Oda Ekle",
                oda = new Oda()
                {
                    ID = Guid.NewGuid(),
                },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdaEkle(frm.oda);
                if (b)
                {

                    DataSet ds = BLogic.OdaGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }



            }
        }


        private void OdaBul_Click(object sender, EventArgs e)
        {

        }

        private void btnOdaDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            FrmOdalar frmOda = new FrmOdalar()
            {
                Text = "Oda Güncelle",
                Guncelle = true,
                oda = new Oda()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Numara = double.Parse(row.Cells[1].Value.ToString()),
                    Tip = row.Cells[2].Value.ToString(),
                    Fiyat = double.Parse(row.Cells[3].Value.ToString()),
                }
            };

            var sonuc = frmOda.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdaGuncelle(frmOda.oda);
                if (b)
                {

                    DataSet ds = BLogic.OdaGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }



            }
           
        }

        private void btnOdaSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();
            var sonuc = MessageBox.Show("Seçili Kayıt Silinsin mi ?", "Onayla", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdaSil(ID);


                if (b)
                {
                    DataSet os = BLogic.OdaGetir("");
                    if (os != null)
                    {
                        dataGridView2.DataSource = os.Tables[0];
                    }




                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
          
           
                
                
                oda = new Oda()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Numara = double.Parse(row.Cells[1].Value.ToString()),
                    Tip = row.Cells[2].Value.ToString(),
                    Fiyat = double.Parse(row.Cells[3].Value.ToString()),

                };
            DialogResult = DialogResult.OK;
            }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void urunBul_Click(object sender, EventArgs e)
        {

        }
    }
}
