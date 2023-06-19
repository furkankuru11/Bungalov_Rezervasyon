namespace BungalovRezervasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMusteriler = new System.Windows.Forms.ToolStripButton();
            this.btnOdalar = new System.Windows.Forms.ToolStripButton();
            this.odaKirala = new System.Windows.Forms.ToolStripButton();
            this.btnOdemeYap = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.odemeDuzenle = new System.Windows.Forms.ToolStripButton();
            this.odemeSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnRezervasyonDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnMusteriSil = new System.Windows.Forms.ToolStripButton();
            this.btnMusteriBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(5);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMusteriler,
            this.btnOdalar,
            this.odaKirala,
            this.btnOdemeYap});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(563, 42);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriler.Image")));
            this.btnMusteriler.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Padding = new System.Windows.Forms.Padding(5);
            this.btnMusteriler.Size = new System.Drawing.Size(112, 39);
            this.btnMusteriler.Text = "MÜŞTERİLER";
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnOdalar
            // 
            this.btnOdalar.Image = ((System.Drawing.Image)(resources.GetObject("btnOdalar.Image")));
            this.btnOdalar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(82, 39);
            this.btnOdalar.Text = "ODALAR";
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // odaKirala
            // 
            this.odaKirala.Image = ((System.Drawing.Image)(resources.GetObject("odaKirala.Image")));
            this.odaKirala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.odaKirala.Name = "odaKirala";
            this.odaKirala.Size = new System.Drawing.Size(138, 39);
            this.odaKirala.Text = "REZERVASYON YAP";
            this.odaKirala.Click += new System.EventHandler(this.odaKirala_Click);
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeYap.Image")));
            this.btnOdemeYap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Padding = new System.Windows.Forms.Padding(5);
            this.btnOdemeYap.Size = new System.Drawing.Size(110, 39);
            this.btnOdemeYap.Text = "ÖDEME YAP";
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.toolStrip3);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(555, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ödemeler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripMargin = new System.Windows.Forms.Padding(10);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odemeDuzenle,
            this.odemeSil,
            this.toolStripButton3,
            this.toolStripTextBox2,
            this.toolStripLabel2});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(549, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // odemeDuzenle
            // 
            this.odemeDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("odemeDuzenle.Image")));
            this.odemeDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.odemeDuzenle.Name = "odemeDuzenle";
            this.odemeDuzenle.Size = new System.Drawing.Size(69, 22);
            this.odemeDuzenle.Text = "Düzenle";
            this.odemeDuzenle.Click += new System.EventHandler(this.odemeDuzenle_Click);
            // 
            // odemeSil
            // 
            this.odemeSil.Image = ((System.Drawing.Image)(resources.GetObject("odemeSil.Image")));
            this.odemeSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.odemeSil.Name = "odemeSil";
            this.odemeSil.Size = new System.Drawing.Size(39, 22);
            this.odemeSil.Text = "Sil";
            this.odemeSil.Click += new System.EventHandler(this.odemeSil_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripButton3.Size = new System.Drawing.Size(40, 22);
            this.toolStripButton3.Text = "toolStripButton5";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.toolStripLabel2.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel2.Text = "Ara";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Controls.Add(this.statusStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(555, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kiralama Geçmişi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(549, 379);
            this.dataGridView1.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(10);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRezervasyonDuzenle,
            this.btnMusteriSil,
            this.btnMusteriBul,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(549, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnRezervasyonDuzenle
            // 
            this.btnRezervasyonDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnRezervasyonDuzenle.Image")));
            this.btnRezervasyonDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRezervasyonDuzenle.Name = "btnRezervasyonDuzenle";
            this.btnRezervasyonDuzenle.Size = new System.Drawing.Size(69, 22);
            this.btnRezervasyonDuzenle.Text = "Düzenle";
            this.btnRezervasyonDuzenle.Click += new System.EventHandler(this.btnRezervasyonDuzenle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriSil.Image")));
            this.btnMusteriSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(39, 22);
            this.btnMusteriSil.Text = "Sil";
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriBul
            // 
            this.btnMusteriBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMusteriBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMusteriBul.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriBul.Image")));
            this.btnMusteriBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriBul.Name = "btnMusteriBul";
            this.btnMusteriBul.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMusteriBul.Size = new System.Drawing.Size(40, 22);
            this.btnMusteriBul.Text = "toolStripButton5";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel1.Text = "Ara";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(3, 407);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(549, 22);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 42);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Padding = new System.Drawing.Point(15, 10);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(563, 472);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 2;
            this.tabControl2.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 514);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOdalar;
        private System.Windows.Forms.ToolStripButton odaKirala;
        private System.Windows.Forms.ToolStripButton btnOdemeYap;
        private System.Windows.Forms.ToolStripButton btnMusteriler;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton odemeDuzenle;
        private System.Windows.Forms.ToolStripButton odemeSil;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnRezervasyonDuzenle;
        private System.Windows.Forms.ToolStripButton btnMusteriSil;
        private System.Windows.Forms.ToolStripButton btnMusteriBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.TabControl tabControl2;
    }
}

