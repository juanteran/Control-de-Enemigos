using System;
namespace EjercicioSC
{
	public class clsEnemigo
	{
		public static int NumeroEnemigo = 0;

		public int Id { get; set; }
		public string Nombre { get; set; }
		public int Vida { get; set; }

		//Falta crear posición

		public string ImprimirEnemigo() => $"{Id}, {Nombre}, {Vida}";

		public clsEnemigo()
		{
			//Contador de Enemigos Creados
			NumeroEnemigo += 1;
		}

	}
}
