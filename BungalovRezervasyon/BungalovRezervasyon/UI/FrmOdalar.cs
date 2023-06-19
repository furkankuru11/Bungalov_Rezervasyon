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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        

        public Oda oda=new Oda();
        public bool Guncelle { get; set; } = false;
        private void okButton_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(odaNo)) return;
            if (!ErrorControl(odaTipi)) return;
            if (!ErrorControl(odaFiyat)) return;

            oda.Numara = (double)odaNo.Value;
            oda.Tip = odaTipi.Text;
            oda.Fiyat = (double)odaFiyat.Value;

            DialogResult = DialogResult.OK;
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
             textID.Text=oda.ID.ToString();
            if (Guncelle) {
             oda.Numara=(double)odaNo.Value;
             oda.Tip = odaTipi.Text;
             oda.Fiyat=(double)odaFiyat.Value;   
       } 
                
            
        }
        private bool ErrorControl (Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
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
            if (c is NumericUpDown)
            {
                if (odaFiyat.Value==0 && odaNo.Value==0)
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
