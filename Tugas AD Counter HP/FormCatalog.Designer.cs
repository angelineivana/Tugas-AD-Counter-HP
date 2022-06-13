
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
            this.buttonMenu = new System.Windows.Forms.Button();
            this.dataGridViewCatalog = new System.Windows.Forms.DataGridView();
            this.richTextBoxSpesifikasi = new System.Windows.Forms.RichTextBox();
            this.labelSpesifikasi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(1056, 650);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(118, 55);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "Back To Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // dataGridViewCatalog
            // 
            this.dataGridViewCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCatalog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCatalog.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalog.Location = new System.Drawing.Point(3, 38);
            this.dataGridViewCatalog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewCatalog.Name = "dataGridViewCatalog";
            this.dataGridViewCatalog.RowHeadersVisible = false;
            this.dataGridViewCatalog.RowHeadersWidth = 51;
            this.dataGridViewCatalog.RowTemplate.Height = 24;
            this.dataGridViewCatalog.Size = new System.Drawing.Size(694, 668);
            this.dataGridViewCatalog.TabIndex = 2;
            this.dataGridViewCatalog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCatalog_CellClick);
            this.dataGridViewCatalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCatalog_CellContentClick);
            // 
            // richTextBoxSpesifikasi
            // 
            this.richTextBoxSpesifikasi.Location = new System.Drawing.Point(704, 38);
            this.richTextBoxSpesifikasi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxSpesifikasi.Name = "richTextBoxSpesifikasi";
            this.richTextBoxSpesifikasi.Size = new System.Drawing.Size(470, 605);
            this.richTextBoxSpesifikasi.TabIndex = 3;
            this.richTextBoxSpesifikasi.Text = "";
            // 
            // labelSpesifikasi
            // 
            this.labelSpesifikasi.AutoSize = true;
            this.labelSpesifikasi.Location = new System.Drawing.Point(1090, 11);
            this.labelSpesifikasi.Name = "labelSpesifikasi";
            this.labelSpesifikasi.Size = new System.Drawing.Size(85, 20);
            this.labelSpesifikasi.TabIndex = 4;
            this.labelSpesifikasi.Text = "Spesifikasi";
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 719);
            this.Controls.Add(this.labelSpesifikasi);
            this.Controls.Add(this.richTextBoxSpesifikasi);
            this.Controls.Add(this.dataGridViewCatalog);
            this.Controls.Add(this.buttonMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCatalog";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.FormCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.DataGridView dataGridViewCatalog;
        private System.Windows.Forms.RichTextBox richTextBoxSpesifikasi;
        private System.Windows.Forms.Label labelSpesifikasi;
    }
}