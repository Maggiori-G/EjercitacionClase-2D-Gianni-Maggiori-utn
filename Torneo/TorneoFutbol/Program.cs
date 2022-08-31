using EntidadesDeporte;


namespace TorneoFutbol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Jugador[] arrayJugadores = new Jugador[11];



            Jugador j1 = new Jugador("pepe", 25, 10, EPosicion.Arquero);
            Jugador j2 = new Jugador("pepe", 25, 10, EPosicion.Arquero);
            Jugador j3 = new Jugador("pepe", 25, 10, EPosicion.Arquero);
            Jugador j4 = new Jugador("pepe", 25, 10, EPosicion.Arquero);
            Jugador j5 = new Jugador("pepe", 25, 10, EPosicion.Arquero);
            Jugador j6 = new Jugador("pepe", 25, 10, EPosicion.Arquero);
            Jugador j7 = new Jugador("pepe", 25, 10, EPosicion.Arquero);


            arrayJugadores[0] = j1;
            arrayJugadores[1] = j2;
            arrayJugadores[2] = j3;
            arrayJugadores[3] = j4;
            arrayJugadores[4] = j5;
            arrayJugadores[5] = j6;
            arrayJugadores[6] = j7;


            Equipo equipoRocket = new Equipo(arrayJugadores);
            Equipo equipoRocket2 = new Equipo(arrayJugadores);


            Console.WriteLine(Equipo.cantidadEquiposCreados);


            if (Equipo.CompararEquipos(equipoRocket, equipoRocket2))
            {

            }




            ValidadoraString.LimiteCaracteres = 20;


            j1.Nombre = null;

            Console.ReadKey();
        }
    }
}