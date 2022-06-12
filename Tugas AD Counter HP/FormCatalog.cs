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
    public partial class FormCatalog : Form
    {
        public FormCatalog()
        {
            InitializeComponent();
        }
        public static string sqlconnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_02_PHONESTORE";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlconnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        DataTable produk = new DataTable();
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            this.Hide();
            formMenu.Show();
        }

        private void FormCatalog_Load(object sender, EventArgs e)
        {
            sqlQuery = "select PRODUCT_BRAND as 'Brand',PRODUCT_NAME as 'Nama Produk',PRODUCT_PRICE as 'Harga',PRODUCT_STOCK as 'Stok',PRODUCT_DESC as 'Spesifikasi' from PRODUCT;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(produk);
            dataGridViewCatalog.DataSource = produk;
        }

        private void dataGridViewCatalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewCatalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 )
            {
                DataGridViewRow baris = dataGridViewCatalog.Rows[e.RowIndex];
                richTextBoxSpesifikasi.Text = baris.Cells[4].Value.ToString();
            }
        }
    }
}
