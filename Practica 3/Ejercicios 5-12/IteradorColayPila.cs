/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 19/5/2022
 * Time: 18:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Ejercicios_5_12
{
	/// <summary>
	/// Description of IteradorColayPila.
	/// </summary>
	public class IteradorColayPila: IteradorColecciones
	{
		private List<Comparable> elementos = new List<Comparable>();
		private int indice;
		
		public IteradorColayPila(List<Comparable> e)
		{
			this.elementos = e;
			indice = 0;
		}
		
		public void primero()
        {
            indice = 0;
        }
        public void siguiente()
        {
            indice++;
        }
        public bool fin()
        {
            return indice == elementos.Count;
        }
        public object actual()
        {
            return elementos[indice];
        }
	}
}
