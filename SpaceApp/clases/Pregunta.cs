using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.clases
{
    class Pregunta : Fachada
    {
        Fachada fachada;

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

        public string Pregunta { get => pregunta; set => pregunta = value; }
        public int Id_pregunta { get => id_pregunta; set => id_pregunta = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
        public int Id_respuesta { get => id_respuesta; set => id_respuesta = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public bool Correcto { get => correcto; set => correcto = value; }

        public void pregunta1()
        {
            string pregunta = "¿Cuánto dura un día en Marte?";
            int id_pregunta = 1;
            string respuesta = "24,6h";
            int id_respuesta = 1;
            int puntaje = 10;
            bool correcto = true;
            fachada.agregarPregunta(pregunta,id_pregunta,respuesta,id_respuesta,puntaje,correcto);
        }

    }
}
