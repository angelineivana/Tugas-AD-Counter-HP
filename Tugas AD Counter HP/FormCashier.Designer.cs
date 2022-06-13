
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelDataCust = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
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
            this.labelInputProduk = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.dtpInvDate = new System.Windows.Forms.DateTimePicker();
            this.labelStock = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxPromoName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintProduct2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(38, 731);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(145, 57);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.Text = "Back To Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // labelNoInv
            // 
            this.labelNoInv.AutoSize = true;
            this.labelNoInv.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoInv.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelNoInv.Location = new System.Drawing.Point(35, 149);
            this.labelNoInv.Name = "labelNoInv";
            this.labelNoInv.Size = new System.Drawing.Size(112, 22);
            this.labelNoInv.TabIndex = 1;
            this.labelNoInv.Text = "No. Invoice :";
            // 
            // labelCustName
            // 
            this.labelCustName.AutoSize = true;
            this.labelCustName.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelCustName.Location = new System.Drawing.Point(649, 102);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(68, 22);
            this.labelCustName.TabIndex = 2;
            this.labelCustName.Text = "Nama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(651, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID :";
            // 
            // labelDataCust
            // 
            this.labelDataCust.AutoSize = true;
            this.labelDataCust.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelDataCust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDataCust.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataCust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDataCust.Location = new System.Drawing.Point(653, 14);
            this.labelDataCust.Name = "labelDataCust";
            this.labelDataCust.Size = new System.Drawing.Size(122, 35);
            this.labelDataCust.TabIndex = 4;
            this.labelDataCust.Text = "CUSTOMER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(649, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "No. HP :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(649, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email :";
            // 
            // textBoxCustNama
            // 
            this.textBoxCustNama.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustNama.Location = new System.Drawing.Point(764, 99);
            this.textBoxCustNama.Name = "textBoxCustNama";
            this.textBoxCustNama.Size = new System.Drawing.Size(243, 29);
            this.textBoxCustNama.TabIndex = 7;
            this.textBoxCustNama.TextChanged += new System.EventHandler(this.textBoxCustNama_TextChanged);
            // 
            // textBoxCustHP
            // 
            this.textBoxCustHP.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustHP.Location = new System.Drawing.Point(764, 141);
            this.textBoxCustHP.Name = "textBoxCustHP";
            this.textBoxCustHP.Size = new System.Drawing.Size(243, 29);
            this.textBoxCustHP.TabIndex = 8;
            this.textBoxCustHP.TextChanged += new System.EventHandler(this.textBoxCustHP_TextChanged);
            // 
            // textBoxCustEmail
            // 
            this.textBoxCustEmail.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustEmail.Location = new System.Drawing.Point(764, 186);
            this.textBoxCustEmail.Name = "textBoxCustEmail";
            this.textBoxCustEmail.Size = new System.Drawing.Size(243, 29);
            this.textBoxCustEmail.TabIndex = 9;
            this.textBoxCustEmail.TextChanged += new System.EventHandler(this.textBoxCustEmail_TextChanged);
            // 
            // textBoxCustID
            // 
            this.textBoxCustID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustID.Location = new System.Drawing.Point(764, 62);
            this.textBoxCustID.Name = "textBoxCustID";
            this.textBoxCustID.ReadOnly = true;
            this.textBoxCustID.Size = new System.Drawing.Size(243, 29);
            this.textBoxCustID.TabIndex = 10;
            // 
            // textBoxInvNo
            // 
            this.textBoxInvNo.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInvNo.Location = new System.Drawing.Point(192, 141);
            this.textBoxInvNo.Name = "textBoxInvNo";
            this.textBoxInvNo.ReadOnly = true;
            this.textBoxInvNo.Size = new System.Drawing.Size(200, 29);
            this.textBoxInvNo.TabIndex = 11;
            // 
            // labelStoreID
            // 
            this.labelStoreID.AutoSize = true;
            this.labelStoreID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStoreID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelStoreID.Location = new System.Drawing.Point(35, 65);
            this.labelStoreID.Name = "labelStoreID";
            this.labelStoreID.Size = new System.Drawing.Size(90, 22);
            this.labelStoreID.TabIndex = 12;
            this.labelStoreID.Text = "ID Toko : ";
            // 
            // labelPromoID
            // 
            this.labelPromoID.AutoSize = true;
            this.labelPromoID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromoID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelPromoID.Location = new System.Drawing.Point(35, 643);
            this.labelPromoID.Name = "labelPromoID";
            this.labelPromoID.Size = new System.Drawing.Size(99, 22);
            this.labelPromoID.TabIndex = 14;
            this.labelPromoID.Text = "ID Promo :";
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelEmpID.Location = new System.Drawing.Point(35, 108);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(126, 22);
            this.labelEmpID.TabIndex = 16;
            this.labelEmpID.Text = "ID Karyawan : ";
            // 
            // labelInvDate
            // 
            this.labelInvDate.AutoSize = true;
            this.labelInvDate.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelInvDate.Location = new System.Drawing.Point(35, 189);
            this.labelInvDate.Name = "labelInvDate";
            this.labelInvDate.Size = new System.Drawing.Size(152, 22);
            this.labelInvDate.TabIndex = 18;
            this.labelInvDate.Text = "Tanggal Invoice : ";
            // 
            // labelDisc
            // 
            this.labelDisc.AutoSize = true;
            this.labelDisc.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelDisc.Location = new System.Drawing.Point(35, 683);
            this.labelDisc.Name = "labelDisc";
            this.labelDisc.Size = new System.Drawing.Size(54, 22);
            this.labelDisc.TabIndex = 20;
            this.labelDisc.Text = "Disc :";
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelSubTotal.Location = new System.Drawing.Point(651, 346);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(103, 22);
            this.labelSubTotal.TabIndex = 21;
            this.labelSubTotal.Text = "Sub Total : ";
            // 
            // labelProdID
            // 
            this.labelProdID.AutoSize = true;
            this.labelProdID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelProdID.Location = new System.Drawing.Point(33, 343);
            this.labelProdID.Name = "labelProdID";
            this.labelProdID.Size = new System.Drawing.Size(43, 22);
            this.labelProdID.TabIndex = 22;
            this.labelProdID.Text = "ID : ";
            // 
            // textBoxDisc
            // 
            this.textBoxDisc.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisc.Location = new System.Drawing.Point(190, 680);
            this.textBoxDisc.Name = "textBoxDisc";
            this.textBoxDisc.ReadOnly = true;
            this.textBoxDisc.Size = new System.Drawing.Size(100, 29);
            this.textBoxDisc.TabIndex = 26;
            this.textBoxDisc.TextChanged += new System.EventHandler(this.textBoxDisc_TextChanged);
            // 
            // labelDisSubTotal
            // 
            this.labelDisSubTotal.AutoSize = true;
            this.labelDisSubTotal.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisSubTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelDisSubTotal.Location = new System.Drawing.Point(760, 346);
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
            this.comboBoxProdName.Location = new System.Drawing.Point(190, 298);
            this.comboBoxProdName.Name = "comboBoxProdName";
            this.comboBoxProdName.Size = new System.Drawing.Size(298, 29);
            this.comboBoxProdName.TabIndex = 28;
            this.comboBoxProdName.SelectedIndexChanged += new System.EventHandler(this.comboBoxProdName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(33, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nama : ";
            // 
            // textBoxProdID
            // 
            this.textBoxProdID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProdID.Location = new System.Drawing.Point(190, 340);
            this.textBoxProdID.Name = "textBoxProdID";
            this.textBoxProdID.ReadOnly = true;
            this.textBoxProdID.Size = new System.Drawing.Size(80, 29);
            this.textBoxProdID.TabIndex = 31;
            // 
            // textBoxProdPrice
            // 
            this.textBoxProdPrice.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProdPrice.Location = new System.Drawing.Point(190, 384);
            this.textBoxProdPrice.Name = "textBoxProdPrice";
            this.textBoxProdPrice.ReadOnly = true;
            this.textBoxProdPrice.Size = new System.Drawing.Size(167, 29);
            this.textBoxProdPrice.TabIndex = 33;
            // 
            // labelProdPrice
            // 
            this.labelProdPrice.AutoSize = true;
            this.labelProdPrice.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelProdPrice.Location = new System.Drawing.Point(33, 387);
            this.labelProdPrice.Name = "labelProdPrice";
            this.labelProdPrice.Size = new System.Drawing.Size(104, 22);
            this.labelProdPrice.TabIndex = 32;
            this.labelProdPrice.Text = "Harga/Pcs :";
            // 
            // labelQuan
            // 
            this.labelQuan.AutoSize = true;
            this.labelQuan.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuan.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelQuan.Location = new System.Drawing.Point(651, 303);
            this.labelQuan.Name = "labelQuan";
            this.labelQuan.Size = new System.Drawing.Size(96, 22);
            this.labelQuan.TabIndex = 34;
            this.labelQuan.Text = "Kuantitas :";
            // 
            // labelDisTotal
            // 
            this.labelDisTotal.AutoSize = true;
            this.labelDisTotal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelDisTotal.Location = new System.Drawing.Point(776, 597);
            this.labelDisTotal.Name = "labelDisTotal";
            this.labelDisTotal.Size = new System.Drawing.Size(99, 31);
            this.labelDisTotal.TabIndex = 37;
            this.labelDisTotal.Text = "Rp0,00";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelTotal.Location = new System.Drawing.Point(654, 597);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(90, 31);
            this.labelTotal.TabIndex = 36;
            this.labelTotal.Text = "Total :";
            // 
            // labelBayar
            // 
            this.labelBayar.AutoSize = true;
            this.labelBayar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBayar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelBayar.Location = new System.Drawing.Point(658, 663);
            this.labelBayar.Name = "labelBayar";
            this.labelBayar.Size = new System.Drawing.Size(157, 22);
            this.labelBayar.TabIndex = 38;
            this.labelBayar.Text = "Bayar :              Rp";
            // 
            // labelKembali
            // 
            this.labelKembali.AutoSize = true;
            this.labelKembali.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKembali.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelKembali.Location = new System.Drawing.Point(658, 703);
            this.labelKembali.Name = "labelKembali";
            this.labelKembali.Size = new System.Drawing.Size(86, 22);
            this.labelKembali.TabIndex = 39;
            this.labelKembali.Text = "Kembali :";
            // 
            // textBoxBayar
            // 
            this.textBoxBayar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBayar.Location = new System.Drawing.Point(816, 660);
            this.textBoxBayar.Name = "textBoxBayar";
            this.textBoxBayar.Size = new System.Drawing.Size(100, 29);
            this.textBoxBayar.TabIndex = 40;
            this.textBoxBayar.TextChanged += new System.EventHandler(this.textBoxBayar_TextChanged);
            // 
            // labelDisKembali
            // 
            this.labelDisKembali.AutoSize = true;
            this.labelDisKembali.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisKembali.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelDisKembali.Location = new System.Drawing.Point(780, 703);
            this.labelDisKembali.Name = "labelDisKembali";
            this.labelDisKembali.Size = new System.Drawing.Size(67, 22);
            this.labelDisKembali.TabIndex = 41;
            this.labelDisKembali.Text = "Rp0,00";
            // 
            // buttonAddProd
            // 
            this.buttonAddProd.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProd.Location = new System.Drawing.Point(655, 379);
            this.buttonAddProd.Name = "buttonAddProd";
            this.buttonAddProd.Size = new System.Drawing.Size(78, 42);
            this.buttonAddProd.TabIndex = 42;
            this.buttonAddProd.Text = "Add";
            this.buttonAddProd.UseVisualStyleBackColor = true;
            this.buttonAddProd.Click += new System.EventHandler(this.buttonAddProd_Click);
            // 
            // nudQuan
            // 
            this.nudQuan.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuan.Location = new System.Drawing.Point(764, 301);
            this.nudQuan.Name = "nudQuan";
            this.nudQuan.Size = new System.Drawing.Size(120, 29);
            this.nudQuan.TabIndex = 43;
            this.nudQuan.ValueChanged += new System.EventHandler(this.nudQuan_ValueChanged);
            // 
            // labelPromoName
            // 
            this.labelPromoName.AutoSize = true;
            this.labelPromoName.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromoName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelPromoName.Location = new System.Drawing.Point(33, 606);
            this.labelPromoName.Name = "labelPromoName";
            this.labelPromoName.Size = new System.Drawing.Size(76, 22);
            this.labelPromoName.TabIndex = 45;
            this.labelPromoName.Text = "Promo :";
            // 
            // textBoxPromoID
            // 
            this.textBoxPromoID.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPromoID.Location = new System.Drawing.Point(190, 640);
            this.textBoxPromoID.Name = "textBoxPromoID";
            this.textBoxPromoID.ReadOnly = true;
            this.textBoxPromoID.Size = new System.Drawing.Size(100, 29);
            this.textBoxPromoID.TabIndex = 46;
            // 
            // dgvPrintProduct2
            // 
            this.dgvPrintProduct2.AllowUserToAddRows = false;
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
            this.dgvPrintProduct2.Location = new System.Drawing.Point(37, 433);
            this.dgvPrintProduct2.Name = "dgvPrintProduct2";
            this.dgvPrintProduct2.ReadOnly = true;
            this.dgvPrintProduct2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvPrintProduct2.RowHeadersVisible = false;
            this.dgvPrintProduct2.RowHeadersWidth = 62;
            this.dgvPrintProduct2.RowTemplate.Height = 28;
            this.dgvPrintProduct2.Size = new System.Drawing.Size(983, 149);
            this.dgvPrintProduct2.TabIndex = 48;
            // 
            // textBoxIDEmp
            // 
            this.textBoxIDEmp.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDEmp.Location = new System.Drawing.Point(192, 99);
            this.textBoxIDEmp.Name = "textBoxIDEmp";
            this.textBoxIDEmp.ReadOnly = true;
            this.textBoxIDEmp.Size = new System.Drawing.Size(200, 29);
            this.textBoxIDEmp.TabIndex = 49;
            // 
            // textBoxDisIDStore
            // 
            this.textBoxDisIDStore.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisIDStore.Location = new System.Drawing.Point(192, 62);
            this.textBoxDisIDStore.Name = "textBoxDisIDStore";
            this.textBoxDisIDStore.ReadOnly = true;
            this.textBoxDisIDStore.Size = new System.Drawing.Size(200, 29);
            this.textBoxDisIDStore.TabIndex = 50;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(200, 731);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 57);
            this.buttonSave.TabIndex = 51;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(309, 731);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(95, 57);
            this.buttonPrint.TabIndex = 52;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(420, 731);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(95, 57);
            this.buttonClose.TabIndex = 53;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelDataInv
            // 
            this.labelDataInv.AutoSize = true;
            this.labelDataInv.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelDataInv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDataInv.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataInv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDataInv.Location = new System.Drawing.Point(39, 11);
            this.labelDataInv.Name = "labelDataInv";
            this.labelDataInv.Size = new System.Drawing.Size(97, 35);
            this.labelDataInv.TabIndex = 54;
            this.labelDataInv.Text = "INVOICE";
            // 
            // labelInputProduk
            // 
            this.labelInputProduk.AutoSize = true;
            this.labelInputProduk.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelInputProduk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInputProduk.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputProduk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInputProduk.Location = new System.Drawing.Point(37, 251);
            this.labelInputProduk.Name = "labelInputProduk";
            this.labelInputProduk.Size = new System.Drawing.Size(172, 35);
            this.labelInputProduk.TabIndex = 55;
            this.labelInputProduk.Text = "INPUT PRODUK";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(28, 218);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(981, 20);
            this.labelLine.TabIndex = 56;
            this.labelLine.Text = "_________________________________________________________________________________" +
    "___________________________";
            // 
            // dtpInvDate
            // 
            this.dtpInvDate.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvDate.Location = new System.Drawing.Point(190, 185);
            this.dtpInvDate.Name = "dtpInvDate";
            this.dtpInvDate.Size = new System.Drawing.Size(298, 29);
            this.dtpInvDate.TabIndex = 57;
            this.dtpInvDate.ValueChanged += new System.EventHandler(this.dtpInvDate_ValueChanged);
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStock.Font = new System.Drawing.Font("Yu Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelStock.Location = new System.Drawing.Point(276, 344);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(57, 23);
            this.labelStock.TabIndex = 58;
            this.labelStock.Text = "Stok :";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(764, 379);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(78, 42);
            this.buttonDelete.TabIndex = 59;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxPromoName
            // 
            this.textBoxPromoName.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPromoName.Location = new System.Drawing.Point(190, 606);
            this.textBoxPromoName.Name = "textBoxPromoName";
            this.textBoxPromoName.ReadOnly = true;
            this.textBoxPromoName.Size = new System.Drawing.Size(298, 29);
            this.textBoxPromoName.TabIndex = 60;
            // 
            // FormCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1062, 811);
            this.Controls.Add(this.textBoxPromoName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.dtpInvDate);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.labelInputProduk);
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
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDataCust);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCustName);
            this.Controls.Add(this.labelNoInv);
            this.Controls.Add(this.buttonMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCashier";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDataCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label labelInputProduk;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.DateTimePicker dtpInvDate;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxPromoName;
    }
}