/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 4/28/2022
 * Time: 6:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace practica_1
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola: Coleccionable
	{
		public Cola()
		{
			this.elementos=new List<Comparable>();
		}
		private List<Comparable> elementos;
		private List<Comparable> lista_aux;
		public void apilar(Comparable C)
		{
			elementos.Add(C);
		}
		
		public Comparable desapilar(Comparable C)
		{
			lista_aux=new List<Comparable>();
			for (int i = 0; i < elementos.Count; i++) {
				if (i==0)
				{
					C=elementos[i];
					elementos.Remove(elementos[i]);
					return C;
				}
			}
			return C;
		}
		public int cuantos()
		{
			return this.elementos.Count;
		}
				
		public Comparable minimo()
		{
			Comparable c = this.elementos[0];			// C toma el valor del elemento 0

        	for(int i=1; i < this.cuantos(); i++) 		// Recorre la lista de elementos
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

        	for(int i=1; i < this.cuantos(); i++) 		// Recorre la lista de elementos
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
			for(int i=1; i < this.cuantos(); i++) 		// Recorre la lista de elementos
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
