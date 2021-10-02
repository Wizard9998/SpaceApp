using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.clases
{
<<<<<<< HEAD
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
=======
    class Fachada
    {
        List<Pregunta> preguntas = new List<Pregunta>();
        List<Mision> misiones= new List<Mision>();
        List<Nave> naves= new List<Nave>();

       // static void recorer()
      //  {
      //      foreach (Pregunta pregunta in preguntas) { }
       // }

>>>>>>> 3323ca5556cef4abf1fdf71e373f0a4f22656d3b
        public void agregarPregunta(string pregunta, int id_pregunta, string respuesta, int id_respuesta, bool correcto)
        {
            Pregunta p = new Pregunta(pregunta, id_pregunta, respuesta, id_respuesta, correcto);
            preguntas.Add(p);
        }
<<<<<<< HEAD
        public void agregarAstronauta(string nombre,string apellido,int edad)
        {
            Astronauta a = new Astronauta(nombre, apellido, edad);
            astronautas.Add(a);
            

        }
       
          public void comprobarRespuesta(int distancia, int vida, int respuesta)
=======

        public void agregarNave(int vida, string nombre)
        {
            Nave n = new Nave(vida, nombre);
            naves.Add(n);
        }

            static void comprobarRespuesta(int distancia, int vida, int respuesta)
>>>>>>> 3323ca5556cef4abf1fdf71e373f0a4f22656d3b
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
<<<<<<< HEAD

       
    }
}
=======
        }



    }
>>>>>>> 3323ca5556cef4abf1fdf71e373f0a4f22656d3b

