﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasıveriTaşıma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        public string mesaj;
        public string kimden;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text=kimden; 
            label2.Text=mesaj;

        }
    }
}
