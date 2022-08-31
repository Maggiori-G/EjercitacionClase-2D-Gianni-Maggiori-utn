namespace EntidadesDeporte
{

    public class Jugador
    {

        private string nombre;
        private int edad;
        private int numeroCamiseta;
        private EPosicion posicion;

        public Jugador(string nombre, int edad, int numeroCamiseta, EPosicion posicion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.numeroCamiseta = numeroCamiseta;
            this.posicion = posicion;
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                CambiarNombre(value);
            }

        }

        private void CambiarNombre(string nombreTentativo)
        {
            if (ValidadoraString.CheckearSiNombreEsValido(nombreTentativo))
            {
                this.nombre = nombreTentativo;
            }
        }



    }
}