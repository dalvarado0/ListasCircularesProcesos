﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesosListasCirculares
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        

        private void btnSimular_Click(object sender, EventArgs e)
        {
            Simulacion simulacion1 = new Simulacion(100);
            txbResultados.Text = simulacion1.simular();
            simulacion1.algo();
        }
    }
}
