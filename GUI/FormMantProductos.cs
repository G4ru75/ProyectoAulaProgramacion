﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMantProductos : Form
    {
        public FormMantProductos()
        {
            InitializeComponent();
        }

        private void btnCerra_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
