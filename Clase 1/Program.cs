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
			for(i = 0;i<5;i++) {
				Console.WriteLine("Ingresa un numero");
				while(!int.TryParse(Console.ReadLine(), out numeroIngresado)) {
					Console.WriteLine("Error, ingrese solo numeros");
				}
				acumuladorNumeros+=numeroIngresado;
				if(i==0 ||maximoNumeroIngresado<numeroIngresado) {
					maximoNumeroIngresado=numeroIngresado;
				}
				if(i==0||minimoNumeroIngresado>numeroIngresado) {
					minimoNumeroIngresado=numeroIngresado;
				}
			}
			promedioDeNumerosIngresados=acumuladorNumeros/i;
			Console.WriteLine($"El mayor numero ingresado fue {maximoNumeroIngresado}, el menor fue {minimoNumeroIngresado}, y el promedio es {promedioDeNumerosIngresados}");
		}
	}
}
