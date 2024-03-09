/*
 * Creado por SharpDevelop.
 * Usuario: Personal
 * Fecha: 29/10/2013
 * Hora: 08:15 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Tiropenal
{
	class Program
	{
		public static void Main(string[] args)
		{
			Arbitro arbitro = new Arbitro();
			Pateador pateador = new Pateador(0);
			Arquero arquero = new Arquero(0);
			Console.WriteLine("LANZAMIENTO DE UN PENAL");
			Console.WriteLine(arbitro.Pitar());
			pateador.Num=9;
			Console.Write("Indique la dirección en la que patea el jugador(1:Izquierda; 2:Derecha): ");
			pateador.Direccion=Convert.ToInt16(Console.ReadLine());
			arquero.Num=1;
			Console.Write("Indique la dirección en la que se lanza el portero(1:Izquierda; 2:Derecha): ");
			arquero.Direccion=Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("Jugador "+pateador.Num+" Patea hacia la "+pateador.Patear());
			Console.WriteLine("Arquero se lanza hacia la "+arquero.Lanzarse());
			if (pateador.Direccion == arquero.Direccion)
			{
				Console.WriteLine(arquero.Jugada());
			}
			else
			{
				Console.WriteLine(pateador.Jugada());
			}
			
			Console.ReadKey(true);
		}
	}
}