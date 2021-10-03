using System;
using System.Windows.Forms;

namespace SpaceApp.Forms
{
    public partial class Fase1 : Form
    {
        bool respuesta = false;
        int correcto=-1 ;
        public Fase1()

        {
            InitializeComponent();

        }
     
        private void btnResponder_Click(object sender, EventArgs e)
        {

            if (rdbRespuesta1.Checked == true)
            {
                correcto = 1;
                
            }

         
            }
        }
}
        
       


