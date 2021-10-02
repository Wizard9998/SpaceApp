﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.clases
{
    class Fachada
    {
        List<Pregunta> preguntas = new List<Pregunta>();
        List<Mision> misiones= new List<Mision>();
        List<Nave> naves= new List<Nave>();

       // static void recorer()
      //  {
      //      foreach (Pregunta pregunta in preguntas) { }
       // }

        public void agregarPregunta(string pregunta, int id_pregunta, string respuesta, int id_respuesta, bool correcto)
        {
            Pregunta p = new Pregunta(pregunta, id_pregunta, respuesta, id_respuesta, correcto);
            preguntas.Add(p);
        }

        public void agregarNave(int vida, string nombre)
        {
            Nave n = new Nave(vida, nombre);
            naves.Add(n);
        }

            static void comprobarRespuesta(int distancia, int vida, int respuesta)
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

