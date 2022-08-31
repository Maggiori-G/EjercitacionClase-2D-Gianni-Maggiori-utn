namespace Tirame_Un_Centro {
	public class Program {
		static void Main(string[] args) {
			
			decimal numeroIngresado;
			
			do {
				Console.WriteLine("Hasta que numero desea buscar centros numericos?");
			}while(!decimal.TryParse(Console.ReadLine(), out numeroIngresado));

		}
	}
}