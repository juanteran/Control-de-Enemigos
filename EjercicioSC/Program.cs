using System;

namespace EjercicioSC
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			clsEnemigo CrearEnemigo = new clsEnemigo(15, "PrimerEnemigo", 100);

			Console.WriteLine(CrearEnemigo.ImprimirEnemigo());
			Console.ReadKey();
		}
	}
}
