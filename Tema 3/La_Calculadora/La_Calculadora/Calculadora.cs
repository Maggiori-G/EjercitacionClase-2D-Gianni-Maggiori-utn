using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Calculadora {
	public class Calculadora {
		private static bool Validar(decimal segundoOperando) {
			return segundoOperando>0;
		}
		public static decimal Calcular(decimal primerOperando,decimal segundoOperando,string operacion) {
			decimal resultado=0;
			switch(operacion) {
				case "*":
					resultado = primerOperando*segundoOperando;
				break;
				case "+":
					resultado =	primerOperando+segundoOperando;
				break;
				case "/":
					if(Validar(segundoOperando)) {
						resultado=primerOperando/segundoOperando;
					}
					else {
						resultado=0;
					}
				break;
				case "-":
					resultado=primerOperando-segundoOperando;
				break;
			}
			return resultado;
		}
	}
}
