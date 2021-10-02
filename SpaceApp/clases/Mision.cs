using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.clases
{
    class Mision: Fachada
    {

        byte etapa;
        string descripcion;

        public Mision(string descripcion,byte etapa)
        {
            this.etapa = etapa;
            this.descripcion = descripcion;
        }

        public byte Etapa { get => etapa; set => etapa = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public void AgregarDescripcion()
        {
            agregarMision("Su mision actual es realizar la construccion de su cohete para poder afrontar su viaje hacia el planeta marte",1);
            agregarMision("La nave necesita un impulso su mision es lograr que la nave cumpla su trayectoria",2);
            agregarMision("Bienvenido a Marte el gigante rojo su mision es lograr la colonizacion del planeta",3);



        }
    }

    
}
