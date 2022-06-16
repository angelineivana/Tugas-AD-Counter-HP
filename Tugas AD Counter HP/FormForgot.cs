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
    public partial class FormForgot : Form
    {
        public static string sqlconnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_02_PHONESTORE";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlconnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtCekDataEmp = new DataTable();
        DateTimePicker dtpEmpDOBClone = new DateTimePicker();
        string empDOB;
        public static string empID = "";
        public FormForgot()
        {
            InitializeComponent();
        }
        private void textBoxStoreID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxName.Text == "" || textBoxHP.Text == "" || textBoxEmpID.Text == "" || textBoxStoreID.Text == "")
            {
                MessageBox.Show("Data Belum Lengkap!");
            }
            else
            {
                buttonSubmit.Enabled = true;
            }
        }
        private void textBoxHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            dtpEmpDOBClone.Value = dtpDOB.Value;
            dtpEmpDOBClone.Format = DateTimePickerFormat.Custom;
            dtpEmpDOBClone.CustomFormat = "yyyy-MM-dd";
            empDOB = dtpEmpDOBClone.Value.ToString("yyyy-MM-dd");

            sqlQuery = "SELECT * FROM EMPLOYEE WHERE '" + textBoxUsername.Text + "' = emp_username and '" + textBoxName.Text + "' = emp_name and '" + empDOB + "' = emp_dob and '0' + '" + textBoxHP.Text + "' = emp_phone and '" + textBoxEmpID.Text + "' = emp_id and '" + textBoxStoreID.Text + "' = store_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCekDataEmp);

            if (dtCekDataEmp.Rows.Count > 0)
            {
                empID = textBoxEmpID.Text;
                FormChangePass formChangePass = new FormChangePass();
                this.Hide();
                formChangePass.Show();
            }
            else
            {
                MessageBox.Show("Data Tidak Sesuai");
            }
        }
    }
}
