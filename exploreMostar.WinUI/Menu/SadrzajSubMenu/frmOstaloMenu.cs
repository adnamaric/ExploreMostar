﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exploreMostar.WinUI.Menu.SadrzajSubMenu
{
    public partial class frmOstaloMenu : Form
    {
        public frmOstaloMenu()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmJelaMenu frm = new frmJelaMenu();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmGradoviMenu frm = new frmGradoviMenu();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDrzaveMenu frm = new frmDrzaveMenu();
            frm.Show();
        }
    }
}