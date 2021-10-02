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
        Nave nave = new Nave(vida, string nombre);
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
       
          public void comprobarRespuesta(int distancia, int vida, int respuesta)
            {
                if (vida > 0)
                {
                    if (respuesta == 1)
                    {
                        do
                        {
                            distancia = +10;
                        } while (distancia < 10);
                    }
                    else
                    {
                        vida = vida - 10;
                    }
                }
                else
                {
                    Console.WriteLine("Te quedaste sin vidas");
                }
            }
     }
}

