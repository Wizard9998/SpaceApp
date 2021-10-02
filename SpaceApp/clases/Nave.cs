using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.clases
{
    class Nave 

        //m,
    {
        int vida;
        string nombre;

        public Nave(int vida, string nombre)
        {
            vida = 100;
            nombre = "Galileo";
        }

        public void Nave1()
        {
            int vida = 100;
            string nombre = "Galileo";

        }

        public int Vida { get => vida; set => vida = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
