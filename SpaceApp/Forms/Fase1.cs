using System;
using System.Windows.Forms;

namespace SpaceApp.Forms
{
    public partial class Fase1 : Form
    {
        bool respuesta = false;

        public Fase1()

        {
            InitializeComponent();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (rdbRespuesta1.Checked == true)
            {
                respuesta = true;
                pictureBox2.Visible = true;
            }
            else MessageBox.Show("Respuesta incorrecta la respuesta correcta es " + rdbRespuesta1.Text);
        }
    }
        
       
    }

}

