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
	/// Description of Jugador.
	/// </summary>
	public class Jugador
	{
		private int direccion;
		private int numero;
		//Método Jugador, contructor de la clase, poliformico
		public Jugador(int dir,int num)
		{
		}
		
		public Jugador(int dir)
		{
		}
		
		// Esta la manera de encapsular(set) y desencapsular(get) un atributo
		public int Num
        {
            set
            {
                this.numero = value;
            }
            get
            {
                return numero;
            }
        }
        
		public int Direccion
        {
            set
            {
                this.direccion = value;
            }
            get
            {
                return this.direccion;
            }
        }

        public string Jugada()
		{
			return "";
		}		
	}
}
