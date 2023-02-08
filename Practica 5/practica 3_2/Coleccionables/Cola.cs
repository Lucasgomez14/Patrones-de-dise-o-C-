/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 5:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace practica_5
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
		public class Cola: Coleccionable, Iterable
	{
		public Cola()
		{
			this.elementos=new List<Comparable>();
		}
		private List<Comparable> elementos;	
		
		public Comparable desapilar()
		{
			Comparable c = this.elementos[0];
            this.elementos.RemoveAt(0);
            return c;
		}
		
		public int cuantos()
		{
			
			return elementos.Count;
		}
		
		public Comparable minimo()
        {
            Comparable minimo = elementos[0];
            for (int i = 0; i < elementos.Count; i++)
                if (minimo.sosMenor(elementos[i]))
                    minimo = elementos[i];
            return minimo;
        }
		
		public Comparable maximo()
        {
            Comparable maximo = elementos[0];
            for (int i = 0; i < elementos.Count; i++)
                if (maximo.sosMayor(elementos[i]))
                    maximo = elementos[i];
            return maximo;
        }
		public void agregar(Comparable c){
			elementos.Add(c);
		}
	
		public bool contiene(Comparable c)
		{
			for (int i = 0; i < elementos.Count; i++)
			{
				if(c.sosIgual(elementos[i]))
				{
					return true;
				}
			}
			return false;
		}
		
		public IteradorColecciones crearIterador(){
			
			return new IteradorColayPila(this.elementos);
		}

	}
}
