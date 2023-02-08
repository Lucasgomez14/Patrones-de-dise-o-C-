/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 4:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_3_2
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona: Comparable
	{
		string nombre;
		Numero dni;
		
		public Persona(){}
		public Persona(string nombre, Numero dni)
		{
			this.nombre=nombre;
			this.dni=dni;
		}
		
		
		public string getNombre 
		{
			get { return nombre; }
			set { nombre = value; }
		}

		
		
		public Numero getDni {
			get { return dni; }
			set { dni = value; }
		}
		
		public override string ToString()
		{
			return dni.ToString();
		}

		
		public bool sosIgual(Comparable c){ return getDni.getValor() == ((Persona)c).getDni.getValor(); }
		
		public bool sosMenor(Comparable c){ return getDni.getValor() < ((Persona)c).getDni.getValor(); }
		
		public bool sosMayor(Comparable c){ return getDni.getValor() > ((Persona)c).getDni.getValor(); }
		
		
	}
}
