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
        
        int subtotal = 0;
        int quantity = 0;
        int price = 0;

        private void nudQuan_ValueChanged(object sender, EventArgs e)
        {
                price = Convert.ToInt32(currentPrice);
                subtotal = Convert.ToInt32(nudQuan.Value) * price;
                labelDisSubTotal.Text = subtotal.ToString();
        }

        private void comboBoxPromoID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        string currentPrice;
        private void comboBoxProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlQuery = "SELECT product_id as 'Product ID', product_price as 'Product Price' from PRODUCT where product_name = '" + comboBoxProdName.SelectedItem.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetailProd);

            textBoxProdID.Text = dtDetailProd.Rows[0][0].ToString();
            currentPrice = dtDetailProd.Rows[0][1].ToString();
            textBoxProdPrice.Text = "Rp " + dtDetailProd.Rows[0][1].ToString();
        }
    }
}
