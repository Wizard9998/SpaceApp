using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.clases
{
    public class Fachada
    {
        List<Pregunta> preguntas;
        List<Mision> misiones;
        List<Astronauta> astronautas;
        public Fachada()
        {
            preguntas = new List<Pregunta>();
            misiones = new List<Mision>();
            astronautas = new List<Astronauta>();
           
        }
        public void agregarPregunta(string pregunta, int id_pregunta, string respuesta, int id_respuesta, bool correcto)
        {
            Pregunta p = new Pregunta(pregunta, id_pregunta, respuesta, id_respuesta, correcto);
            preguntas.Add(p);
        }
        public void agregarAstronauta(string nombre,string apellido,int edad)
        {
            Astronauta a = new Astronauta(nombre, apellido, edad);
            astronautas.Add(a);
            

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

