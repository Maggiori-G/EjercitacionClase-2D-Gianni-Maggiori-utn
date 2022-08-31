using System;
using System.Text;

namespace Entidades
{
    public class Alumno
    {
        private int nota1;
        private int nota2; 
        public string apellido;
        public string nombre;
        public int legajo;

        public Alumno(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }
        public int PrimerNota {

            get {
                return nota1;
            }
            set {
                if(value<0 || value>10) {
                    this.nota1 = 0;
                }
                else {
                    this.nota1 = value;
                }
            }
        }
        public int SegundaNota {
            get {
                return this.nota2;
            }
            set {
                if(value<0 || value>10) {
                    this.nota2 = 0;
                }
                else {
                    this.nota2 = value;
                }
            }
        }
        public int NotaFinal {
            get {
                return CalcularNotaFinal();
            }
        }
        private int CalcularNotaFinal()
        {
            if(this.nota1 > 4 && this.nota2 > 4)
            {
                return (this.nota1 + this.nota2) / 2; 
            }
            else
            {
                return 2; 
            }
        }
        public string AlumnoEncapsulado(string nombre, string apellido, string legajo) {
            string retorno=null;
            if(nombre is not null && apellido is not null && legajo is not null) {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Nombre: {nombre}");
                sb.AppendLine($"Apellido: {apellido}");
                sb.AppendLine($"Número de legajo: {legajo}");
                retorno = sb.ToString();
            }
            return retorno;
        }
    }
}
