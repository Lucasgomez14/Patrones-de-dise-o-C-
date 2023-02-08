/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 5:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of ClaveValor.
	/// </summary>
	public class ClaveValor: Comparable
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
		
		public void setValor(Object valor)
        {
            this.valor = valor;
        }
		
		public Object Valor {
			get { return valor; }
			set { valor = value; }
		}
		
		public override string ToString()
		{
			return valor.ToString();
		}
		
		public bool sosIgual(Comparable c)
        {
            return this.clave.sosIgual(((ClaveValor)c).Clave);
        }
        public bool sosMayor(Comparable c)
        {
            return this.clave.sosMayor(((ClaveValor)c).Clave);
        }
        public bool sosMenor(Comparable c)
        {
            return this.clave.sosMenor(((ClaveValor)c).Clave);
        }
	}
}
