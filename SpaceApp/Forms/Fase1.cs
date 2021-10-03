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
        bool respuesta = false;
        int a = 0;
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
                pictureBox2.Visible = true;
                rdbRespuesta1.Checked = false;
                
            }
            else MessageBox.Show("Respuesta incorrecta la respuesta correcta es " + rdbRespuesta1.Text);

            switch (a=1) {


            case 1:
                   
                    lbPregunta.Text = ("¿Cuál fue la primera nave espacial?");
                    rdbRespuesta1.Text = ("Apollo 1");
                    rdbRespuesta2.Text = ("Vostok 1");
                    rdbRespuesta3.Text = ("Discovery");
                    rdbRespuesta4.Text = ("Axioma");
                    
                    

                    break;
                case 2:
                    if (rdbRespuesta2.Checked == true)
                    {
                        respuesta = true;
                        pictureBox3.Visible = true;
                        rdbRespuesta2.Checked = false;

                        lbPregunta.Text = ("¿Cuál fue la nave espacial que llego a la luna?");
                        rdbRespuesta1.Text = ("Apollo 9");
                        rdbRespuesta2.Text = ("Vostok 1");
                        rdbRespuesta3.Text = ("Discovery");
                        rdbRespuesta4.Text = ("Apollo 11");
                    }
                    else MessageBox.Show("Respuesta incorrecta la respuesta correcta es " + rdbRespuesta2.Text);

                    break;
            
            }

        }
    }
}
