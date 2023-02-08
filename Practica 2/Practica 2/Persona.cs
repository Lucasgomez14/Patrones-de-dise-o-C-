/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/10/2022
 * Time: 8:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona: Comparable
	{
		public Persona()
		{
		}
		public Persona(string nombre, Numero dni)
		{
			this.nombre=nombre;
			this.dni=dni;
		}
		string nombre;
		
		public string Nombre 
		{
			get { return nombre; }
			set { nombre = value; }
		}

		Numero dni;
		
		public Numero Dni {
			get { return dni; }
			set { dni = value; }
		}
		
		public override string ToString()
		{
			return dni.ToString();
		}

		
		public bool sosIgual(Comparable c){ return Dni.getValor() == ((Persona)c).Dni.getValor(); }
		
		public bool sosMenor(Comparable c){ return Dni.getValor() < ((Persona)c).Dni.getValor(); }
		
		public bool sosMayor(Comparable c){ return Dni.getValor() > ((Persona)c).Dni.getValor(); }
		
		
	}
}
