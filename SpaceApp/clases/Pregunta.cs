using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.clases
{
    class Pregunta
    {
        string pregunta = " ";
        int id_pregunta;
        string respuesta = " ";
        int id_respuesta = 0; 
        int puntaje = 0;

        bool correcto = true;
        private string pregunrta;

        public Pregunta(string pregunrta, int id_pregunta, string respuesta, int id_respuesta, int puntaje)
        {
            this.pregunrta = pregunrta;
            this.id_pregunta = id_pregunta;
            this.respuesta = respuesta;
            this.id_respuesta = id_respuesta;
            this.puntaje = puntaje;
        }
    }
}
