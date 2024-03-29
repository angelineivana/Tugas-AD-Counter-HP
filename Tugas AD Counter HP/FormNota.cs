﻿using System;
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
            idStore2 = FormCashier.idStore;

            sqlQuery = "SELECT store_name, store_address, store_phone from RETAIL_STORE where '"+ idStore2 +"' = store_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStore);

            labelStoreName.Text = dtStore.Rows[0][0].ToString().ToUpper();
            labelAddress.Text = dtStore.Rows[0][1].ToString().ToUpper();
            labelStoreNo.Text = dtStore.Rows[0][2].ToString().ToUpper();

            //INVOICE
            labelInvNo.Text = FormCashier.invNo;
            labelDate.Text = FormCashier.invDate.ToUpper();

            //CUSTOMER
            labelDisCustName.Text = FormCashier.custName.ToUpper();
            labelDisCustPhone.Text = "62" + FormCashier.custPhone;
            labelDisCustEmail.Text = FormCashier.custEmail.ToUpper();

            //DGV PRODUCT
            dgvPrintProduct.DataSource = FormCashier.dtShowProd2;
            this.dgvPrintProduct.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvPrintProduct.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //SUBTOTAL, PROMO, TOTAL
            labelDisSubTotal.Text = Decimal.Parse(FormCashier.hitungTotal.ToString()).ToString("C", FormCashier.culture);
            labelDisPromo.Text = FormCashier.disc.ToString() + " %";
            int total = FormCashier.hitungTotal - (FormCashier.hitungTotal * FormCashier.disc / 100);
            labelDisTotal.Text = Decimal.Parse(total.ToString()).ToString("C", FormCashier.culture);
            labelDisBayar.Text = Decimal.Parse(FormCashier.bayar.ToString()).ToString("C", FormCashier.culture);
            labelDisKembali.Text = FormCashier.kembali;

            //EMPLOYEE NAME
            sqlQuery = "SELECT emp_name FROM EMPLOYEE WHERE '"+ FormCashier.empID +"' = emp_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtEmpName);

            labelEmpSign.Text = dtEmpName.Rows[0][0].ToString();
            labelEmpName.Text = dtEmpName.Rows[0][0].ToString().ToUpper();
        }
    }
}
