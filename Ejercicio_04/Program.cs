using System;
using System.Collections.Generic;

namespace Ejercicio_04 {
	internal class Program {
		static void Main(string[] args) {
			double contadorNumerosPerfectos=0;
			double numeroParaCalcular=2;
			double acumuladorDeModulos=0;
			List <double> listaNumerosPerfectos=new List<double>();

			while(contadorNumerosPerfectos<5) {
				for(int i = 1;i<numeroParaCalcular;i++) {
					if(numeroParaCalcular%i==0) {
						acumuladorDeModulos+=i;
					}
				}
				if(acumuladorDeModulos==numeroParaCalcular) {
					listaNumerosPerfectos.Add(numeroParaCalcular);
					contadorNumerosPerfectos++;
				}
				numeroParaCalcular++;
				acumuladorDeModulos=0;
			}
			foreach(double numeroPerfecto in listaNumerosPerfectos) {
				Console.WriteLine($"{numeroPerfecto} ES UN NUMERO PERFECTO");
			}
		}
	}
}