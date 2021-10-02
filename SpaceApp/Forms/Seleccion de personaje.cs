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
    public partial class Seleccion : Form
    {
        Fachada fachada;
        public Seleccion(Fachada unafachada)

        {
           
            this.fachada = unafachada;
            InitializeComponent();
          
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
       
      
            private void btnAceptar_Click(object sender, EventArgs e)
            {
            btnAceptar.Visible = false;
            try { 
            string UnNombre = txtNombre.Text;
            string UnApellido = txtApellido.Text;
            int UnaEdad = Convert.ToInt32(txtEdad.Text);

            fachada.agregarAstronauta(UnNombre, UnApellido, UnaEdad);
            dataGridViewPersonaje.Rows.Add(UnNombre,UnApellido,UnaEdad);
            if (txtNombre.Text != " "){
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtEdad.Text = string.Empty;
            }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ya ingresaste un astronautoa");
            }
        }
        
     
       
        private void lblAstronautas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            PantallaCarga p = new PantallaCarga();
            p.Show();
            this.Close();
        }
    }
}
