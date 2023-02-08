/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 4:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicios_5_12
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
	public class Numero: Comparable
	{
		public Numero()
		{
		}
		public Numero(int v)
		{
			this.valor=v;
		}
		int valor;
		
		public int Valor {
			get { return valor; }
			set { valor = value; }
		}
		
		public int getValor()			//Devuelve el valor almacenado en el objeto Numero
		{
			return this.valor;
		}
		public bool sosMayor(Comparable c)
		{
			return this.getValor() > ((Numero)c).getValor();	//Castea numero a comparable
		}
		
		public bool sosMenor(Comparable c)
		{
			return this.getValor() < ((Numero)c).getValor();
		}
		public bool sosIgual(Comparable c)
		{
			return this.getValor() == ((Numero)c).getValor();
			
		}
		
		
		public override string ToString()		//Fuerza a mostrar ese dato cada vez que se pida mostrar el objeto numero
   		{
        	return this.valor.ToString();
   		}
	}
}
