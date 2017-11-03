using System;
namespace EjercicioSC
{
	public class clsEnemigo
	{
		public static int ListaEnemigo = 0;

		public int Id { get; set; }
		public string Nombre { get; set; }
		public int Vida { get; set; }

		//Falta crear posición

		public clsEnemigo(int id, string nombre, int vida)
		{
			Id = id;
			Nombre = nombre;
			Vida = vida;

			//Contador de Enemigos Creados
			ListaEnemigo += 1;
		}


	}
}
