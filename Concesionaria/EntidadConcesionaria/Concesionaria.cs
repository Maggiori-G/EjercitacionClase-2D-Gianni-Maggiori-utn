using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadConcesionaria {
	public class Concesionaria {

		private string gerente;
		private string ubicacion;
		private List <Vehiculo> listaDeAutos;
		private string numeroDeTelefono;
		private List<Vehiculo> listaDeAutosVendidos;

		public Concesionaria(string gerente,string ubicacion, string numeroDeTelefono) {
			this.gerente=gerente;
			this.ubicacion=ubicacion;
			this.listaDeAutos= new List<Vehiculo>();
			this.listaDeAutosVendidos=new List<Vehiculo>();
			this.numeroDeTelefono=numeroDeTelefono;
		}

		public string Gerente {
			get {
				return this.gerente;
			}
		}
		public string Ubicacion {
			get {
				return this.ubicacion;
			}
		}
		public decimal Recaudacion {
			get {
				return CalcularRecaudacion(listaDeAutosVendidos);
			}
		}

		private bool ConsultarEspacio() {
			return this.listaDeAutos.Count>0 && this.listaDeAutos.Count <15;
		}
		
		public List<Vehiculo> AgregarVehiculo(List<Vehiculo> listaDeAutos, Vehiculo nuevoVehiculo) {
			if(ConsultarEspacio() && ComprobarFecha(5,nuevoVehiculo)) {
				listaDeAutos.Add(nuevoVehiculo);				
			}
			return listaDeAutos;
		}
		private decimal CalcularRecaudacion(List<Vehiculo> listaDeAutosVendidos) {
			decimal recaudacion = 0;
			if(listaDeAutosVendidos is not null) {
				if(listaDeAutosVendidos.Count()>0) {
					foreach(Vehiculo item in listaDeAutosVendidos) {
						recaudacion+=item.Precio;
					}
				}
			}
			return recaudacion;
		}
		private int CalcularDiferenciaAnios(Vehiculo nuevoVehiculo) {
			DateTime fechaParaComparar=new DateTime();
			int anioModelo;
			
			anioModelo=fechaParaComparar.Year - nuevoVehiculo.FechaDeProduccion.Year;
			if(fechaParaComparar<nuevoVehiculo.FechaDeProduccion.AddYears(anioModelo)) {
				anioModelo--;
			}
			return anioModelo;
		}
		private bool ComprobarFecha(int anios, Vehiculo nuevoVehiculo) {
			return CalcularDiferenciaAnios(nuevoVehiculo)<anios;
		}
		public string MostrarDatosVehiculo(Vehiculo vehiculoParaMostrar) {
			StringBuilder sb= new StringBuilder();
			if(vehiculoParaMostrar is not null) {
				sb.AppendLine($"Marca: {vehiculoParaMostrar.Marca} Fecha del Modelo: {vehiculoParaMostrar.FechaDeProduccion}");
				if(vehiculoParaMostrar.EsNuevo) {
					sb.AppendLine($"Estado: Nuevo ");
				}
				else {
					sb.AppendLine($"Estado: Usado ");
				}
				if(vehiculoParaMostrar.RuedaDeNieve) {
					sb.Append($"Las cubiertas estan preparadas para la nieve");
				}
				else {
					sb.Append($"Las cubiertas no estan preparadas para la nieve");
				}
				sb.AppendLine($"Precio del vehiculo: {vehiculoParaMostrar.Precio} ");
				if(vehiculoParaMostrar.Importado) {
					sb.Append($"El vehiculo es importado");
				}
				else {
					sb.Append($"El vehiculo es nacional");
				}
			}
			return sb.ToString();
		}
		private bool ComprobarSiTenemosElVehiuclo(List<Vehiculo> listaDeAutos, Vehiculo vehiculoParaVender) {
			return listaDeAutos.Contains(vehiculoParaVender);
		}
		public bool VenderAuto(List<Vehiculo> listaDeAutos, Vehiculo vehiculoParaVender) {
			bool seVendio=false;
			if(listaDeAutos is not null && listaDeAutosVendidos is not null && vehiculoParaVender is not null && ConsultarEspacio()) {
				if(ComprobarSiTenemosElVehiuclo(listaDeAutos, vehiculoParaVender)) {
					Console.WriteLine("Se vendio:");
					Console.WriteLine(MostrarDatosVehiculo(vehiculoParaVender));
					this.listaDeAutosVendidos.Add(vehiculoParaVender);
					listaDeAutos.Remove(vehiculoParaVender);
					seVendio=true;
				}
			}
			return seVendio;
		}
		public void MostrarCatalogo(List<Vehiculo> listaDeAutos) {
			if(listaDeAutos is not null && ConsultarEspacio()) {
				foreach(Vehiculo item in listaDeAutos) {
					MostrarDatosVehiculo(item);
				}
			}
		}
	}
}
