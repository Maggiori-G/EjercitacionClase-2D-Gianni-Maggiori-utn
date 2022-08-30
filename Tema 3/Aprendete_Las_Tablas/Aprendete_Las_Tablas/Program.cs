using System.Text;

namespace Aprendete_Las_Tablas {
	public class Program {
		/*
		Consigna
		Crear una aplicación de consola que permita al usuario ingresar un número entero.
		Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.
		Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.
		Mostrar en la consola el resultado.
		Por ejemplo, si se ingresa el número 2 la salida deberá ser:
		*/
		static void Main(string[] args) {
			int numeroIngresado;
			Console.WriteLine("Ingresa un numero");
			if(int.TryParse(Console.ReadLine(),out numeroIngresado)){
				Console.WriteLine(Program.TablaDeMultiplicar(numeroIngresado));
			}
		}
		public static string TablaDeMultiplicar(int entero) {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Tabla de Multiplicar del {entero}");
			for(int i = 1;i<10;i++) {
				sb.AppendLine($"{entero} x {i} = {entero*i}");
			}
			return sb.ToString();
		}
	}
}