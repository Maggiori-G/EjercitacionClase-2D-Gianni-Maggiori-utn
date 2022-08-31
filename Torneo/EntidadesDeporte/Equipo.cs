using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDeporte
{
    public class Equipo
    {
        public static int cantidadEquiposCreados;
        public static Equipo equipoMasGanadorDeLaHistoria;

        static Equipo()
        {
            equipoMasGanadorDeLaHistoria = new Equipo(new Jugador[0]);
            cantidadEquiposCreados = 0;
        }


        private string nombre;
        Jugador[] arrayJugadores;
        int cantidadGolesDelEquipo;

        public Equipo(Jugador[] arrayJugadores)
        {
            cantidadGolesDelEquipo = 0;
            Equipo.cantidadEquiposCreados++;
            this.arrayJugadores = arrayJugadores;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public static bool CompararEquipos(Equipo e1,Equipo e2)
        {
            return e1.nombre == e2.nombre;
        }


    }
}
