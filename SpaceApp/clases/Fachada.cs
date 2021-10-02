using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.clases
{
    class Fachada
    {
        List<Pregunta> preguntas;
        List<Mision> misiones;

        public Fachada()
        {
            preguntas = new List<Pregunta>();
            misiones = new List<Mision>();

        }

        public void agregarPregunta(string pregunrta, int id_pregunta, string respuesta, int id_respuesta , int puntaje)
        {
            Pregunta p = new Pregunta(pregunrta, id_pregunta, respuesta, id_respuesta, puntaje);
            preguntas.Add(p);
        }


    }
}
