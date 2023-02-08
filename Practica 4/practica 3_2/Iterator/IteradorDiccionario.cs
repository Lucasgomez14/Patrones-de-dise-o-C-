/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/25/2022
 * Time: 6:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_4
{
	public class IteradorDicionario : IteradorColecciones
	{
		private Diccionario elementos;
        private int indice;
        
        public IteradorDicionario(Diccionario d)
        {
            this.elementos = d;
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
            return indice >= elementos.cuantos();
        }
        public object actual()
        {
        	return ((ClaveValor)elementos.getDiccionario()[indice]).Valor;
		}
	}
}
