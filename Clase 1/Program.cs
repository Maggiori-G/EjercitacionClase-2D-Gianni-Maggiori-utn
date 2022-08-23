using System;

namespace Clase_01 {
	internal class Program {
		/*
		Consigna
		Ingresar 5 números por consola, guardándolos en una variable escalar. 
		Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
		*/
		static void Main(string[] args) {
			int minimoNumeroIngresado=int.MaxValue;
			int maximoNumeroIngresado=int.MinValue;
			int numeroIngresado;
			int acumuladorNumeros=0;
			float promedioDeNumerosIngresados=0;
			int i;
			bool flagPrimerIngreso=true;
			for(i = 0;i<5;i++) {
				Console.WriteLine("Ingresa un numero");
				if(int.TryParse(Console.ReadLine(), out numeroIngresado)) {
					acumuladorNumeros+=numeroIngresado;
					if(flagPrimerIngreso) {
						minimoNumeroIngresado= numeroIngresado;
						maximoNumeroIngresado= numeroIngresado;
						flagPrimerIngreso=false;
					}
					else {
						if(minimoNumeroIngresado>numeroIngresado) {
							minimoNumeroIngresado= numeroIngresado;
						}
						if(maximoNumeroIngresado<numeroIngresado) {
							maximoNumeroIngresado= numeroIngresado;
						}
					}
				}
				else {
					Console.WriteLine("No es un numero!!");
					i=i-1;
				}
			}
			promedioDeNumerosIngresados=acumuladorNumeros/i;
			if(flagPrimerIngreso) {
				Console.WriteLine("No se ingresaron numeros");
			}
			else {
				Console.WriteLine($"El mayor numero ingresado fue {maximoNumeroIngresado}, el menor fue {minimoNumeroIngresado}, y el promedio es {promedioDeNumerosIngresados}");
			}
		}
	}
}
