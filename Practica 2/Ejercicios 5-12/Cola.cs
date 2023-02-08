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

namespace Ejercicios_5_12
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
