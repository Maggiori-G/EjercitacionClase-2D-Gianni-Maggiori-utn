using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadConcesionaria {
	public class Vehiculo {

		private string marca;
		private DateTime fechaDeProduccion;
		private bool ruedaDeNieve;
		private bool esNuevo;
		private Random generadorDePrecio=new Random();
		private decimal precioDelVehiculo;
		private bool esImportado;

		public Vehiculo(string marca,DateTime fechaDeProduccion,bool ruedaDeNieve,bool esNuevo) {
			this.marca=marca;
			this.fechaDeProduccion=fechaDeProduccion;
			this.ruedaDeNieve=ruedaDeNieve;
			this.esNuevo=esNuevo;
			this.precioDelVehiculo=generadorDePrecio.Next(350000,2000000);
		}
		public string Marca {
			get {
				return this.marca;
			}
		}
		public DateTime FechaDeProduccion {
			get {
				return this.fechaDeProduccion;
			}
		}
		public bool RuedaDeNieve {
			get {
				return this.ruedaDeNieve;
			}
		}
		public bool EsNuevo {
			get {
				return this.esNuevo;
			}
		}
		public decimal Precio {
			get {
				return this.precioDelVehiculo;
			}
		}
		public bool Importado {
			get {
				return this.esImportado;
			}
		}

		public override bool Equals(object? obj) {
			return obj is Vehiculo vehiculo&&
				   marca==vehiculo.marca&&
				   fechaDeProduccion==vehiculo.fechaDeProduccion&&
				   ruedaDeNieve==vehiculo.ruedaDeNieve&&
				   esNuevo==vehiculo.esNuevo&&
				   EqualityComparer<Random>.Default.Equals(generadorDePrecio,vehiculo.generadorDePrecio)&&
				   precioDelVehiculo==vehiculo.precioDelVehiculo&&
				   esImportado==vehiculo.esImportado&&
				   Marca==vehiculo.Marca&&
				   FechaDeProduccion==vehiculo.FechaDeProduccion&&
				   RuedaDeNieve==vehiculo.RuedaDeNieve&&
				   EsNuevo==vehiculo.EsNuevo&&
				   Precio==vehiculo.Precio&&
				   Importado==vehiculo.Importado;
		}

		public override int GetHashCode() {
			HashCode hash = new HashCode();
			hash.Add(marca);
			hash.Add(fechaDeProduccion);
			hash.Add(ruedaDeNieve);
			hash.Add(esNuevo);
			hash.Add(generadorDePrecio);
			hash.Add(precioDelVehiculo);
			hash.Add(esImportado);
			hash.Add(Marca);
			hash.Add(FechaDeProduccion);
			hash.Add(RuedaDeNieve);
			hash.Add(EsNuevo);
			hash.Add(Precio);
			hash.Add(Importado);
			return hash.ToHashCode();
		}

		public static bool operator ==(Vehiculo vehiculoUno, Vehiculo vehiculoDos) {
			return vehiculoUno is not null && vehiculoDos is not null && vehiculoUno.Marca ==vehiculoDos.Marca && vehiculoUno.FechaDeProduccion ==vehiculoDos.FechaDeProduccion;
		}
		public static bool operator !=(Vehiculo vehiculoUno, Vehiculo vehiculoDos) {
			return !(vehiculoUno==vehiculoDos);
		}
	}
}