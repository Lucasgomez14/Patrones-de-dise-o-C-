/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/5/2022
 * Time: 8:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejercicio_14_20
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno: Persona, Comparable
	{
		public Alumno()
		{
		}
		public Alumno(Numero legajo, Numero promedio, string n, Numero d): base(n,d)
		{
			this.legajo=legajo;
			this.promedio=promedio;
			
		}
		Numero legajo;
		Numero promedio;
		
		public Numero Legajo 
		{
			get { return legajo; }
			set { legajo = value; }
		}
			
		public Numero Promedio
		{
			get { return promedio; }
			set { promedio = value; }
		}
		
		public override string ToString()
		{
			return Legajo.ToString();
		}
		
		public new bool sosIgual(Comparable c){ return Legajo.getValor() == ((Alumno)c).Legajo.getValor(); }

		
		public new bool sosMenor(Comparable c){ return Legajo.getValor() < ((Alumno)c).Legajo.getValor(); }
		
		
		public new bool sosMayor(Comparable c){ return Legajo.getValor() > ((Alumno)c).Legajo.getValor(); }
	}
}
