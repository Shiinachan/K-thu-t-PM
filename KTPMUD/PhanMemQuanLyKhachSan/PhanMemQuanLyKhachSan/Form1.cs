﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if( txtUsername.Text == "Hust" && txtPassword.Text =="123")
            {
                labelError.Visible = false;
                dashboard ds = new dashboard();
                this.Hide();
                ds.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
