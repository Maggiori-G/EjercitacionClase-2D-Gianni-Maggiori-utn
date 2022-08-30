namespace Desea_Continuar {
	public class Program {
		static void Main(string[] args) {
			/*
			Consigna
			Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
			Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
			El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
			*/
			int numeroIngresado;
			int acumuladorDeIngresos=0;
			string respuesta;
			do {
				Console.WriteLine("Ingrese un numero");
				if(int.TryParse(Console.ReadLine(),out numeroIngresado)) {
					acumuladorDeIngresos+=numeroIngresado;
				}
				Console.WriteLine("Desea continuar? S para seguir");
				respuesta=Console.ReadLine().ToLower();
			} while(Validador.ValidarRespuesta(respuesta));
		}
	}
}