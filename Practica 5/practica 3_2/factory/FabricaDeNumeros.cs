/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 29/5/2022
 * Time: 23:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of FabricaDeNumeros.
	/// </summary>
	public class FabricaDeNumeros: FabricaDeComparables
    {
		public override Comparable crearAleatorio()
		{
			GeneradorDeDatosAleatorios r = new GeneradorDeDatosAleatorios();
			return new Numero(r.numeroAleatorio(r.getRandom().Next()));
		}
		
		public override Comparable crearPorTeclado()
		{
			LectorDeDatos x = new LectorDeDatos();
			return new Numero(x.numeroPorTeclado());
		}
		
		public override Comparable crearProxy()
		{
			GeneradorDeDatosAleatorios r = new GeneradorDeDatosAleatorios();
			return new Numero(r.numeroAleatorio(r.getRandom().Next()));
		}
	}
 }

