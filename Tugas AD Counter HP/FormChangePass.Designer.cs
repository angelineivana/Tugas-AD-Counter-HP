
namespace Tugas_AD_Counter_HP
{
    partial class FormChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePass));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Change Your Password";
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxNewPass.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNewPass.Location = new System.Drawing.Point(30, 128);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(304, 29);
            this.textBoxNewPass.TabIndex = 12;
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPass.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelNewPass.Location = new System.Drawing.Point(26, 105);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(131, 22);
            this.labelNewPass.TabIndex = 11;
            this.labelNewPass.Text = "New Password";
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxConfirm.Location = new System.Drawing.Point(30, 207);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.Size = new System.Drawing.Size(304, 29);
            this.textBoxConfirm.TabIndex = 14;
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirm.ForeColor = System.Drawing.Color.CadetBlue;
            this.labelConfirm.Location = new System.Drawing.Point(26, 184);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(202, 22);
            this.labelConfirm.TabIndex = 13;
            this.labelConfirm.Text = "Confirm New Password";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Firebrick;
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSubmit.Location = new System.Drawing.Point(30, 365);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(90, 47);
            this.buttonSubmit.TabIndex = 74;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(445, 437);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxConfirm);
            this.Controls.Add(this.labelConfirm);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.labelNewPass);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.TextBox textBoxConfirm;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.Button buttonSubmit;
    }
}