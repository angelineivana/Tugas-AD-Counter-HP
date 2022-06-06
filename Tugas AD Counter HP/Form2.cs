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
            dtShowProd2.Columns.Add("No");
            dtShowProd2.Columns.Add("NamaProduk");
            dtShowProd2.Columns.Add("Kuantitas");
            dtShowProd2.Columns.Add("Harga");
            dtShowProd2.Columns.Add("Jumlah");
            dgvPrintProduct2.DataSource = dtShowProd2;
        }
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
            dtDetailProd.Clear();
            sqlQuery = "SELECT product_id as 'Product ID', product_price as 'Product Price' from PRODUCT where product_name = '" + comboBoxProdName.SelectedItem.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetailProd);

            textBoxProdID.Text = dtDetailProd.Rows[0][0].ToString();
            currentPrice = dtDetailProd.Rows[0][1].ToString();
            textBoxProdPrice.Text = "Rp " + dtDetailProd.Rows[0][1].ToString();
        }
        DateTimePicker dtpInvDateClone = new DateTimePicker();
        int total = 0;
        int disc = 0;
        private void comboBoxPromoName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPromo.Clear();
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
            }
            else
            {
                textBoxPromoID.Text = dtPromo.Rows[0][0].ToString();
                disc = Convert.ToInt32(dtPromo.Rows[0][1]);
                textBoxDisc.Text = dtPromo.Rows[0][1].ToString() + " %";
            }
        }
        int no = 0;
        int subtotalAll = 0;
        DataTable dtShowProd2 = new DataTable();

        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            /*            object[] o = { no.ToString(), comboBoxProdName.SelectedItem.ToString(), nudQuan.Value.ToString(), textBoxProdPrice.Text, labelDisSubTotal.Text};
                        dtShowProd2.Rows.Add(o);*/
            dtShowProd2.Rows.Add((no + 1).ToString(), comboBoxProdName.SelectedItem.ToString(), nudQuan.Value.ToString(), textBoxProdPrice.Text, "Rp " + labelDisSubTotal.Text);
            no++;
            comboBoxProdName.Text = "";
            textBoxProdID.Text = "";
            textBoxProdPrice.Text = "";
            nudQuan.Value = 0;
            labelDisSubTotal.Text = "0";
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtShowProd2.Rows.Count; i++)
            {
                /*                subtotalAll += Convert.ToInt32(dgvPrintProduct2.Rows[i].Cells[4].Value.ToString());
                */
                subtotalAll = Convert.ToInt32(dtShowProd2.Rows[i][4].ToString());
                MessageBox.Show(subtotalAll.ToString());
/*                subtotalAll = subtotalAll + Convert.ToInt32(dtShowProd2.Rows[i][4].ToString());
*/            
            }
           
            if (textBoxDisc.Text != null)
            {
                total = subtotalAll - (subtotalAll * disc / 100);
                labelDisTotal.Text = total.ToString();
            }
        }

        private void dgvPrintProduct2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
