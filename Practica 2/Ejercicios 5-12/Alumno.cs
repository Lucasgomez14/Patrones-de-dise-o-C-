/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 5:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicios_5_12
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
			comp = new CompararPorNombre();
			
		}
		Numero legajo;
		Numero promedio;
		Comparacion comp;
		
		public Comparacion Comp {
			get { return comp; }
			set { comp = value; }
		}
		
		
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
		
		 public void CambiarEstrategia(Comparacion e){
        	
        	this.comp = e;
        }
		
		public override string ToString()
		{
			return Legajo.ToString();
		}
		
		public new bool sosIgual(Comparable c2)
		{
			return this.comp.sosIgual(this,c2);
		}
		
		public new bool sosMenor(Comparable c2)
		{
			return this.comp.sosMenor(this,c2);
		}
		
		public new bool sosMayor(Comparable c2)
		{
			return comp.sosMayor(this,c2);
		}

	}
}
