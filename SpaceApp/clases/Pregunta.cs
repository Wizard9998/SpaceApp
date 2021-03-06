using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.clases
{
    class Pregunta : Fachada
    {
       

        string letra_pregunta = " ";
        int id_pregunta;
        string respuesta = " ";
        int id_respuesta = 0; 
       
        bool correcto = true;

       

        public Pregunta(string letra_pregunta, int id_pregunta, string respuesta, int id_respuesta,  bool correcto)
        {
            this.letra_pregunta = letra_pregunta;
            this.id_pregunta = id_pregunta;
            this.respuesta = respuesta;
            this.id_respuesta = id_respuesta;
           
            this.correcto = correcto;
        }

        public string Letra_pregunta { get => letra_pregunta; set => letra_pregunta = value; }
        public int Id_pregunta { get => id_pregunta; set => id_pregunta = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
        public int Id_respuesta { get => id_respuesta; set => id_respuesta = value; }
       
        public bool Correcto { get => correcto; set => correcto = value; }

        public void pregunta1()
        {
            bool correcto = true;
            agregarPregunta("¿De qué está compuesto su núcleo?", 13, "Hierro, níquel y azufre", 13, correcto);
            agregarPregunta("¿Cuál son los componentes de la atmosfera?", 14, "Dióxido de carbono, nitrógeno, argón", 14, correcto);
            agregarPregunta("¿Cuánto es la gravedad superficial?", 15, "3,71 m / s 2", 15, correcto);
            agregarPregunta("¿Entre cuanto varia su temperatura?", 12, "70GF a -225 GF", 12, correcto);
            agregarPregunta("¿Por qué lo vemos rojizo?", 11, "Debido a su oxidación en las rocas", 11, correcto);
            agregarPregunta("¿Hace cuanto se asentó en su diseño actual?", 10, "4.500 millones de años", 10, correcto);
            agregarPregunta("¿Tiene algún anillo?", 9, "No", 9, correcto);
            agregarPregunta("¿Cómo se llaman sus lunas?", 8, "Fobos y Deimos", 8, correcto);
            agregarPregunta("¿Cuánto tarda la luz solar llegar?", 7, "13 minutos", 7, correcto);
            agregarPregunta("¿A cuanta distancia esta del sol?", 6, "2", 6, correcto);
            agregarPregunta("¿Marte tiene volcanes?", 5, "1.5 unidades astronómicas", 5, correcto);
            agregarPregunta("¿Qué tipo de planeta es ?", 4, "Terrestre", 4, correcto);
            agregarPregunta("¿Cuántas lunas tiene?", 2, "2", 3, correcto);
            agregarPregunta("¿Cuánto dura un año en Marte?", 2, "687 días terrestres", 2, correcto);
            agregarPregunta("¿Cuánto dura un día en Marte?", 1, "24,6h", 1, correcto);
        }


    }
}
