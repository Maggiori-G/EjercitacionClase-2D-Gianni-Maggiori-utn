using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Un_Factorial {
	public static class ClaseFactorial {

		public static double CalcularFactorial(double numeroRecibido) {

			double factorial=0;
				
			if(numeroRecibido > 0) {
				factorial=factorial*CalcularFactorial(factorial-1);

			}
			else {
				factorial=1;
			}
			return factorial;
		}
	}
}
