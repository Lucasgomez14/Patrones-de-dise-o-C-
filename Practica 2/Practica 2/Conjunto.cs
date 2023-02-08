/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/11/2022
 * Time: 11:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Practica_2
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto: Coleccionable
	{
		public Conjunto()
		{
			listaElementos=new List<Comparable>();
		}
		List<Comparable> listaElementos;
		
		public List<Comparable> ListaElementos {
			get { return listaElementos; }
			set { listaElementos = value; }
		}
		
		public void Anadir(Comparable elemento)
		{
			listaElementos.Add(elemento);
		}
		
		public bool Pertenece (Comparable elemento)
		{
			if (listaElementos.Contains(elemento)){return true;}
//			foreach (Comparable elemento in listaElementos) 
//			{
//				if (elemento.Equals(e)) 				En caso de que no funcione el contains
//				{
//					return true;
//				}
//			}
			else{return false;}
		}
		
		public int cuantos()
		{
			return listaElementos.Count;
		}
		public Comparable maximo()
		{
			Comparable c = this.listaElementos[0];			// C toma el valor del elemento 0

        	for(int i=0; i < this.cuantos()-1; i++) 		// Recorre la lista de elementos
        	{
            	if (this.listaElementos[i].sosMayor(c)) 		// Si cada elemento[i] es mayor a c
            	{
                	c = this.listaElementos[i];				//c=al nuevo elemento de la posicion [i]
            	}
        	}

        	return c;
		}
		public Comparable minimo()
		{
			Comparable c = this.listaElementos[0];			// C toma el valor del elemento 0

        	for(int i=0; i < this.cuantos()-1; i++) 		// Recorre la lista de elementos
        	{
            	if (this.listaElementos[i].sosMenor(c)) 		// Si cada elemento[i] es mayor a c
            	{
                	c = this.listaElementos[i];				//c=al nuevo elemento de la posicion [i]
            	}
        	}

        	return c;
		}
		public void agregar(Comparable c)
		{
			this.Anadir(c);
		}
		public bool contiene(Comparable c)
		{
			return Pertenece(c);
		}
	}
}
