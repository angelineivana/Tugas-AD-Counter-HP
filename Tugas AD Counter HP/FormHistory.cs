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
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
        }
        public static string sqlconnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_02_PHONESTORE";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlconnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtInvoice = new DataTable();
        DataTable dtCusName = new DataTable();
        public static string custName;

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            this.Hide();
            formMenu.Show();
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            sqlQuery = "select date_format(i.INV_DATE, '%d-%m-%y') as 'Tanggal', c.CUST_NAME, c.CUST_PHONE, p.INV_NO, p.PRODUCT_ID, i.PROMO_ID, concat('Rp. ', p.INV_PRICE) as Total, e.EMP_NAME from PRODUCT_INVOICE p, INVOICE i, CUSTOMER c, EMPLOYEE e WHERE i.CUST_ID = c.CUST_ID and i.INV_NO = p.INV_NO and e.EMP_ID = i.EMP_ID group by c.CUST_NAME;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtInvoice);
            dGVHistory.DataSource = dtInvoice;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dtCusName.Clear();
            sqlQuery = "select date_format(i.INV_DATE, '%d-%m-%y') as 'Tanggal', c.CUST_NAME, c.CUST_PHONE, p.INV_NO, p.PRODUCT_ID, i.PROMO_ID, concat('Rp. ', p.INV_PRICE) as Total, e.EMP_NAME from PRODUCT_INVOICE p, INVOICE i, CUSTOMER c, EMPLOYEE e WHERE i.CUST_ID = c.CUST_ID and i.INV_NO = p.INV_NO and e.EMP_ID = i.EMP_ID and c.CUST_NAME like '%" + textBoxCustomer.Text + "%' or c.CUST_PHONE like '%" + textBoxCustomer.Text + "%' group by c.CUST_NAME ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCusName);
            dGVHistory.DataSource = dtCusName;
            if (dtCusName.Rows.Count > 0)
            {
                custName = dtCusName.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("ulangi");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormHistory_Load(sender, e);
            textBoxCustomer.Text = "";
        }
    }
}
