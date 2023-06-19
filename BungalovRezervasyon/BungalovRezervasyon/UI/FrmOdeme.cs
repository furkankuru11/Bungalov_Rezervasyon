using System;
using System.Collections;
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
    public partial class FrmOdeme : Form
    {
        public FrmOdeme()
        {
            InitializeComponent();
        }
        public bool Guncelleme { get; set; } = false;
         public Odeme odeme=new Odeme();
        private void Odeme_Load(object sender, EventArgs e)
        {
             txtOdemeID.Text = odeme.ID.ToString();
            if (Guncelleme)
            {
                txtMusteri.Text=odeme.MusteriID.ToString();
                odemeTuru.SelectedItem = odeme.OdemeTuru;
                totalOdeme.Text = odeme.Tutar.ToString();
                
                
                
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
     

        

        private void okButton_Click(object sender, EventArgs e)
        {
            if (totalOdeme.Value == 0)
            {
                errorProvider1.SetError(totalOdeme, "Lütfen Tutar Giriniz");
                totalOdeme.Focus();
                return;

            }
            else
            {
                errorProvider1.SetError(totalOdeme, "");
            }
            if (odemeTuru.SelectedItem == null)
            {

                errorProvider1.SetError(odemeTuru, "Ödeme Yöntemi Seçiniz");
                odemeTuru.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(odemeTuru, "");

            }
            odeme.MusteriID=Guid.Parse(txtMusteri.Text);
            odeme.OdemeTuru=odemeTuru.SelectedItem.ToString();
            odeme.Tutar = (double)totalOdeme.Value;
            odeme.Tarih = odemeTarihi.Value;
            DialogResult = DialogResult.OK;
        }

        private void odemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            
            }

        private void musteriSecButton_Click(object sender, EventArgs e)
        {

            Musteriler frm = new Musteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //Musteri = frm.Musteri;
                txtMusteri.Text = frm.musteri.ID.ToString();
            }
        }
    }
  
    }

