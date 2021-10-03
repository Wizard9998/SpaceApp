using System;
using System.Windows.Forms;

namespace SpaceApp.Forms
{
    public partial class Fase1 : Form
    {
        bool respuesta = false;
        int a = 0;

        int correcto=-1 ;
        public Fase1()

        {
            InitializeComponent();
        }
        private void askQuestion(int correcto)
        {
            
            if (correcto == 1)
            {          
                lbPregunta.Text = "Nueva pregunta";
                correcto = +1;
            }
            if (correcto == 2)
            {
                lbPregunta.Text = "pregunta 2";
                correcto = +1;
            }
        }       
                

        private void btnResponder_Click(object sender, EventArgs e)
        {

            if (rdbRespuesta1.Checked == true)
            {
                correcto = 1;
                askQuestion(correcto);
            }

            if(correcto ==2) 
            {
                if(rdbRespuesta2.Checked == true) {
                    askQuestion(correcto);
                }
            }
        }
    }
}
        
       


