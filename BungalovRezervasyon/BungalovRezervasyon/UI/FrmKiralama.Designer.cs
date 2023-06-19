namespace BungalovRezervasyon.UI
{
    partial class FrmKiralama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.totalFiyat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.baslangicT = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bitisT = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.musteriSecButton = new System.Windows.Forms.Button();
            this.urunSecButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRezervasyonID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.totalFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(216, 273);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "İptal";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(116, 273);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Tamam";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Başlangıç Tarihi";
            // 
            // totalFiyat
            // 
            this.totalFiyat.Location = new System.Drawing.Point(149, 144);
            this.totalFiyat.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.totalFiyat.Name = "totalFiyat";
            this.totalFiyat.ReadOnly = true;
            this.totalFiyat.Size = new System.Drawing.Size(182, 20);
            this.totalFiyat.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Müşteri";
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(149, 69);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.ReadOnly = true;
            this.txtMusteri.Size = new System.Drawing.Size(182, 20);
            this.txtMusteri.TabIndex = 1;
            this.txtMusteri.TabStop = false;
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(149, 106);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.ReadOnly = true;
            this.txtUrun.Size = new System.Drawing.Size(182, 20);
            this.txtUrun.TabIndex = 2;
            this.txtUrun.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Oda";
            // 
            // baslangicT
            // 
            this.baslangicT.Location = new System.Drawing.Point(148, 180);
            this.baslangicT.Name = "baslangicT";
            this.baslangicT.Size = new System.Drawing.Size(183, 20);
            this.baslangicT.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bitisT
            // 
            this.bitisT.Location = new System.Drawing.Point(148, 220);
            this.bitisT.Name = "bitisT";
            this.bitisT.Size = new System.Drawing.Size(183, 20);
            this.bitisT.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Bitis Tarihi";
            // 
            // musteriSecButton
            // 
            this.musteriSecButton.Location = new System.Drawing.Point(337, 67);
            this.musteriSecButton.Name = "musteriSecButton";
            this.musteriSecButton.Size = new System.Drawing.Size(77, 23);
            this.musteriSecButton.TabIndex = 32;
            this.musteriSecButton.Text = "Müşteri Seç";
            this.musteriSecButton.UseVisualStyleBackColor = true;
            this.musteriSecButton.Click += new System.EventHandler(this.musteriSecButton_Click);
            // 
            // urunSecButton
            // 
            this.urunSecButton.Location = new System.Drawing.Point(337, 103);
            this.urunSecButton.Name = "urunSecButton";
            this.urunSecButton.Size = new System.Drawing.Size(77, 23);
            this.urunSecButton.TabIndex = 33;
            this.urunSecButton.Text = "Oda Seç";
            this.urunSecButton.UseVisualStyleBackColor = true;
            this.urunSecButton.Click += new System.EventHandler(this.urunSecButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // txtRezervasyonID
            // 
            this.txtRezervasyonID.Location = new System.Drawing.Point(149, 35);
            this.txtRezervasyonID.Name = "txtRezervasyonID";
            this.txtRezervasyonID.ReadOnly = true;
            this.txtRezervasyonID.Size = new System.Drawing.Size(182, 20);
            this.txtRezervasyonID.TabIndex = 0;
            this.txtRezervasyonID.TabStop = false;
            // 
            // FrmKiralama
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(520, 425);
            this.Controls.Add(this.urunSecButton);
            this.Controls.Add(this.musteriSecButton);
            this.Controls.Add(this.bitisT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.baslangicT);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.totalFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRezervasyonID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmKiralama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kiralama";
            this.Load += new System.EventHandler(this.Kiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown totalFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker baslangicT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker bitisT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button urunSecButton;
        private System.Windows.Forms.Button musteriSecButton;
        private System.Windows.Forms.TextBox txtRezervasyonID;
        private System.Windows.Forms.Label label1;
    }
}