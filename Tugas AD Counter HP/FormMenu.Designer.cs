
namespace Tugas_AD_Counter_HP
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.labelEmpID = new System.Windows.Forms.Label();
            this.labelDisEmpID = new System.Windows.Forms.Label();
            this.labelDisEmpName = new System.Windows.Forms.Label();
            this.pictureBoxPerson = new System.Windows.Forms.PictureBox();
            this.pictureBoxCashier = new System.Windows.Forms.PictureBox();
            this.pictureBoxCatalog = new System.Windows.Forms.PictureBox();
            this.pictureBoxSalesHistory = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalesHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpID.Location = new System.Drawing.Point(187, 106);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(44, 27);
            this.labelEmpID.TabIndex = 6;
            this.labelEmpID.Text = "ID :";
            // 
            // labelDisEmpID
            // 
            this.labelDisEmpID.AutoSize = true;
            this.labelDisEmpID.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisEmpID.Location = new System.Drawing.Point(227, 106);
            this.labelDisEmpID.Name = "labelDisEmpID";
            this.labelDisEmpID.Size = new System.Drawing.Size(27, 27);
            this.labelDisEmpID.TabIndex = 8;
            this.labelDisEmpID.Text = "...";
            // 
            // labelDisEmpName
            // 
            this.labelDisEmpName.AutoSize = true;
            this.labelDisEmpName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisEmpName.Location = new System.Drawing.Point(186, 75);
            this.labelDisEmpName.Name = "labelDisEmpName";
            this.labelDisEmpName.Size = new System.Drawing.Size(35, 31);
            this.labelDisEmpName.TabIndex = 7;
            this.labelDisEmpName.Text = "...";
            // 
            // pictureBoxPerson
            // 
            this.pictureBoxPerson.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPerson.Image")));
            this.pictureBoxPerson.Location = new System.Drawing.Point(36, 25);
            this.pictureBoxPerson.Name = "pictureBoxPerson";
            this.pictureBoxPerson.Size = new System.Drawing.Size(135, 151);
            this.pictureBoxPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPerson.TabIndex = 9;
            this.pictureBoxPerson.TabStop = false;
            // 
            // pictureBoxCashier
            // 
            this.pictureBoxCashier.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCashier.Image")));
            this.pictureBoxCashier.Location = new System.Drawing.Point(70, 195);
            this.pictureBoxCashier.Name = "pictureBoxCashier";
            this.pictureBoxCashier.Size = new System.Drawing.Size(286, 98);
            this.pictureBoxCashier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCashier.TabIndex = 10;
            this.pictureBoxCashier.TabStop = false;
            this.pictureBoxCashier.Click += new System.EventHandler(this.pictureBoxCashier_Click);
            // 
            // pictureBoxCatalog
            // 
            this.pictureBoxCatalog.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCatalog.Image")));
            this.pictureBoxCatalog.Location = new System.Drawing.Point(70, 278);
            this.pictureBoxCatalog.Name = "pictureBoxCatalog";
            this.pictureBoxCatalog.Size = new System.Drawing.Size(286, 98);
            this.pictureBoxCatalog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCatalog.TabIndex = 11;
            this.pictureBoxCatalog.TabStop = false;
            this.pictureBoxCatalog.Click += new System.EventHandler(this.pictureBoxCatalog_Click);
            // 
            // pictureBoxSalesHistory
            // 
            this.pictureBoxSalesHistory.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSalesHistory.Image")));
            this.pictureBoxSalesHistory.Location = new System.Drawing.Point(70, 361);
            this.pictureBoxSalesHistory.Name = "pictureBoxSalesHistory";
            this.pictureBoxSalesHistory.Size = new System.Drawing.Size(286, 98);
            this.pictureBoxSalesHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSalesHistory.TabIndex = 12;
            this.pictureBoxSalesHistory.TabStop = false;
            this.pictureBoxSalesHistory.Click += new System.EventHandler(this.pictureBoxSalesHistory_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(70, 445);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(286, 98);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 13;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(431, 575);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxSalesHistory);
            this.Controls.Add(this.pictureBoxCatalog);
            this.Controls.Add(this.pictureBoxPerson);
            this.Controls.Add(this.labelDisEmpID);
            this.Controls.Add(this.labelDisEmpName);
            this.Controls.Add(this.labelEmpID);
            this.Controls.Add(this.pictureBoxCashier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalesHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEmpID;
        private System.Windows.Forms.Label labelDisEmpID;
        private System.Windows.Forms.Label labelDisEmpName;
        private System.Windows.Forms.PictureBox pictureBoxPerson;
        private System.Windows.Forms.PictureBox pictureBoxCashier;
        private System.Windows.Forms.PictureBox pictureBoxCatalog;
        private System.Windows.Forms.PictureBox pictureBoxSalesHistory;
        private System.Windows.Forms.PictureBox pictureBoxExit;
    }
}