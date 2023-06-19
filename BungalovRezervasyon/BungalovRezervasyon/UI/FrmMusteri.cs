using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BungalovRezervasyon.UI
{
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }
        public bool Guncelle { get; set; } = false;
        public Musteri musteri=new Musteri();

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        
           

        

        private void okButton_Click(object sender, EventArgs e)
        {
               if (!ErrorControl(txtAd)) return;
               if (!ErrorControl(txtSoyad)) return;
               if (!ErrorControl(txtTelefon)) return;
               if (!ErrorControl(txtMail)) return;
               if (!ErrorControl(txtAdres)) return;
            
              
            musteri.Ad = txtAd.Text;
            musteri.Soyad = txtSoyad.Text;
            musteri.Telefon = txtTelefon.Text;
            musteri.Mail = txtMail.Text;
            musteri.Adres= txtAdres.Text;
            
             
            

            DialogResult = DialogResult.OK;
        }
        private void FrmMusteri_Load (object sender, EventArgs e)
        {
            textID.Text =musteri.ID.ToString();
            
            if (Guncelle)
            {
                
                txtAd.Text = musteri.Ad;
                txtSoyad.Text = musteri.Soyad;
                txtTelefon.Text = musteri.Telefon;
                txtMail.Text = musteri.Mail;
                txtAdres.Text = musteri.Adres;
            }

        }
        private bool ErrorControl (Control c)
        {
            
            if (c is TextBox )
            {
                
                if (c.Text == "" )
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
               
                else
                {
                    errorProvider1.SetError(c, "");
                }
            }
            if (c is MaskedTextBox)
            {
                
                if (!((MaskedTextBox)c).MaskFull)
                {
                    
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                }
            }
           
          
            return true;
        }

        
    }
}
