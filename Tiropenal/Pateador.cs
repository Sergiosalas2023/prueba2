/*
 * Creado por SharpDevelop.
 * Usuario: Personal
 * Fecha: 29/10/2013
 * Hora: 08:16 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Tiropenal
{
	/// <summary>
	/// Description of Pateador.
	/// </summary>
	public class Pateador:Jugador
	{
		public Pateador(int dir):base(dir)
		{
		}
		public string Patear()
		{
			string mensaje="";
			
			if (Direccion==1)
			{
				mensaje="Izquierda";
			}
			else
			{
				if (Direccion==2)
			    {
				   mensaje="Derecha";
			    }
			}
			return mensaje;
		}
		
		public string Jugada()
		{
			return "¡GOOOL.....!";
		}
	}
}
