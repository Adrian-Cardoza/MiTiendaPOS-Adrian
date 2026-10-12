using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiTiendaPOS.Config
{
	public static class ConfiguracionApp
	{
		private const string archivo = "appsettings.json";
		public static string ObtenerCadenaConexion(
				string nombre = "MiTiendaPOSContext")
		{
				string rutaExe = Path.Combine(AppContext.BaseDirectory, archivo);
				string rutaBase = File.Exists(rutaExe) ? AppContext.BaseDirectory : Directory.GetCurrentDirectory();

				IConfigurationRoot configuration = new ConfigurationBuilder()
					.SetBasePath(rutaBase)
					.AddJsonFile(archivo, optional: false, reloadOnChange: false)
					.Build();
				return configuration.GetConnectionString(nombre)
				?? throw new InvalidOperationException($"No se encontró la cadena de conexión '{nombre}' en el archivo '{archivo}'.");
		}
	}
}
