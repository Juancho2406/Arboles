﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arboles
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAccederEscenario1_Click(object sender, EventArgs e)
        {
            Form escenario1 = new Escenario1();
            escenario1.Show();
        }

        private void btnAccederEscenario2_Click(object sender, EventArgs e)
        {
            Form escenario2 = new Escenario2();
            escenario2.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}