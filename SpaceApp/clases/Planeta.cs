using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace SpaceApp.clases
{
    class Planeta :Fachada
    {
        string dato;

        public Planeta(string dato)
        {
            this.dato = dato;
        }

        public string Dato { get => dato; set => dato = value; }

        public void AgregarDato()
        {
            agregarPlaneta("1.Pequeño Planeta: Si el Sol fuera tan alto como una puerta de entrada típica, la Tierra tendría el tamaño de una moneda de diez centavos y Marte sería tan grande como una tableta de aspirina.");
            agregarPlaneta("2.Cuarta Roca: Marte orbita nuestro Sol, una estrella.Marte es el cuarto planeta desde el Sol a una distancia promedio de unos 228 millones de kilómetros(142 millones de millas) o 1, 52 UA.");
            agregarPlaneta("3.Dias mas largos: Un día en Marte tarda un poco más de 24 horas. Marte realiza una órbita completa alrededor del Sol (un año en el tiempo marciano) en 687 días terrestres.");
            agregarPlaneta("4.Terreno accidentado: Marte es un planeta rocoso. Su superficie sólida ha sido alterada por volcanes, impactos, vientos, movimiento de la corteza y reacciones químicas.");
            agregarPlaneta("5.Trae un traje espacial: Marte tiene una atmósfera delgada compuesta principalmente de dióxido de carbono (CO 2 ), argón (Ar), nitrógeno (N 2 ) y una pequeña cantidad de oxígeno y vapor de agua.");
        }
       
    }
}
