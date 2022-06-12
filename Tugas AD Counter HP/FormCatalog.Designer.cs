
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
            this.buttonMenu = new System.Windows.Forms.Button();
            this.dataGridViewCatalog = new System.Windows.Forms.DataGridView();
            this.richTextBoxSpesifikasi = new System.Windows.Forms.RichTextBox();
            this.labelSpesifikasi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(939, 520);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(105, 44);
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
            this.dataGridViewCatalog.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewCatalog.Name = "dataGridViewCatalog";
            this.dataGridViewCatalog.RowHeadersVisible = false;
            this.dataGridViewCatalog.RowHeadersWidth = 51;
            this.dataGridViewCatalog.RowTemplate.Height = 24;
            this.dataGridViewCatalog.Size = new System.Drawing.Size(617, 534);
            this.dataGridViewCatalog.TabIndex = 2;
            this.dataGridViewCatalog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCatalog_CellClick);
            this.dataGridViewCatalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCatalog_CellContentClick);
            // 
            // richTextBoxSpesifikasi
            // 
            this.richTextBoxSpesifikasi.Location = new System.Drawing.Point(626, 30);
            this.richTextBoxSpesifikasi.Name = "richTextBoxSpesifikasi";
            this.richTextBoxSpesifikasi.Size = new System.Drawing.Size(418, 485);
            this.richTextBoxSpesifikasi.TabIndex = 3;
            this.richTextBoxSpesifikasi.Text = "";
            // 
            // labelSpesifikasi
            // 
            this.labelSpesifikasi.AutoSize = true;
            this.labelSpesifikasi.Location = new System.Drawing.Point(969, 9);
            this.labelSpesifikasi.Name = "labelSpesifikasi";
            this.labelSpesifikasi.Size = new System.Drawing.Size(75, 17);
            this.labelSpesifikasi.TabIndex = 4;
            this.labelSpesifikasi.Text = "Spesifikasi";
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 575);
            this.Controls.Add(this.labelSpesifikasi);
            this.Controls.Add(this.richTextBoxSpesifikasi);
            this.Controls.Add(this.dataGridViewCatalog);
            this.Controls.Add(this.buttonMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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