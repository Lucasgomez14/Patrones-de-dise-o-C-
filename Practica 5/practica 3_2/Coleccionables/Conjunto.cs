/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 4:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace practica_5
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto: Coleccionable, Iterable
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
		
		public bool pertenece (Comparable elemento)
		{
			if(listaElementos.Count>0){
				
				for(int i = 0; i<listaElementos.Count;i++){
				
					if(listaElementos[i].sosIgual(elemento))
						
						return true;
				}
			}
			
			return false;
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
			if(!this.contiene(c)){
				listaElementos.Add(c);
			}
		}
		
		public bool contiene (Comparable elemento)
		{
			if(listaElementos.Count>0){
				
				for(int i = 0; i<listaElementos.Count;i++){
				
					if(listaElementos[i].sosIgual(elemento))
						
						return true;
				}
			}
			
			return false;
		}
		
		public IteradorColecciones crearIterador(){
        	return new IteradorConjunto(this.ListaElementos);
        }
		
		public List<Comparable> getConjunto(){
			
			return this.listaElementos;
		}
	}
}
