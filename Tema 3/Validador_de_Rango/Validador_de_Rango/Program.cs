namespace Validador_de_Rango {
	public class Program {
		static void Main(string[] args) {
			/*
			Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
			bool Validar(int valor, int min, int max)
			valor: dato a validar.
			min: mínimo valor incluido.
			max: máximo valor incluido.
			Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
			Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
			IMPORTANTE
			Utilizar variables escalares, NO utilizar vectores/arrays.
			*/
			int numeroIngresado;
			int maximoIngreso=int.MinValue;
			int minimoIngreso=int.MaxValue;
			float promedioIngresos;
			int acumuladorDeIngresos=0;
			for(int i = 0;i<10;i++) {
				Console.WriteLine("Ingrese un numero");
				if(int.TryParse(Console.ReadLine(),out numeroIngresado)) {
					if(Validador.Validar(numeroIngresado,-100,100)) {
						acumuladorDeIngresos+=numeroIngresado;
						if(i==0 ||numeroIngresado>maximoIngreso) {
							maximoIngreso=numeroIngresado;
						}
						if(i==0||numeroIngresado<minimoIngreso) {
							minimoIngreso=numeroIngresado;
						}
					}
				}
			}
			promedioIngresos=acumuladorDeIngresos/10;
			Console.WriteLine($"El valor minimo ingresado es {minimoIngreso}, el valor maximo es {maximoIngreso}, y el promedio es: {promedioIngresos}");
		}
	}
}