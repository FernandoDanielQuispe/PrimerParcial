﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quispe.Fernando
{
    public partial class FrmMessageBox : Form
    {
        public FrmMessageBox()
        {
            InitializeComponent();
        }

        private void FrmMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
