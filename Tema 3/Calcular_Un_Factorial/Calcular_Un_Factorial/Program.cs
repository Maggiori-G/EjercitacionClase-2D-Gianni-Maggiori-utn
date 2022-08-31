namespace Calcular_Un_Factorial {
	public class Program {
		static void Main(string[] args) {
			double numeroIngresado;
			double resultado=0;
			Console.WriteLine("Ingresa un numero");
			if(double.TryParse(Console.ReadLine(), out numeroIngresado)) {
				resultado=ClaseFactorial.CalcularFactorial(numeroIngresado);
			}
			Console.WriteLine($"El factorial de {numeroIngresado} es {resultado}");
		}
	}
}