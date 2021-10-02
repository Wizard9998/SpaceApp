using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.clases
{
    class Trayectoria
    {
        int distancia;

        public Trayectoria(int distancia)
        {
            distancia = 100;
        }

        public int Distancia { get => distancia; set => distancia = value; }
    }
}
