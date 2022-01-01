
namespace Tugas_AD_Counter_HP
{
    partial class FormCashier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCashier));
            this.buttonMenu = new System.Windows.Forms.Button();
            this.labelNoInv = new System.Windows.Forms.Label();
            this.labelCustName = new System.Windows.Forms.Label();
            this.labelCustID = new System.Windows.Forms.Label();
            this.labelCustHP = new System.Windows.Forms.Label();
            this.labelCustEmail = new System.Windows.Forms.Label();
            this.textBoxCustNama = new System.Windows.Forms.TextBox();
            this.textBoxCustHP = new System.Windows.Forms.TextBox();
            this.textBoxCustEmail = new System.Windows.Forms.TextBox();
            this.textBoxCustID = new System.Windows.Forms.TextBox();
            this.textBoxInvNo = new System.Windows.Forms.TextBox();
            this.labelStoreID = new System.Windows.Forms.Label();
            this.labelPromoID = new System.Windows.Forms.Label();
            this.labelEmpID = new System.Windows.Forms.Label();
            this.labelInvDate = new System.Windows.Forms.Label();
            this.labelDisc = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.labelProdID = new System.Windows.Forms.Label();
            this.textBoxDisc = new System.Windows.Forms.TextBox();
            this.labelDisSubTotal = new System.Windows.Forms.Label();
            this.comboBoxProdName = new System.Windows.Forms.ComboBox();
            this.labelProdName = new System.Windows.Forms.Label();
            this.textBoxProdID = new System.Windows.Forms.TextBox();
            this.textBoxProdPrice = new System.Windows.Forms.TextBox();
            this.labelProdPrice = new System.Windows.Forms.Label();
            this.labelQuan = new System.Windows.Forms.Label();
            this.labelDisTotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelBayar = new System.Windows.Forms.Label();
            this.labelKembali = new System.Windows.Forms.Label();
            this.textBoxBayar = new System.Windows.Forms.TextBox();
            this.labelDisKembali = new System.Windows.Forms.Label();
            this.buttonAddProd = new System.Windows.Forms.Button();
            this.nudQuan = new System.Windows.Forms.NumericUpDown();
            this.labelPromoName = new System.Windows.Forms.Label();
            this.textBoxPromoID = new System.Windows.Forms.TextBox();
            this.dgvPrintProduct2 = new System.Windows.Forms.DataGridView();
            this.textBoxIDEmp = new System.Windows.Forms.TextBox();
            this.textBoxDisIDStore = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelDataInv = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.dtpInvDate = new System.Windows.Forms.DateTimePicker();
            this.labelStock = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxPromoName = new System.Windows.Forms.TextBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelCust = new System.Windows.Forms.Label();
            this.labelLine2 = new System.Windows.Forms.Label();
            this.labelLine3 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.labelRp = new System.Windows.Forms.Label();
            this.buttonPaid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintProduct2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Navy;
            this.buttonMenu.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonMenu.Location = new System.Drawing.Point(1082, 763);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(145, 57);
            this.buttonMenu.TabIndex = 12;
            this.buttonMenu.Text = "Back To Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelNoInv
            // 
            this.labelNoInv.AutoSize = true;
            this.labelNoInv.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoInv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNoInv.Location = new System.Drawing.Point(35, 82);
            this.labelNoInv.Name = "labelNoInv";
            this.labelNoInv.Size = new System.Drawing.Size(102, 22);
            this.labelNoInv.TabIndex = 1;
            this.labelNoInv.Text = "No. Invoice";
            // 
            // labelCustName
            // 
            this.labelCustName.AutoSize = true;
            this.labelCustName.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCustName.Location = new System.Drawing.Point(34, 626);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(58, 22);
            this.labelCustName.TabIndex = 2;
            this.labelCustName.Text = "Nama";
            // 
            // labelCustID
            // 
            this.labelCustID.AutoSize = true;
            this.labelCustID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCustID.Location = new System.Drawing.Point(35, 559);
            this.labelCustID.Name = "labelCustID";
            this.labelCustID.Size = new System.Drawing.Size(28, 22);
            this.labelCustID.TabIndex = 3;
            this.labelCustID.Text = "ID";
            // 
            // labelCustHP
            // 
            this.labelCustHP.AutoSize = true;
            this.labelCustHP.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustHP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCustHP.Location = new System.Drawing.Point(35, 694);
            this.labelCustHP.Name = "labelCustHP";
            this.labelCustHP.Size = new System.Drawing.Size(69, 22);
            this.labelCustHP.TabIndex = 5;
            this.labelCustHP.Text = "No. HP";
            // 
            // labelCustEmail
            // 
            this.labelCustEmail.AutoSize = true;
            this.labelCustEmail.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCustEmail.Location = new System.Drawing.Point(33, 762);
            this.labelCustEmail.Name = "labelCustEmail";
            this.labelCustEmail.Size = new System.Drawing.Size(54, 22);
            this.labelCustEmail.TabIndex = 6;
            this.labelCustEmail.Text = "Email";
            // 
            // textBoxCustNama
            // 
            this.textBoxCustNama.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustNama.Location = new System.Drawing.Point(37, 651);
            this.textBoxCustNama.Name = "textBoxCustNama";
            this.textBoxCustNama.Size = new System.Drawing.Size(211, 29);
            this.textBoxCustNama.TabIndex = 0;
            this.textBoxCustNama.TextChanged += new System.EventHandler(this.textBoxCustNama_TextChanged);
            // 
            // textBoxCustHP
            // 
            this.textBoxCustHP.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustHP.Location = new System.Drawing.Point(81, 721);
            this.textBoxCustHP.MaxLength = 12;
            this.textBoxCustHP.Name = "textBoxCustHP";
            this.textBoxCustHP.Size = new System.Drawing.Size(185, 29);
            this.textBoxCustHP.TabIndex = 1;
            this.textBoxCustHP.TextChanged += new System.EventHandler(this.textBoxCustHP_TextChanged);
            this.textBoxCustHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCustHP_KeyPress);
            // 
            // textBoxCustEmail
            // 
            this.textBoxCustEmail.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustEmail.Location = new System.Drawing.Point(37, 787);
            this.textBoxCustEmail.Name = "textBoxCustEmail";
            this.textBoxCustEmail.Size = new System.Drawing.Size(243, 29);
            this.textBoxCustEmail.TabIndex = 2;
            this.textBoxCustEmail.TextChanged += new System.EventHandler(this.textBoxCustEmail_TextChanged);
            // 
            // textBoxCustID
            // 
            this.textBoxCustID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCustID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCustID.Location = new System.Drawing.Point(38, 584);
            this.textBoxCustID.Name = "textBoxCustID";
            this.textBoxCustID.ReadOnly = true;
            this.textBoxCustID.Size = new System.Drawing.Size(107, 29);
            this.textBoxCustID.TabIndex = 10;
            this.textBoxCustID.TabStop = false;
            // 
            // textBoxInvNo
            // 
            this.textBoxInvNo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxInvNo.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInvNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxInvNo.Location = new System.Drawing.Point(39, 107);
            this.textBoxInvNo.Name = "textBoxInvNo";
            this.textBoxInvNo.ReadOnly = true;
            this.textBoxInvNo.Size = new System.Drawing.Size(116, 29);
            this.textBoxInvNo.TabIndex = 11;
            this.textBoxInvNo.TabStop = false;
            // 
            // labelStoreID
            // 
            this.labelStoreID.AutoSize = true;
            this.labelStoreID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStoreID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStoreID.Location = new System.Drawing.Point(35, 150);
            this.labelStoreID.Name = "labelStoreID";
            this.labelStoreID.Size = new System.Drawing.Size(75, 22);
            this.labelStoreID.TabIndex = 12;
            this.labelStoreID.Text = "ID Toko";
            // 
            // labelPromoID
            // 
            this.labelPromoID.AutoSize = true;
            this.labelPromoID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromoID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPromoID.Location = new System.Drawing.Point(34, 420);
            this.labelPromoID.Name = "labelPromoID";
            this.labelPromoID.Size = new System.Drawing.Size(89, 22);
            this.labelPromoID.TabIndex = 14;
            this.labelPromoID.Text = "ID Promo";
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpID.Location = new System.Drawing.Point(34, 221);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(116, 22);
            this.labelEmpID.TabIndex = 16;
            this.labelEmpID.Text = "ID Karyawan ";
            // 
            // labelInvDate
            // 
            this.labelInvDate.AutoSize = true;
            this.labelInvDate.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInvDate.Location = new System.Drawing.Point(34, 292);
            this.labelInvDate.Name = "labelInvDate";
            this.labelInvDate.Size = new System.Drawing.Size(142, 22);
            this.labelInvDate.TabIndex = 18;
            this.labelInvDate.Text = "Tanggal Invoice ";
            // 
            // labelDisc
            // 
            this.labelDisc.AutoSize = true;
            this.labelDisc.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDisc.Location = new System.Drawing.Point(33, 450);
            this.labelDisc.Name = "labelDisc";
            this.labelDisc.Size = new System.Drawing.Size(44, 22);
            this.labelDisc.TabIndex = 20;
            this.labelDisc.Text = "Disc";
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSubTotal.Location = new System.Drawing.Point(819, 150);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(93, 22);
            this.labelSubTotal.TabIndex = 21;
            this.labelSubTotal.Text = "Sub Total ";
            // 
            // labelProdID
            // 
            this.labelProdID.AutoSize = true;
            this.labelProdID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelProdID.Location = new System.Drawing.Point(413, 153);
            this.labelProdID.Name = "labelProdID";
            this.labelProdID.Size = new System.Drawing.Size(28, 22);
            this.labelProdID.TabIndex = 22;
            this.labelProdID.Text = "ID";
            // 
            // textBoxDisc
            // 
            this.textBoxDisc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDisc.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxDisc.Location = new System.Drawing.Point(150, 447);
            this.textBoxDisc.Name = "textBoxDisc";
            this.textBoxDisc.ReadOnly = true;
            this.textBoxDisc.Size = new System.Drawing.Size(100, 29);
            this.textBoxDisc.TabIndex = 26;
            this.textBoxDisc.TabStop = false;
            this.textBoxDisc.TextChanged += new System.EventHandler(this.textBoxDisc_TextChanged);
            // 
            // labelDisSubTotal
            // 
            this.labelDisSubTotal.AutoSize = true;
            this.labelDisSubTotal.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisSubTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDisSubTotal.Location = new System.Drawing.Point(821, 178);
            this.labelDisSubTotal.Name = "labelDisSubTotal";
            this.labelDisSubTotal.Size = new System.Drawing.Size(72, 22);
            this.labelDisSubTotal.TabIndex = 27;
            this.labelDisSubTotal.Text = "Rp 0,00";
            // 
            // comboBoxProdName
            // 
            this.comboBoxProdName.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProdName.FormattingEnabled = true;
            this.comboBoxProdName.Items.AddRange(new object[] {
            "Galaxy Z Flip3 5G",
            "Galaxy S22 Ultra 5G",
            "iPhone 13 Pro Max",
            "Galaxy Tab A8 Wifi LTE",
            "iPad Pro Gen 5",
            "Xiaomi 12 Pro",
            "Baseus Powerbank Magnetic Wireless Magsafe",
            "AirPods gen 3",
            "Oppo Enco W31",
            "Oppo Reno 6 5G",
            "Onyx Studio 6"});
            this.comboBoxProdName.Location = new System.Drawing.Point(417, 107);
            this.comboBoxProdName.Name = "comboBoxProdName";
            this.comboBoxProdName.Size = new System.Drawing.Size(298, 29);
            this.comboBoxProdName.TabIndex = 3;
            this.comboBoxProdName.SelectedIndexChanged += new System.EventHandler(this.comboBoxProdName_SelectedIndexChanged);
            // 
            // labelProdName
            // 
            this.labelProdName.AutoSize = true;
            this.labelProdName.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelProdName.Location = new System.Drawing.Point(413, 82);
            this.labelProdName.Name = "labelProdName";
            this.labelProdName.Size = new System.Drawing.Size(58, 22);
            this.labelProdName.TabIndex = 29;
            this.labelProdName.Text = "Nama";
            // 
            // textBoxProdID
            // 
            this.textBoxProdID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxProdID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProdID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxProdID.Location = new System.Drawing.Point(514, 150);
            this.textBoxProdID.Name = "textBoxProdID";
            this.textBoxProdID.ReadOnly = true;
            this.textBoxProdID.Size = new System.Drawing.Size(80, 29);
            this.textBoxProdID.TabIndex = 31;
            this.textBoxProdID.TabStop = false;
            // 
            // textBoxProdPrice
            // 
            this.textBoxProdPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxProdPrice.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProdPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxProdPrice.Location = new System.Drawing.Point(514, 182);
            this.textBoxProdPrice.Name = "textBoxProdPrice";
            this.textBoxProdPrice.ReadOnly = true;
            this.textBoxProdPrice.Size = new System.Drawing.Size(167, 29);
            this.textBoxProdPrice.TabIndex = 33;
            this.textBoxProdPrice.TabStop = false;
            // 
            // labelProdPrice
            // 
            this.labelProdPrice.AutoSize = true;
            this.labelProdPrice.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelProdPrice.Location = new System.Drawing.Point(413, 185);
            this.labelProdPrice.Name = "labelProdPrice";
            this.labelProdPrice.Size = new System.Drawing.Size(94, 22);
            this.labelProdPrice.TabIndex = 32;
            this.labelProdPrice.Text = "Harga/Pcs";
            // 
            // labelQuan
            // 
            this.labelQuan.AutoSize = true;
            this.labelQuan.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelQuan.Location = new System.Drawing.Point(819, 82);
            this.labelQuan.Name = "labelQuan";
            this.labelQuan.Size = new System.Drawing.Size(86, 22);
            this.labelQuan.TabIndex = 34;
            this.labelQuan.Text = "Kuantitas";
            // 
            // labelDisTotal
            // 
            this.labelDisTotal.AutoSize = true;
            this.labelDisTotal.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisTotal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelDisTotal.Location = new System.Drawing.Point(417, 605);
            this.labelDisTotal.Name = "labelDisTotal";
            this.labelDisTotal.Size = new System.Drawing.Size(130, 42);
            this.labelDisTotal.TabIndex = 37;
            this.labelDisTotal.Text = "Rp0,00";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTotal.Location = new System.Drawing.Point(418, 563);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(76, 31);
            this.labelTotal.TabIndex = 36;
            this.labelTotal.Text = "Total";
            // 
            // labelBayar
            // 
            this.labelBayar.AutoSize = true;
            this.labelBayar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBayar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBayar.Location = new System.Drawing.Point(420, 672);
            this.labelBayar.Name = "labelBayar";
            this.labelBayar.Size = new System.Drawing.Size(55, 22);
            this.labelBayar.TabIndex = 38;
            this.labelBayar.Text = "Bayar";
            // 
            // labelKembali
            // 
            this.labelKembali.AutoSize = true;
            this.labelKembali.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKembali.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelKembali.Location = new System.Drawing.Point(605, 672);
            this.labelKembali.Name = "labelKembali";
            this.labelKembali.Size = new System.Drawing.Size(76, 22);
            this.labelKembali.TabIndex = 39;
            this.labelKembali.Text = "Kembali";
            // 
            // textBoxBayar
            // 
            this.textBoxBayar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBayar.Location = new System.Drawing.Point(461, 697);
            this.textBoxBayar.MaxLength = 9;
            this.textBoxBayar.Name = "textBoxBayar";
            this.textBoxBayar.Size = new System.Drawing.Size(100, 29);
            this.textBoxBayar.TabIndex = 8;
            this.textBoxBayar.Text = "0";
            this.textBoxBayar.TextChanged += new System.EventHandler(this.textBoxBayar_TextChanged);
            this.textBoxBayar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCustHP_KeyPress);
            // 
            // labelDisKembali
            // 
            this.labelDisKembali.AutoSize = true;
            this.labelDisKembali.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisKembali.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDisKembali.Location = new System.Drawing.Point(605, 700);
            this.labelDisKembali.Name = "labelDisKembali";
            this.labelDisKembali.Size = new System.Drawing.Size(67, 22);
            this.labelDisKembali.TabIndex = 41;
            this.labelDisKembali.Text = "Rp0,00";
            // 
            // buttonAddProd
            // 
            this.buttonAddProd.BackColor = System.Drawing.Color.Firebrick;
            this.buttonAddProd.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddProd.Location = new System.Drawing.Point(1065, 201);
            this.buttonAddProd.Name = "buttonAddProd";
            this.buttonAddProd.Size = new System.Drawing.Size(78, 42);
            this.buttonAddProd.TabIndex = 5;
            this.buttonAddProd.Text = "Add";
            this.buttonAddProd.UseVisualStyleBackColor = false;
            this.buttonAddProd.Click += new System.EventHandler(this.buttonAddProd_Click);
            // 
            // nudQuan
            // 
            this.nudQuan.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuan.Location = new System.Drawing.Point(823, 108);
            this.nudQuan.Name = "nudQuan";
            this.nudQuan.Size = new System.Drawing.Size(120, 29);
            this.nudQuan.TabIndex = 4;
            this.nudQuan.ValueChanged += new System.EventHandler(this.nudQuan_ValueChanged);
            // 
            // labelPromoName
            // 
            this.labelPromoName.AutoSize = true;
            this.labelPromoName.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromoName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPromoName.Location = new System.Drawing.Point(33, 357);
            this.labelPromoName.Name = "labelPromoName";
            this.labelPromoName.Size = new System.Drawing.Size(66, 22);
            this.labelPromoName.TabIndex = 45;
            this.labelPromoName.Text = "Promo";
            // 
            // textBoxPromoID
            // 
            this.textBoxPromoID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPromoID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPromoID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPromoID.Location = new System.Drawing.Point(150, 417);
            this.textBoxPromoID.Name = "textBoxPromoID";
            this.textBoxPromoID.ReadOnly = true;
            this.textBoxPromoID.Size = new System.Drawing.Size(100, 29);
            this.textBoxPromoID.TabIndex = 46;
            this.textBoxPromoID.TabStop = false;
            // 
            // dgvPrintProduct2
            // 
            this.dgvPrintProduct2.AllowUserToAddRows = false;
            this.dgvPrintProduct2.AllowUserToDeleteRows = false;
            this.dgvPrintProduct2.AllowUserToOrderColumns = true;
            this.dgvPrintProduct2.AllowUserToResizeColumns = false;
            this.dgvPrintProduct2.AllowUserToResizeRows = false;
            this.dgvPrintProduct2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrintProduct2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrintProduct2.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgvPrintProduct2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrintProduct2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrintProduct2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrintProduct2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrintProduct2.Location = new System.Drawing.Point(418, 258);
            this.dgvPrintProduct2.Name = "dgvPrintProduct2";
            this.dgvPrintProduct2.ReadOnly = true;
            this.dgvPrintProduct2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvPrintProduct2.RowHeadersVisible = false;
            this.dgvPrintProduct2.RowHeadersWidth = 62;
            this.dgvPrintProduct2.RowTemplate.Height = 28;
            this.dgvPrintProduct2.Size = new System.Drawing.Size(811, 292);
            this.dgvPrintProduct2.TabIndex = 6;
            this.dgvPrintProduct2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrintProduct2_CellContentClick);
            // 
            // textBoxIDEmp
            // 
            this.textBoxIDEmp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxIDEmp.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDEmp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxIDEmp.Location = new System.Drawing.Point(37, 246);
            this.textBoxIDEmp.Name = "textBoxIDEmp";
            this.textBoxIDEmp.ReadOnly = true;
            this.textBoxIDEmp.Size = new System.Drawing.Size(113, 29);
            this.textBoxIDEmp.TabIndex = 49;
            this.textBoxIDEmp.TabStop = false;
            // 
            // textBoxDisIDStore
            // 
            this.textBoxDisIDStore.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDisIDStore.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisIDStore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxDisIDStore.Location = new System.Drawing.Point(37, 175);
            this.textBoxDisIDStore.Name = "textBoxDisIDStore";
            this.textBoxDisIDStore.ReadOnly = true;
            this.textBoxDisIDStore.Size = new System.Drawing.Size(113, 29);
            this.textBoxDisIDStore.TabIndex = 50;
            this.textBoxDisIDStore.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Firebrick;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSave.Location = new System.Drawing.Point(418, 763);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 57);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Firebrick;
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonPrint.Location = new System.Drawing.Point(530, 763);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(95, 57);
            this.buttonPrint.TabIndex = 10;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Firebrick;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonClose.Location = new System.Drawing.Point(641, 763);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(95, 57);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelDataInv
            // 
            this.labelDataInv.AutoSize = true;
            this.labelDataInv.BackColor = System.Drawing.Color.Transparent;
            this.labelDataInv.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataInv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDataInv.Location = new System.Drawing.Point(32, 33);
            this.labelDataInv.Name = "labelDataInv";
            this.labelDataInv.Size = new System.Drawing.Size(151, 39);
            this.labelDataInv.TabIndex = 54;
            this.labelDataInv.Text = "INVOICE";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(185, 36);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(144, 20);
            this.labelLine.TabIndex = 56;
            this.labelLine.Text = "_______________\r\n";
            // 
            // dtpInvDate
            // 
            this.dtpInvDate.Enabled = false;
            this.dtpInvDate.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvDate.Location = new System.Drawing.Point(36, 317);
            this.dtpInvDate.Name = "dtpInvDate";
            this.dtpInvDate.Size = new System.Drawing.Size(280, 29);
            this.dtpInvDate.TabIndex = 57;
            this.dtpInvDate.TabStop = false;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStock.Font = new System.Drawing.Font("Yu Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStock.Location = new System.Drawing.Point(600, 152);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(57, 23);
            this.labelStock.TabIndex = 58;
            this.labelStock.Text = "Stok :";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonDelete.Location = new System.Drawing.Point(1149, 201);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(78, 42);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxPromoName
            // 
            this.textBoxPromoName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPromoName.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPromoName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPromoName.Location = new System.Drawing.Point(37, 382);
            this.textBoxPromoName.Name = "textBoxPromoName";
            this.textBoxPromoName.ReadOnly = true;
            this.textBoxPromoName.Size = new System.Drawing.Size(298, 29);
            this.textBoxPromoName.TabIndex = 60;
            this.textBoxPromoName.TabStop = false;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.BackColor = System.Drawing.Color.Transparent;
            this.labelProduct.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelProduct.Location = new System.Drawing.Point(410, 33);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(147, 39);
            this.labelProduct.TabIndex = 61;
            this.labelProduct.Text = "PRODUK";
            // 
            // labelCust
            // 
            this.labelCust.AutoSize = true;
            this.labelCust.BackColor = System.Drawing.Color.Transparent;
            this.labelCust.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCust.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCust.Location = new System.Drawing.Point(30, 511);
            this.labelCust.Name = "labelCust";
            this.labelCust.Size = new System.Drawing.Size(186, 39);
            this.labelCust.TabIndex = 62;
            this.labelCust.Text = "CUSTOMER";
            // 
            // labelLine2
            // 
            this.labelLine2.AutoSize = true;
            this.labelLine2.Location = new System.Drawing.Point(221, 515);
            this.labelLine2.Name = "labelLine2";
            this.labelLine2.Size = new System.Drawing.Size(108, 20);
            this.labelLine2.TabIndex = 63;
            this.labelLine2.Text = "___________\r\n";
            // 
            // labelLine3
            // 
            this.labelLine3.AutoSize = true;
            this.labelLine3.Location = new System.Drawing.Point(559, 36);
            this.labelLine3.Name = "labelLine3";
            this.labelLine3.Size = new System.Drawing.Size(648, 20);
            this.labelLine3.TabIndex = 64;
            this.labelLine3.Text = "_______________________________________________________________________";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label62.Location = new System.Drawing.Point(33, 728);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(42, 22);
            this.label62.TabIndex = 65;
            this.label62.Text = "+62";
            // 
            // labelRp
            // 
            this.labelRp.AutoSize = true;
            this.labelRp.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRp.Location = new System.Drawing.Point(420, 700);
            this.labelRp.Name = "labelRp";
            this.labelRp.Size = new System.Drawing.Size(32, 22);
            this.labelRp.TabIndex = 66;
            this.labelRp.Text = "Rp";
            // 
            // buttonPaid
            // 
            this.buttonPaid.BackColor = System.Drawing.Color.Black;
            this.buttonPaid.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaid.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonPaid.Location = new System.Drawing.Point(777, 672);
            this.buttonPaid.Name = "buttonPaid";
            this.buttonPaid.Size = new System.Drawing.Size(99, 54);
            this.buttonPaid.TabIndex = 67;
            this.buttonPaid.Text = "Pay";
            this.buttonPaid.UseVisualStyleBackColor = false;
            this.buttonPaid.Click += new System.EventHandler(this.buttonPaid_Click);
            // 
            // FormCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 862);
            this.Controls.Add(this.buttonPaid);
            this.Controls.Add(this.labelRp);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.labelLine3);
            this.Controls.Add(this.labelLine2);
            this.Controls.Add(this.labelCust);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.textBoxPromoName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.dtpInvDate);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.labelDataInv);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDisIDStore);
            this.Controls.Add(this.textBoxIDEmp);
            this.Controls.Add(this.dgvPrintProduct2);
            this.Controls.Add(this.textBoxPromoID);
            this.Controls.Add(this.labelPromoName);
            this.Controls.Add(this.nudQuan);
            this.Controls.Add(this.buttonAddProd);
            this.Controls.Add(this.labelDisKembali);
            this.Controls.Add(this.textBoxBayar);
            this.Controls.Add(this.labelKembali);
            this.Controls.Add(this.labelBayar);
            this.Controls.Add(this.labelDisTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelQuan);
            this.Controls.Add(this.textBoxProdPrice);
            this.Controls.Add(this.labelProdPrice);
            this.Controls.Add(this.textBoxProdID);
            this.Controls.Add(this.labelProdName);
            this.Controls.Add(this.comboBoxProdName);
            this.Controls.Add(this.labelDisSubTotal);
            this.Controls.Add(this.textBoxDisc);
            this.Controls.Add(this.labelProdID);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.labelDisc);
            this.Controls.Add(this.labelInvDate);
            this.Controls.Add(this.labelEmpID);
            this.Controls.Add(this.labelPromoID);
            this.Controls.Add(this.labelStoreID);
            this.Controls.Add(this.textBoxInvNo);
            this.Controls.Add(this.textBoxCustID);
            this.Controls.Add(this.textBoxCustEmail);
            this.Controls.Add(this.textBoxCustHP);
            this.Controls.Add(this.textBoxCustNama);
            this.Controls.Add(this.labelCustEmail);
            this.Controls.Add(this.labelCustHP);
            this.Controls.Add(this.labelCustID);
            this.Controls.Add(this.labelCustName);
            this.Controls.Add(this.labelNoInv);
            this.Controls.Add(this.buttonMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.FormInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintProduct2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label labelNoInv;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.Label labelCustID;
        private System.Windows.Forms.Label labelCustHP;
        private System.Windows.Forms.Label labelCustEmail;
        private System.Windows.Forms.TextBox textBoxCustNama;
        private System.Windows.Forms.TextBox textBoxCustHP;
        private System.Windows.Forms.TextBox textBoxCustEmail;
        private System.Windows.Forms.TextBox textBoxCustID;
        private System.Windows.Forms.TextBox textBoxInvNo;
        private System.Windows.Forms.Label labelStoreID;
        private System.Windows.Forms.Label labelPromoID;
        private System.Windows.Forms.Label labelEmpID;
        private System.Windows.Forms.Label labelInvDate;
        private System.Windows.Forms.Label labelDisc;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label labelProdID;
        private System.Windows.Forms.TextBox textBoxDisc;
        private System.Windows.Forms.Label labelDisSubTotal;
        private System.Windows.Forms.ComboBox comboBoxProdName;
        private System.Windows.Forms.Label labelProdName;
        private System.Windows.Forms.TextBox textBoxProdID;
        private System.Windows.Forms.TextBox textBoxProdPrice;
        private System.Windows.Forms.Label labelProdPrice;
        private System.Windows.Forms.Label labelQuan;
        private System.Windows.Forms.Label labelDisTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelBayar;
        private System.Windows.Forms.Label labelKembali;
        private System.Windows.Forms.TextBox textBoxBayar;
        private System.Windows.Forms.Label labelDisKembali;
        private System.Windows.Forms.Button buttonAddProd;
        private System.Windows.Forms.NumericUpDown nudQuan;
        private System.Windows.Forms.Label labelPromoName;
        private System.Windows.Forms.TextBox textBoxPromoID;
        private System.Windows.Forms.DataGridView dgvPrintProduct2;
        private System.Windows.Forms.TextBox textBoxIDEmp;
        private System.Windows.Forms.TextBox textBoxDisIDStore;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelDataInv;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.DateTimePicker dtpInvDate;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxPromoName;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelCust;
        private System.Windows.Forms.Label labelLine2;
        private System.Windows.Forms.Label labelLine3;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label labelRp;
        private System.Windows.Forms.Button buttonPaid;
    }
}