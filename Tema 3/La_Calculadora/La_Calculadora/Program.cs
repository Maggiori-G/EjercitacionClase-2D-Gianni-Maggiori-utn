namespace La_Calculadora {
	public class Program {
		static void Main(string[] args) {
			/*
			Consigna

			Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
			Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
			Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. 
			El método devolverá el resultado de la operación.
			Validar (privado): Recibirá como parámetro el segundo operando. 
			Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
			Este método devolverá true si el operando es distinto de cero.
			Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).
			El usuario decidirá cuándo finalizar el programa.
			*/
			decimal primerOperando;
			decimal segundoOperando;
			string operacion="";
			string seguir;
			decimal resultado;
			do {
				do {
					Console.WriteLine("Ingrese el primer numero");
				} while(!decimal.TryParse(Console.ReadLine(),out primerOperando));
				do {
					Console.WriteLine("Ingrese el segundo numero");
				} while(!decimal.TryParse(Console.ReadLine(),out segundoOperando));
				do {
					Console.WriteLine("Ingrese que operacion desea");
					operacion=Console.ReadLine();
				} while(operacion!="+"&&operacion!="-"&&operacion!="*"&&operacion!="/");

				resultado=Calculadora.Calcular(primerOperando,segundoOperando,operacion);

				Console.WriteLine($"El resultado de {primerOperando} {operacion} {segundoOperando} es: {resultado}");

				Console.WriteLine("Desea continuar operando? Ingrese s para seguir");
				seguir=Console.ReadLine().ToLower().Trim();
			} while(seguir=="s");
		}
	}
}