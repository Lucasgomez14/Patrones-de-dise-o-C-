/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 3/6/2022
 * Time: 22:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections;

namespace practica_3_2
{
	/// <summary>
	/// Description of Gerente.
	/// </summary>
	public class Gerente: Observador
	{
		Coleccionable mejores= new Cola();
//		List<Observador> observaA= new List<Observador>();
		
		public void cerrar()
		{
			Comparable unVendedor= null;
			
			Console.WriteLine("Lista de los mejores vendedores del día: ");
			IteradorColecciones iter = ((Iterable)mejores).crearIterador();
            while(!iter.fin())
            {
                Vendedor v = (Vendedor)iter.actual();
                Console.WriteLine(v.getNombre + " " + v.GetBonus + " ");
                iter.siguiente();
            }
			
		}
		
		public Coleccionable getMejores {
			get { return mejores; }
			set { mejores = value; }
		}
		
		public void venta(Numero monto, Vendedor v)
		{
			if (monto.getValor() > 5000)
			{
				if (!mejores.contiene(v))
			    {
					mejores.agregar(v);
				}
				v.aumentoBonus();
			}
		}
		
		
//		public void agregarObservador(Observador o)
//		{
//			observaA.Add(o);
//		}
//		
//		public void eliminarObservador(Observador o)
//		{
//			observaA.Remove(o);
//		}
		
		public void actualizar(Observado o)
		{
			Numero monto = ((Vendedor)o).GetMonto;
            this.venta(monto,(Vendedor)o);
		}
		
		public void notificar()
		{
		
		}
		
		
		
//		jornadaDeVentas(coleccionable_vendedores)
//repetir 20 veces
//para cada „vendedor‟ de coleccionable_vendedores
//monto = numero_al_azar_entre(1, 7000)
//vendedor.venta(monto
	}
}
