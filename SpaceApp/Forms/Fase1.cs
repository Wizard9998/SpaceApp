using System;
using System.Windows.Forms;

namespace SpaceApp.Forms
{
    public partial class Fase1 : Form
    {
      
        public Fase1()

        {
            
            InitializeComponent();

        }
        private void Fase1_Load(object sender, EventArgs e)
        {
       
        }
        private void btnResponder_Click(object sender, EventArgs e)
        {

            if (rdbRespuesta1.Checked == true)
            {
                pictureBox2.Visible = (true);
                MessageBox.Show("Perfecto , haz acertado la respuesta");
                Fase2 f = new Fase2();
                f.Show();
                this.Close();
            }
            else MessageBox.Show("Respuesta incorrecta , vuelve a intentarlo");
        }

       
    }
}
        
       


