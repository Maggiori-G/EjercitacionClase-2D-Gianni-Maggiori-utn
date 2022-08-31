using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Un_Factorial {
	public static class ClaseFactorial {

		public static double CalcularFactorial(double numeroRecibido) {
			if(numeroRecibido > 1) {
				numeroRecibido=numeroRecibido*CalcularFactorial(numeroRecibido-1);
			}
			else {
				numeroRecibido=1;
			}
			return numeroRecibido;
		}
	}
}
