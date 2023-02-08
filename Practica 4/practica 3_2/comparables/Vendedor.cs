/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 3/6/2022
 * Time: 19:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace practica_4
{
	/// <summary>
	/// Description of Vendedor.
	/// </summary>
	public class Vendedor: Persona, Observado
	{
		Numero sueldoBasico;
		double bonus;
		Numero mont;
		List<Observador> observadoPor= new List<Observador>();
		
		public Vendedor(){}
		public Vendedor(Numero sueldoBasico, string n, Numero dni): base (n,dni)
		{
			this.sueldoBasico=sueldoBasico;
			double bonus=1;
		}
		
		public Numero GetSueldoBasico {
			get { return sueldoBasico; }
			set { sueldoBasico = value; }
		}
		
		public double GetBonus {
			get { return bonus; }
			set { bonus = value; }
		}
		
		public Numero GetMonto {
			get {return mont;}
			set {mont= value;}
		}
		
		public void Venta(Numero monto)
		{
			Console.WriteLine("Monto final: $ "+monto);
			mont=monto;
			this.notificar();
		}
		
		public void aumentoBonus()
		{
			this.bonus+=0.1;
		}
		
		public void agregarObservador(Observador o)
		{
			observadoPor.Add(o);
		}
		
		public void eliminarObservador(Observador o)
		{
			observadoPor.Remove(o);
		}

		public void notificar()
		{
			foreach (Observador o in observadoPor)
            {
                o.actualizar(this);
            }
		}
		
	}
}
