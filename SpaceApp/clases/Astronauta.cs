using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.clases
{
    class Astronauta
    {
        string nombre;
        string apellido;
        int edad;
        

        public Astronauta(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
           
        }
        

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

       
    }

}
