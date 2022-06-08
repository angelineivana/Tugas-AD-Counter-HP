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
        DataTable dtPromo = new DataTable();
        
        int subtotal = 0;
        int quantity = 0;
        int price = 0;
        private void FormInput_Load(object sender, EventArgs e)
        {
            //buat 5 kolom dtShowProd2 (dtshowprod2 buat source data dgvPrintProduct2)
            dtShowProd2.Columns.Add("No");
            dtShowProd2.Columns.Add("NamaProduk");
            dtShowProd2.Columns.Add("Kuantitas");
            dtShowProd2.Columns.Add("Harga");
            dtShowProd2.Columns.Add("Jumlah");
            dgvPrintProduct2.DataSource = dtShowProd2;

            nudQuan.Enabled = false;
        }
        string currentPrice;
        private void comboBoxProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dtDetailProd diclear setiap cbox nama produk diubah karena dibuat supaya berisi 1 row data saja (per nama produk)
            dtDetailProd.Clear();

            //product id buat textboxProdID, product price buat textboxProdPrice, select ketika namanya sama dengan cboxprodname
            sqlQuery = "SELECT product_id as 'Product ID', product_price as 'Product Price' from PRODUCT where product_name = '" + comboBoxProdName.SelectedItem.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetailProd);

            //row ke 0 karena dtDetailProd berisi 1 row saja dan kolom sesuai dengan query
            textBoxProdID.Text = dtDetailProd.Rows[0][0].ToString();
            textBoxProdPrice.Text = "Rp " + dtDetailProd.Rows[0][1].ToString();

            //buat variable baru bernama currentPrice untuk mengambil value harga per product yang blm dihitung
            currentPrice = dtDetailProd.Rows[0][1].ToString();

            nudQuan.Enabled = true;
        }
        private void nudQuan_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxProdName.Text == "")
            {
                nudQuan.Enabled = false;
            }
            else
            {
                price = Convert.ToInt32(currentPrice);
                subtotal = Convert.ToInt32(nudQuan.Value) * price;
                labelDisSubTotal.Text = subtotal.ToString();
            }
        }
        int no = 0;
        int subtotalAll = 0;
        DataTable dtShowProd2 = new DataTable();

        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            if (nudQuan.Value == 0)
            {
                MessageBox.Show("Kuantitas Harus Lebih Dari 0");
            }
            else if (comboBoxProdName.Text == "")
            {
                MessageBox.Show("Produk Belum Dipilih");
            }
            else
            {
                dtShowProd2.Rows.Add((no + 1).ToString(), comboBoxProdName.SelectedItem.ToString(), nudQuan.Value.ToString(), textBoxProdPrice.Text, labelDisSubTotal.Text);
                no++;
                comboBoxProdName.Text = "";
                textBoxProdID.Text = "";
                textBoxProdPrice.Text = "";
                nudQuan.Value = 0;
                labelDisSubTotal.Text = "0";
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            labelDisTotal.Text = "0";
            for (int i = 0; i < dtShowProd2.Rows.Count; i++)
            {
                /*                subtotalAll += Convert.ToInt32(dgvPrintProduct2.Rows[i].Cells[4].Value.ToString());
                */
                /* subtotalAll = Convert.ToInt32(dtShowProd2.Rows[i][4].ToString());
                 MessageBox.Show(subtotalAll.ToString());*/
                subtotalAll = subtotalAll + Convert.ToInt32(dtShowProd2.Rows[i][4].ToString());
            }
            if (comboBoxPromoName.SelectedIndex != null)
            {
                total = subtotalAll - (subtotalAll * disc / 100);
                labelDisTotal.Text = total.ToString();
            }
            subtotalAll = 0;
        }

        DateTimePicker dtpInvDateClone = new DateTimePicker();
        int total = 0;
        int disc = 0;
        private void comboBoxPromoName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPromo.Clear();
            textBoxPromoID.Text = "";
            textBoxDisc.Text = "";
            dtpInvDateClone.Value = dtpInvDate.Value;
            dtpInvDateClone.Format = DateTimePickerFormat.Custom;
            dtpInvDateClone.CustomFormat = "yyyy-MM-dd";
            dtpInvDateClone.ShowUpDown = true;
            string currentInvDate = dtpInvDateClone.Value.ToString("yyyy-MM-dd");

            sqlQuery = "SELECT promo_id as 'Promo ID', promo_disc as 'Promo Disc' from PROMO where PROMO_DESC = '" + comboBoxPromoName.SelectedItem.ToString() + "' and '" + currentInvDate + "' between PROMO_START_DATE and PROMO_END_DATE";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPromo);

            if (dtPromo.Rows.Count == 0)
            {
                MessageBox.Show("Promo Tidak Berlaku");
                comboBoxPromoName.ResetText();
                comboBoxPromoName.SelectedItem = null;
            }
            else
            {
                textBoxPromoID.Text = dtPromo.Rows[0][0].ToString();
                disc = Convert.ToInt32(dtPromo.Rows[0][1]);
                textBoxDisc.Text = dtPromo.Rows[0][1].ToString() + " %";
            }
        }
        int kembalian = 0;
        private void textBoxBayar_TextChanged(object sender, EventArgs e)
        {
            kembalian = Convert.ToInt32(textBoxBayar.Text) - Convert.ToInt32(labelDisTotal.Text);
            labelDisKembali.Text = kembalian.ToString();
        }
    }
}
