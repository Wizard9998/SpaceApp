using SpaceApp.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpaceApp.Forms
{
    public partial class PantallaCarga : Form
    {
        Fachada fachada;
        public PantallaCarga()
        {
            InitializeComponent();
        }

        private void PantallaCarga_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fase1 f = new Fase1();
            f.Show();
            this.Close();
        }
    }
}
