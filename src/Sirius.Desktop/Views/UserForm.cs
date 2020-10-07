﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirius.Desktop.Views
{
    public partial class UserForm : Form
    {
        
        public UserForm()
        {
            InitializeComponent();
        }

        private void backUserButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MenuDesktopForm form1 = new MenuDesktopForm();
            form1.ShowDialog();
            this.Close();
            
        }
    }
}
