﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirius.Desktop.Views
{
    public partial class MenuDesktopForm : Form
    {
        public MenuDesktopForm()
        {
            InitializeComponent();
        }
       

               
        

        
        private void btnClient_Click_1(object sender, EventArgs e)
        {

            this.Visible = false;
            ListCompanyForm form1 = new ListCompanyForm();
            form1.ShowDialog();
            this.Close();
        }
    }
}