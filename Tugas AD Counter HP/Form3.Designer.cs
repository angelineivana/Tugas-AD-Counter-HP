
namespace Tugas_AD_Counter_HP
{
    partial class FormNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNota));
            this.labelStoreName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelInvoice = new System.Windows.Forms.Label();
            this.labelInvNo = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCustPhone = new System.Windows.Forms.Label();
            this.labelCustName = new System.Windows.Forms.Label();
            this.labelCust = new System.Windows.Forms.Label();
            this.dgvPrintProduct = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaProduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kuantitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.labelPromo = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelKaryawan = new System.Windows.Forms.Label();
            this.labelDisCustName = new System.Windows.Forms.Label();
            this.labelDisCustPhone = new System.Windows.Forms.Label();
            this.labelDisCustEmail = new System.Windows.Forms.Label();
            this.labelDisTotal = new System.Windows.Forms.Label();
            this.labelDisPromo = new System.Windows.Forms.Label();
            this.labelDisSubTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStoreName
            // 
            this.labelStoreName.AutoSize = true;
            this.labelStoreName.Location = new System.Drawing.Point(26, 23);
            this.labelStoreName.Name = "labelStoreName";
            this.labelStoreName.Size = new System.Drawing.Size(90, 20);
            this.labelStoreName.TabIndex = 0;
            this.labelStoreName.Text = "Nama Toko";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(26, 55);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(59, 20);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Alamat";
            // 
            // labelInvoice
            // 
            this.labelInvoice.AutoSize = true;
            this.labelInvoice.Location = new System.Drawing.Point(479, 94);
            this.labelInvoice.Name = "labelInvoice";
            this.labelInvoice.Size = new System.Drawing.Size(75, 20);
            this.labelInvoice.TabIndex = 2;
            this.labelInvoice.Text = "INVOICE";
            this.labelInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInvNo
            // 
            this.labelInvNo.AutoSize = true;
            this.labelInvNo.Location = new System.Drawing.Point(476, 124);
            this.labelInvNo.Name = "labelInvNo";
            this.labelInvNo.Size = new System.Drawing.Size(87, 20);
            this.labelInvNo.TabIndex = 3;
            this.labelInvNo.Text = "No. Invoice";
            this.labelInvNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(479, 155);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(66, 20);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Tanggal";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(27, 285);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 20);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email :";
            // 
            // labelCustPhone
            // 
            this.labelCustPhone.AutoSize = true;
            this.labelCustPhone.Location = new System.Drawing.Point(27, 255);
            this.labelCustPhone.Name = "labelCustPhone";
            this.labelCustPhone.Size = new System.Drawing.Size(67, 20);
            this.labelCustPhone.TabIndex = 6;
            this.labelCustPhone.Text = "No. HP :";
            this.labelCustPhone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCustName
            // 
            this.labelCustName.AutoSize = true;
            this.labelCustName.Location = new System.Drawing.Point(27, 223);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(59, 20);
            this.labelCustName.TabIndex = 7;
            this.labelCustName.Text = "Nama :";
            // 
            // labelCust
            // 
            this.labelCust.AutoSize = true;
            this.labelCust.Location = new System.Drawing.Point(27, 192);
            this.labelCust.Name = "labelCust";
            this.labelCust.Size = new System.Drawing.Size(78, 20);
            this.labelCust.TabIndex = 8;
            this.labelCust.Text = "Customer";
            // 
            // dgvPrintProduct
            // 
            this.dgvPrintProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.NamaProduk,
            this.Kuantitas,
            this.Harga,
            this.Jumlah});
            this.dgvPrintProduct.Location = new System.Drawing.Point(40, 332);
            this.dgvPrintProduct.Name = "dgvPrintProduct";
            this.dgvPrintProduct.RowHeadersWidth = 62;
            this.dgvPrintProduct.RowTemplate.Height = 28;
            this.dgvPrintProduct.Size = new System.Drawing.Size(1003, 230);
            this.dgvPrintProduct.TabIndex = 10;
            // 
            // No
            // 
            this.No.HeaderText = "No.";
            this.No.MinimumWidth = 8;
            this.No.Name = "No";
            this.No.Width = 150;
            // 
            // NamaProduk
            // 
            this.NamaProduk.HeaderText = "Nama Produk";
            this.NamaProduk.MinimumWidth = 8;
            this.NamaProduk.Name = "NamaProduk";
            this.NamaProduk.Width = 150;
            // 
            // Kuantitas
            // 
            this.Kuantitas.HeaderText = "Kuantitas";
            this.Kuantitas.MinimumWidth = 8;
            this.Kuantitas.Name = "Kuantitas";
            this.Kuantitas.Width = 150;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.MinimumWidth = 8;
            this.Harga.Name = "Harga";
            this.Harga.Width = 150;
            // 
            // Jumlah
            // 
            this.Jumlah.HeaderText = "Jumlah";
            this.Jumlah.MinimumWidth = 8;
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Width = 150;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Location = new System.Drawing.Point(728, 598);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(85, 20);
            this.labelSubTotal.TabIndex = 11;
            this.labelSubTotal.Text = "Sub Total :";
            // 
            // labelPromo
            // 
            this.labelPromo.AutoSize = true;
            this.labelPromo.Location = new System.Drawing.Point(728, 633);
            this.labelPromo.Name = "labelPromo";
            this.labelPromo.Size = new System.Drawing.Size(63, 20);
            this.labelPromo.TabIndex = 12;
            this.labelPromo.Text = "Promo :";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(728, 670);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(52, 20);
            this.labelTotal.TabIndex = 13;
            this.labelTotal.Text = "Total :";
            // 
            // labelKaryawan
            // 
            this.labelKaryawan.AutoSize = true;
            this.labelKaryawan.Location = new System.Drawing.Point(822, 839);
            this.labelKaryawan.Name = "labelKaryawan";
            this.labelKaryawan.Size = new System.Drawing.Size(124, 20);
            this.labelKaryawan.TabIndex = 15;
            this.labelKaryawan.Text = "Nama Karyawan";
            // 
            // labelDisCustName
            // 
            this.labelDisCustName.AutoSize = true;
            this.labelDisCustName.Location = new System.Drawing.Point(101, 223);
            this.labelDisCustName.Name = "labelDisCustName";
            this.labelDisCustName.Size = new System.Drawing.Size(21, 20);
            this.labelDisCustName.TabIndex = 18;
            this.labelDisCustName.Text = "...";
            // 
            // labelDisCustPhone
            // 
            this.labelDisCustPhone.AutoSize = true;
            this.labelDisCustPhone.Location = new System.Drawing.Point(101, 255);
            this.labelDisCustPhone.Name = "labelDisCustPhone";
            this.labelDisCustPhone.Size = new System.Drawing.Size(21, 20);
            this.labelDisCustPhone.TabIndex = 17;
            this.labelDisCustPhone.Text = "...";
            // 
            // labelDisCustEmail
            // 
            this.labelDisCustEmail.AutoSize = true;
            this.labelDisCustEmail.Location = new System.Drawing.Point(101, 285);
            this.labelDisCustEmail.Name = "labelDisCustEmail";
            this.labelDisCustEmail.Size = new System.Drawing.Size(21, 20);
            this.labelDisCustEmail.TabIndex = 16;
            this.labelDisCustEmail.Text = "...";
            // 
            // labelDisTotal
            // 
            this.labelDisTotal.AutoSize = true;
            this.labelDisTotal.Location = new System.Drawing.Point(822, 670);
            this.labelDisTotal.Name = "labelDisTotal";
            this.labelDisTotal.Size = new System.Drawing.Size(21, 20);
            this.labelDisTotal.TabIndex = 21;
            this.labelDisTotal.Text = "...";
            this.labelDisTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDisPromo
            // 
            this.labelDisPromo.AutoSize = true;
            this.labelDisPromo.Location = new System.Drawing.Point(822, 633);
            this.labelDisPromo.Name = "labelDisPromo";
            this.labelDisPromo.Size = new System.Drawing.Size(21, 20);
            this.labelDisPromo.TabIndex = 20;
            this.labelDisPromo.Text = "...";
            // 
            // labelDisSubTotal
            // 
            this.labelDisSubTotal.AutoSize = true;
            this.labelDisSubTotal.Location = new System.Drawing.Point(822, 598);
            this.labelDisSubTotal.Name = "labelDisSubTotal";
            this.labelDisSubTotal.Size = new System.Drawing.Size(21, 20);
            this.labelDisSubTotal.TabIndex = 19;
            this.labelDisSubTotal.Text = "...";
            // 
            // FormNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1074, 881);
            this.Controls.Add(this.labelDisTotal);
            this.Controls.Add(this.labelDisPromo);
            this.Controls.Add(this.labelDisSubTotal);
            this.Controls.Add(this.labelDisCustName);
            this.Controls.Add(this.labelDisCustPhone);
            this.Controls.Add(this.labelDisCustEmail);
            this.Controls.Add(this.labelKaryawan);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelPromo);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.dgvPrintProduct);
            this.Controls.Add(this.labelCust);
            this.Controls.Add(this.labelCustName);
            this.Controls.Add(this.labelCustPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelInvNo);
            this.Controls.Add(this.labelInvoice);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelStoreName);
            this.Name = "FormNota";
            this.Text = "Form Nota";
            this.Load += new System.EventHandler(this.FormNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStoreName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelInvoice;
        private System.Windows.Forms.Label labelInvNo;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCustPhone;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.Label labelCust;
        private System.Windows.Forms.DataGridView dgvPrintProduct;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label labelPromo;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelKaryawan;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kuantitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah;
        private System.Windows.Forms.Label labelDisCustName;
        private System.Windows.Forms.Label labelDisCustPhone;
        private System.Windows.Forms.Label labelDisCustEmail;
        private System.Windows.Forms.Label labelDisTotal;
        private System.Windows.Forms.Label labelDisPromo;
        private System.Windows.Forms.Label labelDisSubTotal;
    }
}