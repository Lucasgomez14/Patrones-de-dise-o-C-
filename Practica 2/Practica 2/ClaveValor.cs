/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/12/2022
 * Time: 7:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of ClaveValor.
	/// </summary>
	public class ClaveValor
	{
		public ClaveValor(){}
		
		public ClaveValor(Comparable clave, Object valor)
		{
			this.clave=clave;
			this.valor=valor;
		}
		
		Comparable clave;
		
		public Comparable Clave {
			get { return clave; }
			set { clave = value; }
		}
		Object valor;
		
		public Object Valor {
			get { return valor; }
			set { valor = value; }
		}
		
		public override string ToString()
		{
			return valor.ToString();
		}
	}
}
