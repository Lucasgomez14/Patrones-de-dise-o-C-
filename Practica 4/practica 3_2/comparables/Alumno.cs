/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 5:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_4
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno: Persona, AdAlumno
	{
		public Alumno()
		{
		}
		public Alumno(Numero legajo, Numero promedio, string n, Numero d): base(n,d)
		{
			this.legajo=legajo;
			this.promedio=promedio;
			comp = new ComparacionCalificacion();
			
			
		}
		Numero legajo;
		Numero promedio;
		Comparacion comp;
		private int calificacion;
		
		public Comparacion Comp {
			get { return comp; }
			set { comp = value; }
		}
		
		
//		public Numero getLegajo 
//		{
//			get { return legajo; }
//			set { legajo = value; }
//		}
//			
//		public Numero getPromedio
//		{
//			get { return promedio; }
//			set { promedio = value; }
//		}
		
		 public void CambiarEstrategia(Comparacion e){
        	
        	this.comp = e;
        }
		
		public override string ToString()
		{
			return legajo.ToString();
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
		
		public string mostrarCalificacion()
		{
			return ("Nombre: " + getNombre() + "		Calificacion: "+calificacion);
		}
        public void setCalificacion(int cali)
        {
        	this.calificacion = cali;
        }
        public virtual int responderPregunta(int pregunta)
        {
        	Random r = new Random();
        	return r.Next(1,3);
        }  	
        public int getCalificacion()
        {
        	return calificacion;
        }
        public Numero getLegajo()
        {
            return legajo;
        }
        public Numero getPromedio()
        {
            return promedio;
        }
        
        public Numero getDni(){
        	
        	return getdni;
        }
		public string getNombre()
		{
			return getnombre;
		}

	}
}
