namespace Error_Al_Cubo {
	public class Program {
		static void Main(string[] args) {
			/*
			Consigna
			Ingresar un número y mostrar el cuadrado y el cubo del mismo.
			Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
			*/
			double numeroIngresado;
			Console.WriteLine(("Ingrese un numero"));
			while(!double.TryParse(Console.ReadLine(), out numeroIngresado)||numeroIngresado<1) {
				Console.WriteLine("Error, reingrese!!!");
			}
			Console.WriteLine($"El numero ingresado fue: {numeroIngresado}, elevado al cuadrado es: {Math.Pow(numeroIngresado,2)}, y elevado al cubo es: {Math.Pow(numeroIngresado,3)}");

		}
	}
}