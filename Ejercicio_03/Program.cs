using System;

namespace Ejercicio_03 {
	internal class Program {
		static void Main(string[] args) {
			/*
			Consigna
			Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
			Validar que el dato ingresado por el usuario sea un número.
			Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
			Si ingresa "salir", cerrar la consola.
			Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
			*/
			double numeroIngresado;
			double numeroParaMostrar=2;
			string continuar="";
			int contadorDeModulo=0;
			do {
				Console.WriteLine("Ingrese un numero");
				if(double.TryParse(Console.ReadLine(),out numeroIngresado)) {
					if(numeroIngresado>0) {
						while(numeroParaMostrar<numeroIngresado) {
							for(int i = 0;i<=numeroIngresado;i++) {
								if(numeroParaMostrar%i==0) {
									contadorDeModulo++;
								}
								if(contadorDeModulo>2) {
									break;
								}
							}
						if(contadorDeModulo==2) {
							Console.WriteLine($"{numeroParaMostrar} ES PRIMO");
						}
						numeroParaMostrar++;
						contadorDeModulo=0;
						}
					}
					else {
						Console.WriteLine("No puede ser numeros negativos o 0");
					}
				}
				else {
					Console.WriteLine("No es un numero");
				}
				Console.WriteLine("Desea continuar? Ingrese salir para cerrar el programa");
				continuar=Console.ReadLine().ToLower();
			}while(continuar!="salir");			
		}
	}
}
