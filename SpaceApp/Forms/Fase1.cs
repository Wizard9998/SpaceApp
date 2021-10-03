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
    public partial class Fase1 : Form
    {
        Fachada fachada;
        bool respuesta=false;
        
        
        public Fase1(Fachada unafachada)

        {

            this.fachada = unafachada;
            InitializeComponent();
        }

        private void btnResp1_Click(object sender, EventArgs e)
        {

        }

        private void Fase1_Load(object sender, EventArgs e)
        {
            int indice = -1;

        }

        private void Fase1_Load_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (rdbRespuesta1.Checked == true)
            {
                respuesta = true;

            }
            if (rdbRespuesta2.Checked == true)
            {
                respuesta = false;
                
            }
            if (rdbRespuesta3.Checked == true)
            {
                respuesta = false;
            }
            if (rdbRespuesta4.Checked == true)
            {
                respuesta = false;
                //bczhbxh
            }
            


        }

        private void lbPregunta_Click(object sender, EventArgs e)
        {

        }

        private void rdbRespuesta2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
