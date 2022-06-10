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
        string sendtextform1 = "";
        private void FormInput_Load(object sender, EventArgs e)
        {
            sendtextform1 = FormLogin.sendtext;
            DataTable dtStoreEmpID = new DataTable();
            sqlQuery = "SELECT emp_id, store_id FROM EMPLOYEE where emp_username = '"+ sendtextform1 +"'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStoreEmpID);

            textBoxDisIDStore.Text = dtStoreEmpID.Rows[0][1].ToString();
            textBoxIDEmp.Text = dtStoreEmpID.Rows[0][0].ToString();

            //buat 5 kolom dtShowProd2 (dtshowprod2 buat source data dgvPrintProduct2)
            dtShowProd2.Columns.Add("No");
            dtShowProd2.Columns.Add("NamaProduk");
            dtShowProd2.Columns.Add("Kuantitas");
            dtShowProd2.Columns.Add("Harga");
            dtShowProd2.Columns.Add("Jumlah");
            dgvPrintProduct2.DataSource = dtShowProd2;

            DataTable dtNoInv = new DataTable();
            sqlQuery = "SELECT INV_NO FROM INVOICE";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNoInv);
            string angkaJalan = "";
            
            if (dtNoInv.Rows.Count + 1 < 100)
            {
                angkaJalan = "000";
                angkaJalan += dtNoInv.Rows.Count + 1;
            }
            else if (dtNoInv.Rows.Count + 1 < 1000)
            {
                angkaJalan = "00";
                angkaJalan += dtNoInv.Rows.Count + 1;
            }
            else if (dtNoInv.Rows.Count + 1 < 10000)
            {
                angkaJalan = "0";
                angkaJalan += dtNoInv.Rows.Count + 1;
            }
            else if (dtNoInv.Rows.Count + 1 < 100000)
            {
                angkaJalan += dtNoInv.Rows.Count + 1;
            }
            textBoxInvNo.Text = angkaJalan;

            DataTable dtIDCust = new DataTable();
            sqlQuery = "SELECT cust_id FROM CUSTOMER";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtIDCust);
            string angkaJalanCust = "";

            if (dtIDCust.Rows.Count + 1 < 100)
            {
                angkaJalanCust = "c_00";
                angkaJalanCust += dtNoInv.Rows.Count + 1;
            }
            else if (dtIDCust.Rows.Count + 1 < 1000)
            {
                angkaJalanCust = "c_0";
                angkaJalanCust += dtNoInv.Rows.Count + 1;
            }
            else if (dtIDCust.Rows.Count + 1 < 10000)
            {
                angkaJalanCust = "c_";
                angkaJalanCust += dtNoInv.Rows.Count + 1;
            }
            textBoxCustID.Text = angkaJalanCust;

            nudQuan.Enabled = false;
            comboBoxPromoName.Enabled = false;
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
        string[] arrayProdID = new string[100];
        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            if (comboBoxProdName.Text == "")
            {
                MessageBox.Show("Produk Belum Dipilih");
            }
            else if (nudQuan.Value == 0)
            {
                MessageBox.Show("Kuantitas Harus Lebih Dari 0");
            }
            else
            {
                dtShowProd2.Rows.Add((no + 1).ToString(), comboBoxProdName.SelectedItem.ToString(), nudQuan.Value.ToString(), textBoxProdPrice.Text, "Rp " + labelDisSubTotal.Text);
              
                arrayProdID[no] = textBoxProdID.Text;
                no++;
                comboBoxPromoName.Enabled = true;

                comboBoxProdName.Text = "";
                textBoxProdID.Text = "";
                textBoxProdPrice.Text = "";
                nudQuan.Value = 0;
                labelDisSubTotal.Text = "0";
            }
        }
        DateTimePicker dtpInvDateClone = new DateTimePicker();
        int total = 0;
        public static int disc = 0;
        string currentInvDate;
        private void comboBoxPromoName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPromo.Clear();
            comboBoxPromoName.ResetText();
            textBoxPromoID.Text = "";
            textBoxDisc.Text = "";
            dtpInvDateClone.Value = dtpInvDate.Value;
            dtpInvDateClone.Format = DateTimePickerFormat.Custom;
            dtpInvDateClone.CustomFormat = "yyyy-MM-dd";
            dtpInvDateClone.ShowUpDown = true;
            currentInvDate = dtpInvDateClone.Value.ToString("yyyy-MM-dd");

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

        private void buttonCountTotal_Click(object sender, EventArgs e)
        {
            labelDisTotal.Text = "0";
            for (int i = 0; i < dtShowProd2.Rows.Count; i++)
            {
                subtotalAll = subtotalAll + Convert.ToInt32(dtShowProd2.Rows[i][4].ToString().Substring(3));
            }
            if (comboBoxPromoName.SelectedItem != null)
            {
                total = subtotalAll - (subtotalAll * disc / 100);
                labelDisTotal.Text = total.ToString();
            }
            subtotalAll = 0;
        }
        int itemCount = 0;
        private void buttonFinish_Click(object sender, EventArgs e)
        {
            //customer
            sqlQuery = "INSERT INTO CUSTOMER VALUES ('"+textBoxCustID.Text+"', '"+ textBoxCustNama.Text +"', '"+ textBoxCustHP.Text +"', '"+ textBoxCustEmail.Text +"', '0')";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            //product stock
            for (int i = 0; i < dtShowProd2.Rows.Count; i++)
            {
                sqlQuery = "UPDATE PRODUCT SET product_stock = product_stock - " + Convert.ToInt32(dtShowProd2.Rows[i][2]) +" WHERE product_name = '"+ dtShowProd2.Rows[i][1].ToString() + "'";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            //product_invoice
            for (int a = 0; a < dtShowProd2.Rows.Count; a++)
            {
                sqlQuery = $"INSERT INTO PRODUCT_INVOICE VALUES ('" + arrayProdID[a].ToString() + "', '" + textBoxInvNo.Text + "', '"+ dtShowProd2.Rows[a][2].ToString() +"','"+ dtShowProd2.Rows[a][4].ToString().Substring(3) + "')";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                itemCount += Convert.ToInt32(dtShowProd2.Rows[a][2]);
            }

            //invoice
            sqlQuery = "INSERT INTO INVOICE VALUES ('" + textBoxInvNo.Text + "', '" + textBoxPromoID.Text + "', '" + textBoxDisIDStore.Text + "', '" + textBoxCustID.Text + "', '" + textBoxIDEmp.Text + "', '" + currentInvDate + "', "+ itemCount +", "+ disc +", "+ total +", '0')";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }
        public static string idStore = "";
        public static string invNo = "";
        public static string invDate = "";
        public static string custName = "";
        public static string custPhone = "";
        public static string custEmail = "";
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            idStore = textBoxDisIDStore.Text;
            invNo = textBoxInvNo.Text;
            invDate = dtpInvDate.Text;
            custName = textBoxCustNama.Text;
            custPhone = textBoxCustHP.Text;
            custEmail = textBoxCustEmail.Text;
            FormNota form3 = new FormNota();
            this.Hide();
            form3.Show();
        }
    }
}
