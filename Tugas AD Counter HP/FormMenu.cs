using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_AD_Counter_HP
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonCashier_Click(object sender, EventArgs e)
        {
            FormInput formInput = new FormInput();
            this.Hide();
            formInput.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCatalog_Click(object sender, EventArgs e)
        {
            FormCatalog formCatalog = new FormCatalog();
            this.Hide();
            formCatalog.Show();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            FormHistory formHistory = new FormHistory();
            this.Hide();
            formHistory.Show();
        }
    }
}
