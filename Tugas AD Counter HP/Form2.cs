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
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }
        public static string sqlconnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_02_PHONESTORE";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlconnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtDetailProd = new DataTable();
        private void comboBoxProdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlQuery = "SELECT product_name as 'Product Name', product_price as 'Product Price' from PRODUCT where product_id = '" + comboBoxProdID.SelectedItem.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetailProd);

            textBoxProdName.Text = dtDetailProd.Rows[0][0].ToString();
            textBoxProdPrice.Text = "Rp " + dtDetailProd.Rows[0][1].ToString();
        }
        int subtotal = 0;
        int quantity = 0;
        int price = 0;
        private void textBoxQuan_TextChanged(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(textBoxQuan.Text);
            price = Convert.ToInt32(dtDetailProd.Rows[0][1]);
            subtotal = quantity * price;
            labelDisSubTotal.Text = subtotal.ToString();
        }
    }
}
