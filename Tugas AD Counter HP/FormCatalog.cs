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
        DataTable kategori = new DataTable();
        DataTable katBrand = new DataTable();
        DataTable brand = new DataTable();
        DataTable fotoProduk = new DataTable();
        private void FormCatalog_Load(object sender, EventArgs e)
        {
            sqlQuery = "select PRODUCT_BRAND as 'Brand',PRODUCT_NAME as 'Nama Produk',PRODUCT_PRICE as 'Harga',PRODUCT_STOCK as 'Stok',PRODUCT_DESC as 'Spesifikasi' from PRODUCT;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(produk);
            dataGridViewCatalog.DataSource = produk;

            comboBoxCat.Enabled = false;
            comboBoxBrand.Enabled = false;
            checkBoxCat.Checked = false;
            checkBoxBrand.Checked = false;
        }

        private void dataGridViewCatalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fotoProduk.Clear();
            if (e.RowIndex != -1)
            {
                DataGridViewRow baris = dataGridViewCatalog.Rows[e.RowIndex];
                richTextBoxSpesifikasi.Text = baris.Cells[4].Value.ToString();
                MessageBox.Show(baris.Index.ToString());

                /*                sqlQuery = "SELECT * FROM (SELECT ROW_NUMBER() OVER (ORDER BY PRODUCT_ID) row_num, PRODUCT_IMAGE_URL FROM PRODUCT) t WHERE row_num - 1 = '"+ baris.Index +"'";
                */
                sqlQuery = "select PRODUCT_IMAGE_URL from PRODUCT where '" + baris.Cells[1].Value.ToString() +"' = PRODUCT_NAME";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(fotoProduk);
                pictureBoxProduct.ImageLocation = fotoProduk.Rows[0][0].ToString();
            }
        }
        private void dataSource()
        {
            if (checkBoxBrand.Checked == false && checkBoxCat.Checked == false)
            { 
                dataGridViewCatalog.DataSource = produk;
            }
            else if (checkBoxBrand.Checked == false && checkBoxCat.Checked == true)
            {
                dataGridViewCatalog.DataSource = kategori;
            }
            else if (checkBoxBrand.Checked == true && checkBoxCat.Checked == false)
            {
                dataGridViewCatalog.DataSource = brand;
            }
            else if (checkBoxBrand.Checked == true && checkBoxCat.Checked == true)
            {
                dataGridViewCatalog.DataSource = katBrand;
            }
        }
        private void fillKategori()
        {
            if (comboBoxCat.SelectedIndex != -1)
            {
                kategori.Clear();
                sqlQuery = "select P.PRODUCT_BRAND as 'Brand', P.PRODUCT_NAME as 'Nama Produk', P.PRODUCT_PRICE as 'Harga', P.PRODUCT_STOCK as 'Stok', P.PRODUCT_DESC as 'Spesifikasi' from PRODUCT P, CATEGORY C where P.CAT_ID = C.CAT_ID and C.CAT_NAME = '" + comboBoxCat.SelectedItem.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(kategori);
            }
        }

        private void fillBrand()
        {
            if (comboBoxBrand.SelectedIndex != -1)
            {
                brand.Clear();
                sqlQuery = "select PRODUCT_BRAND as 'Brand', PRODUCT_NAME as 'Nama Produk', PRODUCT_PRICE as 'Harga', PRODUCT_STOCK as 'Stok', PRODUCT_DESC as 'Spesifikasi' from PRODUCT where PRODUCT_BRAND = '" + comboBoxBrand.SelectedItem.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(brand);
            }
        }
        private void fillKatBrand()
        {
            if (comboBoxBrand.SelectedIndex != -1 && comboBoxCat.SelectedIndex != -1)
            {
                katBrand.Clear();
                sqlQuery = "select P.PRODUCT_BRAND as 'Brand', P.PRODUCT_NAME as 'Nama Produk', P.PRODUCT_PRICE as 'Harga', P.PRODUCT_STOCK as 'Stok', P.PRODUCT_DESC as 'Spesifikasi' from PRODUCT P, CATEGORY C where P.CAT_ID = C.CAT_ID and C.CAT_NAME = '" + comboBoxCat.SelectedItem.ToString() + "' and P.PRODUCT_BRAND = '" + comboBoxBrand.SelectedItem.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(katBrand);
            }
        }
        //Kategori checked, comboboxcat dipilih, brand checked, combobrand pilih, combocat diubah
        private void checkBoxCat_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCat.Text = null;
            comboBoxCat.SelectedIndex = -1;
            if (checkBoxCat.Checked == true)
            {
                comboBoxCat.Enabled = true;
            }
            else
            {
                comboBoxCat.Enabled = false;
            }
        }
        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillKategori();
            if (checkBoxBrand.Checked == true && checkBoxCat.Checked == true)
            {
                fillKatBrand();
            }
            dataSource();
        }

        private void checkBoxBrand_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxBrand.SelectedItem = null;
            comboBoxBrand.SelectedIndex = -1;
            if (checkBoxBrand.Checked == true)
            {
                comboBoxBrand.Enabled = true;
            }
            else
            {
                comboBoxBrand.Enabled = false;
            }
        }
        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillBrand();

            if (checkBoxBrand.Checked == true && checkBoxCat.Checked == true)
            {
                fillKatBrand();
            }

            dataSource();
        }
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            this.Hide();
            formMenu.Show();
        }
    }
}
