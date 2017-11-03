using System;

namespace EjercicioSC
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			clsEnemigo[] CrearEnemigo = new clsEnemigo[2];

			CrearEnemigo[0] = new clsEnemigo() 
			{
				Id = 0,
				Nombre = "Enemigo1",
				Vida = 100
			};

			CrearEnemigo[1] = new clsEnemigo() 
			{
				Id = 1,
				Nombre = "Enemigo2",
				Vida = 80
			};

			foreach (clsEnemigo ListaEnemigo in CrearEnemigo)
			{
				Console.WriteLine(ListaEnemigo.ImprimirEnemigo());
			}

			Console.ReadKey();
		}
	}
}
