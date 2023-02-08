/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/25/2022
 * Time: 6:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Ejercicios_5_12
{
	/// <summary>
	/// Description of IteradorConjunto.
	/// </summary>
	public class IteradorConjunto: IteradorColecciones
	{
		private List<Comparable> elementos;
        private int indice;
        public IteradorConjunto(List<Comparable> e)
        {
            this.elementos = e;
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
            return indice >= elementos.Count;
        }
        public object actual()
        {
            return elementos[indice];
        }
	}
}
