using System;
using System.Collections;
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
        public void agregarPregunta(string pregunta, int id_pregunta, string respuesta, int id_respuesta, bool correcto)
        {
            Pregunta p = new Pregunta(pregunta, id_pregunta, respuesta, id_respuesta, correcto);
            preguntas.Add(p);
        }
        



    }
}
