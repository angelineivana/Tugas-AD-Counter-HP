﻿
namespace Tugas_AD_Counter_HP
{
    partial class FormCatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalog));
            this.dataGridViewCatalog = new System.Windows.Forms.DataGridView();
            this.richTextBoxSpesifikasi = new System.Windows.Forms.RichTextBox();
            this.labelSpesifikasi = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.checkBoxCat = new System.Windows.Forms.CheckBox();
            this.checkBoxBrand = new System.Windows.Forms.CheckBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCatalog
            // 
            this.dataGridViewCatalog.AllowUserToAddRows = false;
            this.dataGridViewCatalog.AllowUserToDeleteRows = false;
            this.dataGridViewCatalog.AllowUserToOrderColumns = true;
            this.dataGridViewCatalog.AllowUserToResizeColumns = false;
            this.dataGridViewCatalog.AllowUserToResizeRows = false;
            this.dataGridViewCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCatalog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCatalog.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCatalog.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCatalog.Location = new System.Drawing.Point(267, 33);
            this.dataGridViewCatalog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewCatalog.MultiSelect = false;
            this.dataGridViewCatalog.Name = "dataGridViewCatalog";
            this.dataGridViewCatalog.RowHeadersVisible = false;
            this.dataGridViewCatalog.RowHeadersWidth = 51;
            this.dataGridViewCatalog.RowTemplate.Height = 24;
            this.dataGridViewCatalog.Size = new System.Drawing.Size(995, 177);
            this.dataGridViewCatalog.TabIndex = 2;
            this.dataGridViewCatalog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCatalog_CellClick);
            // 
            // richTextBoxSpesifikasi
            // 
            this.richTextBoxSpesifikasi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBoxSpesifikasi.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSpesifikasi.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBoxSpesifikasi.Location = new System.Drawing.Point(502, 256);
            this.richTextBoxSpesifikasi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxSpesifikasi.Name = "richTextBoxSpesifikasi";
            this.richTextBoxSpesifikasi.Size = new System.Drawing.Size(760, 420);
            this.richTextBoxSpesifikasi.TabIndex = 3;
            this.richTextBoxSpesifikasi.Text = "";
            // 
            // labelSpesifikasi
            // 
            this.labelSpesifikasi.AutoSize = true;
            this.labelSpesifikasi.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpesifikasi.Location = new System.Drawing.Point(498, 230);
            this.labelSpesifikasi.Name = "labelSpesifikasi";
            this.labelSpesifikasi.Size = new System.Drawing.Size(96, 22);
            this.labelSpesifikasi.TabIndex = 4;
            this.labelSpesifikasi.Text = "Spesifikasi";
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Navy;
            this.buttonMenu.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonMenu.Location = new System.Drawing.Point(28, 701);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(145, 57);
            this.buttonMenu.TabIndex = 13;
            this.buttonMenu.Text = "Back To Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Items.AddRange(new object[] {
            "Smartphone",
            "Tablet",
            "Powerbank",
            "Earphone",
            "Speaker"});
            this.comboBoxCat.Location = new System.Drawing.Point(28, 100);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(213, 28);
            this.comboBoxCat.TabIndex = 14;
            this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCat_SelectedIndexChanged);
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Items.AddRange(new object[] {
            "Samsung",
            "Apple",
            "Xiaomi",
            "Baseus",
            "Oppo",
            "Harman-Kardon"});
            this.comboBoxBrand.Location = new System.Drawing.Point(28, 174);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(213, 28);
            this.comboBoxBrand.TabIndex = 31;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // checkBoxCat
            // 
            this.checkBoxCat.AutoSize = true;
            this.checkBoxCat.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCat.Location = new System.Drawing.Point(28, 68);
            this.checkBoxCat.Name = "checkBoxCat";
            this.checkBoxCat.Size = new System.Drawing.Size(106, 26);
            this.checkBoxCat.TabIndex = 33;
            this.checkBoxCat.Text = "Kategori";
            this.checkBoxCat.UseVisualStyleBackColor = true;
            this.checkBoxCat.CheckedChanged += new System.EventHandler(this.checkBoxCat_CheckedChanged);
            // 
            // checkBoxBrand
            // 
            this.checkBoxBrand.AutoSize = true;
            this.checkBoxBrand.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBrand.Location = new System.Drawing.Point(28, 142);
            this.checkBoxBrand.Name = "checkBoxBrand";
            this.checkBoxBrand.Size = new System.Drawing.Size(84, 26);
            this.checkBoxBrand.TabIndex = 34;
            this.checkBoxBrand.Text = "Brand";
            this.checkBoxBrand.UseVisualStyleBackColor = true;
            this.checkBoxBrand.CheckedChanged += new System.EventHandler(this.checkBoxBrand_CheckedChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(23, 33);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(84, 25);
            this.labelFilter.TabIndex = 35;
            this.labelFilter.Text = "Filter By";
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxProduct.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProduct.Image")));
            this.pictureBoxProduct.InitialImage = null;
            this.pictureBoxProduct.Location = new System.Drawing.Point(28, 256);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(447, 420);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProduct.TabIndex = 59;
            this.pictureBoxProduct.TabStop = false;
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1323, 804);
            this.Controls.Add(this.pictureBoxProduct);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.checkBoxBrand);
            this.Controls.Add(this.checkBoxCat);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelSpesifikasi);
            this.Controls.Add(this.richTextBoxSpesifikasi);
            this.Controls.Add(this.dataGridViewCatalog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.FormCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCatalog;
        private System.Windows.Forms.RichTextBox richTextBoxSpesifikasi;
        private System.Windows.Forms.Label labelSpesifikasi;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.CheckBox checkBoxCat;
        private System.Windows.Forms.CheckBox checkBoxBrand;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
    }
}