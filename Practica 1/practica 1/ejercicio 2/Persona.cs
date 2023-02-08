/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 1/5/2022
 * Time: 20:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejercicio_2
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
//		int dni;
		
		public string Nombre 
		{
			get { return nombre; }
			set { nombre = value; }
		}

//		public int Dni 
//		{
//			get { return dni; }
//			set { dni = value; }
//		}
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
//		public bool sosIgual(Comparable c) {return false;}
		
		public bool sosMenor(Comparable c){ return Dni.getValor() < ((Persona)c).Dni.getValor(); }
		
//		public bool sosMenor(Comparable c){ return false;}
		
		public bool sosMayor(Comparable c){ return Dni.getValor() > ((Persona)c).Dni.getValor(); }
		
//		public bool sosMayor(Comparable c){return false;}
		
	}
}
