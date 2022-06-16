using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tugas_AD_Counter_HP
{
    public partial class FormChangePass : Form
    {
        public static string sqlconnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_02_PHONESTORE";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlconnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        public FormChangePass()
        {
            InitializeComponent();
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxNewPass.Text.Length > 5)
            {
                MessageBox.Show("Password Tidak Boleh Lebih Dari 5 Karakter");
            }
            else if (textBoxNewPass.Text == "" || textBoxConfirm.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong");
            }
            else if (textBoxNewPass.Text != textBoxConfirm.Text)
            {
                MessageBox.Show("Input Tidak Sama");
            }
            else
            {
                sqlQuery = "UPDATE EMPLOYEE SET emp_pass = '" + textBoxConfirm.Text + "' WHERE emp_id = '" + FormForgot.empID + "'";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                MessageBox.Show("Password Telah Berhasil Diganti");

                FormLogin formLogin = new FormLogin();
                this.Hide();
                formLogin.Show();
            }
        }
    }
}
