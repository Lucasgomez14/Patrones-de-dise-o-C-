/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 4/15/2022
 * Time: 3:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace practica_1
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	public class Pila: Coleccionable
	{
		private List<Comparable>elementos;
		public Pila()
		{
			this.elementos=new List<Comparable>();
		}
		
		public void apilar(Comparable c)
		{
			elementos.Add(c);
		}
		
		public Comparable desapilar(Comparable c)
		{
			c = this.elementos[this.elementos.Count -1];
			this.elementos.RemoveAt(this.elementos.Count -1);
			return c;
		}
		
		public int cuantos()
		{
			return this.elementos.Count;
		}
				
		public Comparable minimo()
		{
			Comparable c = this.elementos[0];			// C toma el valor del elemento 0

        	for(int i=0; i < this.cuantos()-1; i++) 		// Recorre la lista de elementos
        	{
            	if (this.elementos[i].sosMenor(c)) 		// Si cada elemento[i] es menor a c
            	{
                	c = this.elementos[i];				//c=al nuevo elemento de la posicion [i]
            	}
        	}

        	return c;
		}
		
		public Comparable maximo()
		{
			Comparable c = this.elementos[0];			// C toma el valor del elemento 0

        	for(int i=0; i < this.cuantos()-1; i++) 		// Recorre la lista de elementos
        	{
            	if (this.elementos[i].sosMayor(c)) 		// Si cada elemento[i] es mayor a c
            	{
                	c = this.elementos[i];				//c=al nuevo elemento de la posicion [i]
            	}
        	}

        	return c;
		}
		
		public void agregar(Comparable C)
		{
			this.apilar(C);
		}
		public bool contiene(Comparable C)
		{
        	for(int i=0; i < this.cuantos()-1; i++) 		// Recorre la lista de elementos
        	{
            	if (this.elementos[i].sosIgual(C)) 		// si el elementos es igual a C
            	{						
            		return true;
            	}
        	}

        	return false;
		}
	}
}

// PARA UNA PILa se crea, se crea funcion de apilar, otra de desapilar 