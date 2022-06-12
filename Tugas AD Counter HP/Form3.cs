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
using System.Globalization;

namespace Tugas_AD_Counter_HP
{
    public partial class FormNota : Form
    {
        public FormNota()
        {
            InitializeComponent();
        }
        public static string sqlconnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_02_PHONESTORE";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlconnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        public static string idStore2;
        public static string invDate2;


        DataTable dtStore = new DataTable();
        DataTable dtEmpName = new DataTable();
        private void FormNota_Load(object sender, EventArgs e)
        {
            //STORE
            idStore2 = FormInput.idStore;

            sqlQuery = "SELECT store_name, store_address from RETAIL_STORE where '"+ idStore2 +"' = store_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStore);

            labelStoreName.Text = dtStore.Rows[0][0].ToString();
            labelAddress.Text = dtStore.Rows[0][1].ToString();

            //INVOICE
            labelInvNo.Text = FormInput.invNo;
            labelDate.Text = FormInput.invDate;

            //CUSTOMER
            labelDisCustName.Text = FormInput.custName;
            labelDisCustPhone.Text = FormInput.custPhone;
            labelDisCustEmail.Text = FormInput.custEmail;

            //DGV PRODUCT
            dgvPrintProduct.DataSource = FormInput.dtShowProd2;



            //SUBTOTAL, PROMO, TOTAL
            labelDisSubTotal.Text = Decimal.Parse(FormInput.hitungTotal.ToString()).ToString("C", FormInput.culture);
            labelDisPromo.Text = FormInput.disc.ToString() + " %";
            int total = FormInput.hitungTotal - (FormInput.hitungTotal * FormInput.disc / 100);
            labelDisTotal.Text = Decimal.Parse(total.ToString()).ToString("C", FormInput.culture);

            //EMPLOYEE NAME
            sqlQuery = "SELECT emp_name FROM EMPLOYEE WHERE '"+ FormInput.empID +"' = emp_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEmpName);

            labelEmpName.Text = dtEmpName.Rows[0][0].ToString();
        }
    }
}
