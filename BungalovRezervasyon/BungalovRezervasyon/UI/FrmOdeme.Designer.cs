namespace BungalovRezervasyon.UI
{
    partial class FrmOdeme
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
            this.odemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.totalOdeme = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOdemeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.odemeTuru = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.musteriSecButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.totalOdeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // odemeTarihi
            // 
            this.odemeTarihi.Location = new System.Drawing.Point(137, 166);
            this.odemeTarihi.Name = "odemeTarihi";
            this.odemeTarihi.Size = new System.Drawing.Size(183, 20);
            this.odemeTarihi.TabIndex = 3;
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(138, 93);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.ReadOnly = true;
            this.txtMusteri.Size = new System.Drawing.Size(182, 20);
            this.txtMusteri.TabIndex = 1;
            this.txtMusteri.TabStop = false;
            // 
            // totalOdeme
            // 
            this.totalOdeme.Location = new System.Drawing.Point(138, 130);
            this.totalOdeme.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.totalOdeme.Name = "totalOdeme";
            this.totalOdeme.Size = new System.Drawing.Size(182, 20);
            this.totalOdeme.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Ödeme Tutarı";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(237, 266);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "İptal";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(137, 266);
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
            this.label5.Location = new System.Drawing.Point(50, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Ödeme Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Müşteri";
            // 
            // txtOdemeID
            // 
            this.txtOdemeID.Location = new System.Drawing.Point(138, 59);
            this.txtOdemeID.Name = "txtOdemeID";
            this.txtOdemeID.ReadOnly = true;
            this.txtOdemeID.Size = new System.Drawing.Size(182, 20);
            this.txtOdemeID.TabIndex = 0;
            this.txtOdemeID.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID";
            // 
            // odemeTuru
            // 
            this.odemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odemeTuru.FormattingEnabled = true;
            this.odemeTuru.Items.AddRange(new object[] {
            "Kredi Kartı İle Ödeme",
            "Nakit İle Ödeme",
            "Sanal Kart ile Ödeme",
            "Banka Kartı ile Ödeme"});
            this.odemeTuru.Location = new System.Drawing.Point(137, 206);
            this.odemeTuru.Name = "odemeTuru";
            this.odemeTuru.Size = new System.Drawing.Size(182, 21);
            this.odemeTuru.TabIndex = 4;
            this.odemeTuru.SelectedIndexChanged += new System.EventHandler(this.odemeTuru_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ödeme Türü";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // musteriSecButton
            // 
            this.musteriSecButton.Location = new System.Drawing.Point(336, 90);
            this.musteriSecButton.Name = "musteriSecButton";
            this.musteriSecButton.Size = new System.Drawing.Size(77, 23);
            this.musteriSecButton.TabIndex = 43;
            this.musteriSecButton.Text = "Müşteri Seç";
            this.musteriSecButton.UseVisualStyleBackColor = true;
            this.musteriSecButton.Click += new System.EventHandler(this.musteriSecButton_Click);
            // 
            // FrmOdeme
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(491, 356);
            this.Controls.Add(this.musteriSecButton);
            this.Controls.Add(this.odemeTuru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.odemeTarihi);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.totalOdeme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOdemeID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Odeme";
            this.Load += new System.EventHandler(this.Odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalOdeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker odemeTarihi;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.NumericUpDown totalOdeme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOdemeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox odemeTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button musteriSecButton;
    }
}