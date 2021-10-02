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

        public Pregunta(string pregunta, int id_pregunta, string respuesta, int id_respuesta, int puntaje, bool correcto)
        {
            this.pregunta = pregunta;
            this.id_pregunta = id_pregunta;
            this.respuesta = respuesta;
            this.id_respuesta = id_respuesta;
            this.puntaje = puntaje;
            this.correcto = correcto;
        }
    }
}
