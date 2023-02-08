/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 5:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicios_5_12
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	public class ColeccionMultiple: Coleccionable
	{
		public ColeccionMultiple()
		{
		}
		public ColeccionMultiple(Pila p, Cola c)
		{
			pila=p;
			cola=c;
		}
		Cola cola;
		Pila pila;
		
		public Cola Cola {
			get { return cola; }
			set { cola = value; }
		}
		
		public Pila Pila {
			get { return pila; }
			set { pila = value; }
		}
		
		public int cuantos(){ return this.cola.cuantos()+this.pila.cuantos(); }
		
		public Comparable minimo()
		{
			Comparable comp= cola.minimo();
			Comparable comp2= pila.minimo();
			if (comp.sosMenor(comp2)) {return comp;}
			
			else{return comp2;}
			
		}
		public Comparable maximo()
		{ 
			Comparable comp= cola.maximo();
			Comparable comp2= pila.maximo();
			if (comp.sosMayor(comp2)) {return comp;}
			else{return comp2;}
		}
		public void agregar(Comparable c){} 	//NO HACE NADA
		
		public bool contiene(Comparable c)
		{ 
			if(this.pila.contiene(c)) { return true; }
			if(this.cola.contiene(c)) { return true; }
			else{return false;}
		}

	}
}
