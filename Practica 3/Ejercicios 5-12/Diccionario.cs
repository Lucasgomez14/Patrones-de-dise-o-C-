/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 4:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Ejercicios_5_12
{
	/// <summary>
	/// Description of Diccionario.
	/// </summary>
	public class Diccionario: Coleccionable, Iterable
	{
		Conjunto conj;
		Comparable clave = new Numero(0);
		
		public Diccionario()
		{
			conj = new Conjunto();
		}
		
		public void agregar(Comparable valor){
			
			ClaveValor NuevaClave = new ClaveValor(clave,valor);
			bool existe = false;
			
			for (int i = 0; i < conj.getConjunto().Count; i++)
			{
				
				if(conj.getConjunto()[i].sosIgual(NuevaClave))
				{
				   	existe = true;
				   	((ClaveValor)conj.getConjunto()[i]).setValor(NuevaClave.Valor);
				   	break;
				   }
			}
			if(!existe){
				conj.agregar(NuevaClave);
				int x = ((Numero)clave).Valor+1;
				clave = new Numero(x);
			}
		}
		
		public object ValorDe(Comparable clave){
			
			for(int i = 0; i < conj.getConjunto().Count;i++){
				
				if(((ClaveValor)conj.getConjunto()[i]).sosIgual(clave)){
					
					return ((ClaveValor)conj.getConjunto()[i]);
				}
			}
			return null;
		}
		
		public int cuantos(){
			
			return conj.cuantos();
		}
		public Comparable minimo(){
			
			return conj.minimo();
		}
		
		public Comparable maximo(){
			
			return conj.maximo();
		}
		
		public bool contiene(Comparable elem){
			
			return conj.contiene(elem);
		}
		
		public List<Comparable> getDiccionario(){
			
			return this.conj.getConjunto();
		}
		
		public IteradorColecciones crearIterador(){
			
			return new IteradorDicionario(this);
		}
	}
}
