using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Binarios_Y_Decimal {
	public class Conversor {

		public static string DecimalBinario(string sOperando) {
			int resto;
			string numeroBinario="Valor Invalido";
			if(int.TryParse(sOperando, out int entero)) {
				if(entero>0) {
					numeroBinario=string.Empty;
					for(int i = 0;entero>0;i++) {
						resto=entero%2;
						entero/=2;
						numeroBinario=resto.ToString()+numeroBinario;
					}
				}
			}			
			return numeroBinario;
		}
		public static string DecimalBinario(double operando) {
			return DecimalBinario(operando.ToString());
		}
		public static string BinarioDecimal(string sOperando) {
			char[] auxiliarChar= new char[sOperando.Length];
			Array.Copy(sOperando.ToArray(), auxiliarChar, sOperando.Length);
			Array.Reverse(auxiliarChar);
			string retorno="Valor Invalido";
			double auxiliarEntero=0;
			if(EsBinario(sOperando)){
				for(int i = 0;i<auxiliarChar.Length;i++) {
					if(auxiliarChar[i]=='1') {
						auxiliarEntero+=Math.Pow(2,i);
					}
				}
				retorno=auxiliarEntero.ToString();
			}
			return retorno;
		}
		private static bool EsBinario(string sOperando) {
			foreach(char auxiliar in sOperando) {
				if(auxiliar!='0'&&auxiliar!='1') {
					return false;
				}
			}
			return true;
		}
	}
}
