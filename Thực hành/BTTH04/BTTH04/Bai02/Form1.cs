﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerSystemTime.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSystemTime.Text = DateTime.Now.ToString("dddd, dd MMMM, yyyy HH:mm:ss tt");
        }
    }
}
