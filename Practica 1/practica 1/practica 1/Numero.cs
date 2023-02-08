/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 10/4/2022
 * Time: 19:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_1
{

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
		
		public int getValor()
		{
			return this.valor;
		}
		public bool sosMayor(Comparable c)		//Hay que castear a número
		{
			return this.getValor() > ((Numero)c).getValor();
		}
		
		public bool sosMenor(Comparable c)
		{
			return this.getValor() < ((Numero)c).getValor();
		}
		public bool sosIgual(Comparable c)
		{
			return this.getValor() == ((Numero)c).getValor();
		}
		
		public override string ToString()
   		{
        	return this.valor.ToString();
   		}
	}
}
