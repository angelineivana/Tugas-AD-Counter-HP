
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalog));
            this.dataGridViewCatalog = new System.Windows.Forms.DataGridView();
            this.richTextBoxSpesifikasi = new System.Windows.Forms.RichTextBox();
            this.labelSpesifikasi = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.checkBoxCat = new System.Windows.Forms.CheckBox();
            this.checkBoxBrand = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).BeginInit();
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
            this.dataGridViewCatalog.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalog.Location = new System.Drawing.Point(14, 246);
            this.dataGridViewCatalog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewCatalog.Name = "dataGridViewCatalog";
            this.dataGridViewCatalog.RowHeadersVisible = false;
            this.dataGridViewCatalog.RowHeadersWidth = 51;
            this.dataGridViewCatalog.RowTemplate.Height = 24;
            this.dataGridViewCatalog.Size = new System.Drawing.Size(694, 394);
            this.dataGridViewCatalog.TabIndex = 2;
            this.dataGridViewCatalog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCatalog_CellClick);
            // 
            // richTextBoxSpesifikasi
            // 
            this.richTextBoxSpesifikasi.Location = new System.Drawing.Point(714, 246);
            this.richTextBoxSpesifikasi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxSpesifikasi.Name = "richTextBoxSpesifikasi";
            this.richTextBoxSpesifikasi.Size = new System.Drawing.Size(470, 268);
            this.richTextBoxSpesifikasi.TabIndex = 3;
            this.richTextBoxSpesifikasi.Text = "";
            // 
            // labelSpesifikasi
            // 
            this.labelSpesifikasi.AutoSize = true;
            this.labelSpesifikasi.Location = new System.Drawing.Point(1083, 211);
            this.labelSpesifikasi.Name = "labelSpesifikasi";
            this.labelSpesifikasi.Size = new System.Drawing.Size(85, 20);
            this.labelSpesifikasi.TabIndex = 4;
            this.labelSpesifikasi.Text = "Spesifikasi";
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.Navy;
            this.buttonMenu.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonMenu.Location = new System.Drawing.Point(1040, 583);
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
            this.comboBoxCat.Location = new System.Drawing.Point(36, 79);
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
            this.comboBoxBrand.Location = new System.Drawing.Point(36, 183);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(213, 28);
            this.comboBoxBrand.TabIndex = 31;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // checkBoxCat
            // 
            this.checkBoxCat.AutoSize = true;
            this.checkBoxCat.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCat.Location = new System.Drawing.Point(36, 35);
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
            this.checkBoxBrand.Location = new System.Drawing.Point(36, 142);
            this.checkBoxBrand.Name = "checkBoxBrand";
            this.checkBoxBrand.Size = new System.Drawing.Size(84, 26);
            this.checkBoxBrand.TabIndex = 34;
            this.checkBoxBrand.Text = "Brand";
            this.checkBoxBrand.UseVisualStyleBackColor = true;
            this.checkBoxBrand.CheckedChanged += new System.EventHandler(this.checkBoxBrand_CheckedChanged);
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1228, 684);
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
    }
}