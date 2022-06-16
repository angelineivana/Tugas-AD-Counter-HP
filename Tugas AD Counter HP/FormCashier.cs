using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tugas_AD_Counter_HP
{
    public partial class FormCashier : Form
    {
        public FormCashier()
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
        DataTable dtStoreEmpID = new DataTable();
        DataTable dtNoInv = new DataTable();
        DataTable dtIDCust = new DataTable();
        DataTable dtCheckDatePromo = new DataTable();
        DataTable dtListProdID = new DataTable();
        DateTimePicker dtpInvDateClone = new DateTimePicker();
        int[] sub = new int[50];
        int price = 0;
        int kembalian = 0;
        int itemCount = 0;
        int statusBtnSave = 0;
        int statusBtnPaid = 0;
        int stock = 0;
        int no = 0;
        int indexRow = 0;
        string sendtextform1 = "";
        string currentPrice;
        string currentInvDate;
        public static CultureInfo culture = new CultureInfo("id-ID");
        public static DataTable dtShowProd2 = new DataTable();
        public static int hitungTotal = 0;
        public static int total = 0;
        public static int disc = 0;
        public static string idStore = "";
        public static string invNo = "";
        public static string invDate = "";
        public static string custName = "";
        public static string custPhone = "";
        public static string custEmail = "";
        public static string empID = "";
        public static string bayar = "";
        public static string kembali = "";

        private void FormInput_Load(object sender, EventArgs e)
        {
            dgvPrintProduct2.DataSource = dtShowProd2;

            sendtextform1 = FormLogin.sendtext;
            sqlQuery = "SELECT emp_id, store_id FROM EMPLOYEE WHERE emp_username = '" + sendtextform1 + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStoreEmpID);

            textBoxDisIDStore.Text = dtStoreEmpID.Rows[0][1].ToString();
            textBoxIDEmp.Text = dtStoreEmpID.Rows[0][0].ToString();

            //buat 5 kolom dtShowProd2 (dtshowprod2 buat source data dgvPrintProduct2)
            dtShowProd2.Columns.Add("No");
            dtShowProd2.Columns.Add("Nama Produk");
            dtShowProd2.Columns.Add("Kuantitas");
            dtShowProd2.Columns.Add("Harga");
            dtShowProd2.Columns.Add("Jumlah");


            //AUTO INCREMENT
            sqlQuery = "SELECT inv_no FROM INVOICE";
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
            //--

            dtpInvDate.Value = DateTime.Today;
            comboBoxProdName.Enabled = false;
            nudQuan.Enabled = false;
            textBoxBayar.Enabled = false;
            buttonPaid.Enabled = false;
            buttonAddProd.Enabled = false;
            buttonDelete.Enabled = false;

            dtCheckDatePromo.Clear();
            dtpInvDateClone.Value = dtpInvDate.Value;
            dtpInvDateClone.Format = DateTimePickerFormat.Custom;
            dtpInvDateClone.CustomFormat = "yyyy-MM-dd";
            currentInvDate = dtpInvDateClone.Value.ToString("yyyy-MM-dd");

            sqlQuery = "SELECT promo_id as 'Promo ID', promo_disc as 'Promo Disc', promo_desc as 'Promo Name' FROM PROMO WHERE '" + currentInvDate + "' between PROMO_START_DATE and PROMO_END_DATE";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCheckDatePromo);
            //check ada promo pada tgl itu
            if (dtCheckDatePromo.Rows.Count == 0)
            {
                textBoxPromoName.Text = "";
                textBoxPromoID.Text = "";
                textBoxDisc.Text = "";
                disc = 0;
            }
            else if (dtCheckDatePromo.Rows.Count != 0)
            {
                textBoxPromoName.Text = dtCheckDatePromo.Rows[0][2].ToString();
                textBoxPromoID.Text = dtCheckDatePromo.Rows[0][0].ToString();
                disc = Convert.ToInt32(dtCheckDatePromo.Rows[0][1]);
                textBoxDisc.Text = disc.ToString() + " %";
            }
            textBoxCustNama.Select();
        }

        private void textBoxCustNama_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCustNama.Text != "" && textBoxCustHP.Text != "" && textBoxCustEmail.Text != "")
            {
                if (textBoxCustHP.Text.Length >= 10)
                {
                    comboBoxProdName.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Format No. HP Salah");
                    comboBoxProdName.Enabled = false;
                }
            }
            else
            {
                comboBoxProdName.Enabled = false;
            }
        }
        private void textBoxCustHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBoxCustHP_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCustNama.Text != "" && textBoxCustHP.Text != "" && textBoxCustEmail.Text != "")
            {
                if (textBoxCustHP.Text.Length >= 10)
                {
                    comboBoxProdName.Enabled = true;
                }
                else
                {
                    comboBoxProdName.Enabled = false;
                }
            }
            else
            {
                comboBoxProdName.Enabled = false;
            }
        }
        private void textBoxCustEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCustNama.Text != "" && textBoxCustHP.Text != "" && textBoxCustEmail.Text != "")
            {
                if (textBoxCustHP.Text.Length >= 10)
                {
                    comboBoxProdName.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Format No. HP Salah");
                    comboBoxProdName.Enabled = false;
                }
            }
            else
            {
                comboBoxProdName.Enabled = false;
            }
        }
        private void comboBoxProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAddProd.Enabled = true;
            //dtDetailProd diclear setiap cbox nama produk diubah karena dibuat supaya berisi 1 row data saja (per nama produk)
            dtDetailProd.Clear();

            //product id buat textboxProdID, product price buat textboxProdPrice, select ketika namanya sama dengan cboxprodname
            sqlQuery = "SELECT product_id as 'Product ID', product_price as 'Product Price', product_stock as 'Product Stock' FROM PRODUCT WHERE product_name = '" + comboBoxProdName.SelectedItem.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetailProd);

            //row ke 0 karena dtDetailProd berisi 1 row saja dan kolom sesuai dengan query
            textBoxProdID.Text = dtDetailProd.Rows[0][0].ToString();

            //buat variable baru bernama currentPrice untuk mengambil value harga per product yang blm dikali qty
            currentPrice = dtDetailProd.Rows[0][1].ToString();
            textBoxProdPrice.Text = Decimal.Parse(currentPrice.ToString()).ToString("C", culture);
            stock = Convert.ToInt32(dtDetailProd.Rows[0][2].ToString());
            labelStock.Text = "Stok : " + stock.ToString();

            nudQuan.Enabled = true;
            labelDisSubTotal.Text = "Rp0,00";
            nudQuan.Value = 0;
        }
        private void nudQuan_ValueChanged(object sender, EventArgs e)
        {
            nudQuan.Maximum = stock;
            if (comboBoxProdName.Text == "")
            {
                nudQuan.Enabled = false;
            }
            else
            {
                price = Convert.ToInt32(currentPrice);
                sub[no] = Convert.ToInt32(nudQuan.Value) * price;
                labelDisSubTotal.Text = Decimal.Parse(sub[no].ToString()).ToString("C", culture);
            }
        }

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
                textBoxBayar.Enabled = true;
                this.dgvPrintProduct2.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dgvPrintProduct2.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dtShowProd2.Rows.Add((no + 1).ToString(), comboBoxProdName.SelectedItem.ToString(), nudQuan.Value.ToString(), textBoxProdPrice.Text.Substring(2), labelDisSubTotal.Text.Substring(2));
                
                for (int i = 0; i < dtShowProd2.Rows.Count; i++)
                {
                    dtShowProd2.Rows[i][0] = i + 1;
                }

                //HITUNG TOTAL
                hitungTotal += sub[no];
                if (textBoxDisc.Text == "")
                {
                    disc = 0;
                }
                else
                {
                    disc = Convert.ToInt32(textBoxDisc.Text.Substring(0, 2));
                }
                total = hitungTotal - (hitungTotal * disc / 100);
                labelDisTotal.Text = Decimal.Parse(total.ToString()).ToString("C", culture);
                no++;

                comboBoxProdName.Items.Remove(comboBoxProdName.SelectedItem);

                comboBoxProdName.Text = "";
                textBoxProdID.Text = "";
                textBoxProdPrice.Text = "";
                nudQuan.Value = 0;
                labelDisSubTotal.Text = "0";
                labelStock.Text = "Stok :";
            }
        }
        private void dgvPrintProduct2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtShowProd2.Rows.Count > 0)
            {
                buttonDelete.Enabled = true;
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            indexRow = dgvPrintProduct2.CurrentCell.RowIndex;
            comboBoxProdName.Items.Add(dtShowProd2.Rows[indexRow][1].ToString());
            dtShowProd2.Rows.RemoveAt(indexRow);

            for (int i = 0; i < dtShowProd2.Rows.Count; i++)
            {
                dtShowProd2.Rows[i][0] = i + 1;
            }           
            hitungTotal -= sub[indexRow];
            for (int i = indexRow; i <= dtShowProd2.Rows.Count; i++)
            {
                sub[i] = sub[i + 1];
            }

            if (textBoxDisc.Text == "")
            {
                disc = 0;
            }
            else
            {
                disc = Convert.ToInt32(textBoxDisc.Text.Substring(0, 2));
            }
            total = hitungTotal - (hitungTotal * disc / 100);
            labelDisTotal.Text = Decimal.Parse(total.ToString()).ToString("C", culture);
            no--;
        }
        private void textBoxBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBoxBayar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBayar.Text == "")
            {
                textBoxBayar.Text = "0";
            }
            else if (Convert.ToInt32(textBoxBayar.Text) <= total)
            {
                kembalian = 0;
            }
            else if (Convert.ToInt32(textBoxBayar.Text) > total)
            {
                kembalian = Convert.ToInt32(textBoxBayar.Text) - total;
            }
            labelDisKembali.Text = Decimal.Parse(kembalian.ToString()).ToString("C", culture);

            if (Convert.ToInt32(textBoxBayar.Text) >= total)
            {
                buttonPaid.Enabled = true;
            }
            else
            {
                buttonPaid.Enabled = false;
            }
        }
        private void buttonPaid_Click(object sender, EventArgs e)
        {
            statusBtnPaid = 1;
            MessageBox.Show("Invoice Telah Lunas");
            buttonPaid.Enabled = false;
            textBoxCustNama.Enabled = false;
            textBoxCustHP.Enabled = false;
            textBoxCustEmail.Enabled = false;
            comboBoxProdName.Enabled = false;
            nudQuan.Enabled = false;
            buttonAddProd.Enabled = false;
            buttonDelete.Enabled = false;
            textBoxBayar.Enabled = false;
            dgvPrintProduct2.Enabled = false;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            itemCount = 0;

            for (int i = 0; i < dtShowProd2.Rows.Count; i++)
            {
                sqlQuery = "SELECT product_id from PRODUCT where product_name = '" + dtShowProd2.Rows[i][1] + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListProdID);
            }

            if (statusBtnPaid == 1 && dtpInvDate.Text != "" && textBoxCustNama.Text != "" && textBoxCustHP.Text != "" && textBoxCustEmail.Text != "" && dtShowProd2.Rows.Count != 0 && labelDisTotal.Text != "0" && textBoxBayar.Text != "")
            {
                //customer
                sqlQuery = "INSERT INTO CUSTOMER VALUES ('" + textBoxCustID.Text + "', '" + textBoxCustNama.Text + "', '" + "0" + textBoxCustHP.Text + "', '" + textBoxCustEmail.Text + "', '0')";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                //product stock
                for (int i = 0; i < dtShowProd2.Rows.Count; i++)
                {
                    sqlQuery = "UPDATE PRODUCT SET product_stock = product_stock - " + Convert.ToInt32(dtShowProd2.Rows[i][2]) + " WHERE product_name = '" + dtShowProd2.Rows[i][1].ToString() + "'";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }

                //product_invoice
                for (int a = 0; a < dtShowProd2.Rows.Count; a++)
                {
                    int hasilParse = int.Parse("Rp" + dtShowProd2.Rows[a][4].ToString(), NumberStyles.Currency, culture);
                    sqlQuery = $"INSERT INTO PRODUCT_INVOICE VALUES ('" + dtListProdID.Rows[a][0].ToString() + "', '" + textBoxInvNo.Text + "', '" + dtShowProd2.Rows[a][2].ToString() + "','" + hasilParse.ToString() + "')";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    itemCount += Convert.ToInt32(dtShowProd2.Rows[a][2]);
                }

                //invoice
                if (textBoxPromoName.Text != "")
                {
                    sqlQuery = "INSERT INTO INVOICE VALUES ('" + textBoxInvNo.Text + "', '" + textBoxPromoID.Text + "', '" + textBoxDisIDStore.Text + "', '" + textBoxCustID.Text + "', '" + textBoxIDEmp.Text + "', '" + currentInvDate + "', " + itemCount + ", " + disc + ", " + total + ", '0')";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }
                else
                {
                    sqlQuery = "INSERT INTO INVOICE VALUES ('" + textBoxInvNo.Text + "', '" + textBoxPromoID.Text + "', '" + textBoxDisIDStore.Text + "', '" + textBoxCustID.Text + "', '" + textBoxIDEmp.Text + "', '" + currentInvDate + "', " + itemCount + ", " + disc + ", " + hitungTotal + ", '0')";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }

                MessageBox.Show("Invoice Telah Disimpan");
                statusBtnSave++;
            }
            else if (dtpInvDate.Text == "" || textBoxCustNama.Text == "" || textBoxCustHP.Text == "" || textBoxCustEmail.Text == "" || dtShowProd2.Rows.Count == 0 || labelDisTotal.Text == "0" || textBoxBayar.Text == "")
            {
                MessageBox.Show("Data Belum Lengkap!");
            }
            else if (statusBtnPaid == 0)
            {
                MessageBox.Show("Invoice Belum Dibayar");
            }
        }
        private void buttonPrint_Click(object sender, EventArgs e)
        {
           /* if (statusBtnSave == 0)
            {
                MessageBox.Show("Data Belum Disimpan");
            }
            else*/
            {
                bayar = textBoxBayar.Text;
                kembali = labelDisKembali.Text;
                idStore = textBoxDisIDStore.Text;
                invNo = textBoxInvNo.Text;
                invDate = dtpInvDate.Text;
                custName = textBoxCustNama.Text;
                custPhone = textBoxCustHP.Text;
                custEmail = textBoxCustEmail.Text;
                empID = textBoxIDEmp.Text;

                FormNota formNota = new FormNota();
                this.Hide();
                formNota.Show();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            dtDetailProd.Reset();
            dtPromo.Reset();
            dtStoreEmpID.Reset();
            dtNoInv.Reset();
            dtIDCust.Reset();
            dtCheckDatePromo.Reset();
            dtShowProd2.Reset();
            price = 0;
            sendtextform1 = "";
            no = 0;
            total = 0;
            disc = 0;
            kembalian = 0;
            itemCount = 0;
            statusBtnSave = 0;
            statusBtnPaid = 0;
            stock = 0;
            hitungTotal = 0;
            currentPrice = "";

            FormMenu formMenu = new FormMenu();
            this.Hide();
            formMenu.Show();
        }
    }
}
