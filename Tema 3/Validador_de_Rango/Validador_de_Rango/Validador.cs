using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validador_de_Rango {
	public class Validador {
		public static bool Validar(int valorIngresado, int maximoValor, int minimoValor) {
			return valorIngresado<minimoValor && valorIngresado>maximoValor;
		}
	}
}
