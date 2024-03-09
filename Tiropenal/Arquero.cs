/*
 * Creado por SharpDevelop.
 * Usuario: Personal
 * Fecha: 29/10/2013
 * Hora: 08:17 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Tiropenal
{
	/// <summary>
	/// Description of Arquero.
	/// </summary>
	public class Arquero:Jugador
	{
		public Arquero(int dir):base(dir)
		{
		}
		
		public string Lanzarse()
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
			return "¡El penal fue atajado!";
		}
	}
}
