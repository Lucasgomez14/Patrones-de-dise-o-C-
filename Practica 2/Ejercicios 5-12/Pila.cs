/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 4:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Ejercicios_5_12
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	public class Pila: Coleccionable, Iterable
	{
		private List<Comparable>Elementos;
		public Pila()
		{
			this.Elementos=new List<Comparable>();
		}
		
		public void apilar(Comparable c)
		{
			Elementos.Add(c);
		}
		
		public Comparable desapilar(Comparable c)
		{
			c = this.Elementos[this.Elementos.Count -1];
			this.Elementos.RemoveAt(this.Elementos.Count -1);
			return c;
		}
		
		public int cuantos()
		{
			
			return Elementos.Count;
		}
		
		public Comparable minimo()
        {
            Comparable minimo = Elementos[0];
            for (int i = 0; i < Elementos.Count; i++)
                if (minimo.sosMenor(Elementos[i]))
                    minimo = Elementos[i];
            return minimo;
        }
		
		public Comparable maximo()
        {
            Comparable maximo = Elementos[0];
            for (int i = 0; i < Elementos.Count; i++)
                if (maximo.sosMayor(Elementos[i]))
                    maximo = Elementos[i];
            return maximo;
        }
		
		public void agregar(Comparable C)
		{
			Elementos.Add(C);
		}
		
		public bool contiene(Comparable C)
		{
			for (int i = 0; i < Elementos.Count; i++)
			{
				if(C.sosIgual(Elementos[i]))
				{
					return true;
				}
			}
			return false;
		}
		
		public IteradorColecciones crearIterador()
		{
			return new IteradorColayPila (this.Elementos);
		}
	}
}
