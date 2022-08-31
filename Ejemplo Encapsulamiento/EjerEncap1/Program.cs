using Entidades;
using System;

namespace EjerEncap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Perez", "Agustin", 12345);
            Alumno alumno2 = new Alumno("Garcia", "Jorge", 12346);
            Alumno alumno3 = new Alumno("Lopez", "Pablo", 12347);

            alumno1.PrimerNota = 8;
            alumno2.PrimerNota = 7;
            alumno3.PrimerNota = 9;

            alumno1.SegundaNota = 7;
            alumno2.SegundaNota = 9;
            alumno3.SegundaNota = 8;

            int notaFinal1 = alumno1.NotaFinal;
            int notaFinal2 = alumno2.NotaFinal;
            int notaFinal3 = alumno3.NotaFinal;

            Console.WriteLine("El alumno: " + alumno1.apellido + ", " + alumno1.nombre + " tiene como nota final: " + notaFinal1);
            Console.WriteLine("El alumno: " + alumno2.apellido + ", " + alumno2.nombre + " tiene como nota final: " + notaFinal2);
            Console.WriteLine("El alumno: " + alumno3.apellido + ", " + alumno3.nombre + " tiene como nota final: " + notaFinal3);
        }
    }
}
