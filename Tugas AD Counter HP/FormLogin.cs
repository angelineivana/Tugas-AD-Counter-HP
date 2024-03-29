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

namespace Tugas_AD_Counter_HP
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public static string sqlconnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_02_PHONESTORE";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlconnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        public static string sendtext;
        int statusSalah = 0;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM EMPLOYEE WHERE EMP_USERNAME =  '" + textBoxUsername.Text.Trim() + "' and EMP_PASS = '" + textBoxPassword.Text.Trim() + "'";
            DataTable dtLogin = new DataTable();
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtLogin);
            if (dtLogin.Rows.Count == 1)
            {
                sendtext = textBoxUsername.Text;
                FormMenu formMenu = new FormMenu();
                this.Hide();
                formMenu.Show();
            }
            else
            {
                MessageBox.Show("Username / Password Salah!");
                statusSalah++;
            }

            if (statusSalah > 3)
            {
                MessageBox.Show("Lupa Password? Click Label 'Forgot Your Password? Click Here!'");
            }
        }

        private void labelForgot_Click(object sender, EventArgs e)
        {
            FormForgot formForgot = new FormForgot();
            this.Hide();
            formForgot.Show();
        }
    }
}
