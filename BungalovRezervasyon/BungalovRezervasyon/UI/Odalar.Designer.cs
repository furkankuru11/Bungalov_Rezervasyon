namespace BungalovRezervasyon.UI
{
    partial class Odalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odalar));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnOdaEkle = new System.Windows.Forms.ToolStripButton();
            this.btnOdaDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnOdaSil = new System.Windows.Forms.ToolStripButton();
            this.urunBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 464);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cancelButton);
            this.tabPage2.Controls.Add(this.okButton);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.statusStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(613, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ODALAR";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(530, 365);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "İptal";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(437, 365);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "Tamam";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(7);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOdaEkle,
            this.btnOdaDuzenle,
            this.btnOdaSil,
            this.urunBul,
            this.toolStripTextBox2,
            this.toolStripLabel5});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(607, 33);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnOdaEkle
            // 
            this.btnOdaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnOdaEkle.Image")));
            this.btnOdaEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdaEkle.Name = "btnOdaEkle";
            this.btnOdaEkle.Padding = new System.Windows.Forms.Padding(5);
            this.btnOdaEkle.Size = new System.Drawing.Size(58, 30);
            this.btnOdaEkle.Text = "Ekle";
            this.btnOdaEkle.Click += new System.EventHandler(this.btnOdaEkle_Click);
            // 
            // btnOdaDuzenle
            // 
            this.btnOdaDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnOdaDuzenle.Image")));
            this.btnOdaDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdaDuzenle.Name = "btnOdaDuzenle";
            this.btnOdaDuzenle.Size = new System.Drawing.Size(69, 30);
            this.btnOdaDuzenle.Text = "Düzenle";
            this.btnOdaDuzenle.Click += new System.EventHandler(this.btnOdaDuzenle_Click);
            // 
            // btnOdaSil
            // 
            this.btnOdaSil.Image = ((System.Drawing.Image)(resources.GetObject("btnOdaSil.Image")));
            this.btnOdaSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOdaSil.Name = "btnOdaSil";
            this.btnOdaSil.Size = new System.Drawing.Size(39, 30);
            this.btnOdaSil.Text = "Sil";
            this.btnOdaSil.Click += new System.EventHandler(this.btnOdaSil_Click);
            // 
            // urunBul
            // 
            this.urunBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.urunBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.urunBul.Image = ((System.Drawing.Image)(resources.GetObject("urunBul.Image")));
            this.urunBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.urunBul.Name = "urunBul";
            this.urunBul.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.urunBul.Size = new System.Drawing.Size(40, 30);
            this.urunBul.Text = "toolStripButton5";
            this.urunBul.Click += new System.EventHandler(this.urunBul_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.toolStripLabel5.Size = new System.Drawing.Size(65, 30);
            this.toolStripLabel5.Text = "Ara";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 36);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(607, 316);
            this.dataGridView2.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(607, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Odalar
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(621, 464);
            this.Controls.Add(this.tabControl1);
            this.Name = "Odalar";
            this.Text = "Odalar";
            this.Load += new System.EventHandler(this.Odalar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnOdaEkle;
        private System.Windows.Forms.ToolStripButton btnOdaDuzenle;
        private System.Windows.Forms.ToolStripButton btnOdaSil;
        private System.Windows.Forms.ToolStripButton urunBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}