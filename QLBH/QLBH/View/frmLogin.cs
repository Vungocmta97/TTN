﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtID.Text;
            string password = txtPass.Text;
            if (username == "root" && password == "654321")
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                txtID.Clear();
                txtPass.Clear();
            }
        }
    }
}
