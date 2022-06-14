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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        public static string sqlconnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_02_PHONESTORE";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlconnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string sendTextFromLogin;
        DataTable dtEmpNameID = new DataTable();
        private void FormMenu_Load(object sender, EventArgs e)
        {
            sendTextFromLogin = FormLogin.sendtext;
            sqlQuery = "SELECT emp_name, emp_id FROM EMPLOYEE WHERE emp_username = '" + sendTextFromLogin + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEmpNameID);

            labelDisEmpName.Text = dtEmpNameID.Rows[0][0].ToString();
            labelDisEmpID.Text = dtEmpNameID.Rows[0][1].ToString();
        }

        private void pictureBoxCashier_Click(object sender, EventArgs e)
        {
            FormCashier formInput = new FormCashier();
            this.Hide();
            formInput.Show();
        }

        private void pictureBoxCatalog_Click(object sender, EventArgs e)
        {
            FormCatalog formCatalog = new FormCatalog();
            this.Hide();
            formCatalog.Show();
        }

        private void pictureBoxSalesHistory_Click(object sender, EventArgs e)
        {
            FormHistory formHistory = new FormHistory();
            this.Hide();
            formHistory.Show();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
