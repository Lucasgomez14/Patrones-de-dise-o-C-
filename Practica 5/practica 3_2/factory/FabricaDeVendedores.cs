/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 3/6/2022
 * Time: 20:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of FabricaDeVendedores.
	/// </summary>
	public  class FabricaDeVendedores: FabricaDePersonas
	{
		public override Comparable crearAleatorio()
        {
			return new Vendedor(new Numero(base.random.numeroAleatorio(1000000)),base.NombreAleatorio(),new Numero(base.DniAleatorio()));
        }
        public override Comparable crearPorTeclado()
        {
        	return new Vendedor(new Numero(base.porTeclado.numeroPorTeclado()),base.NombrePorTeclado(),new Numero(base.DniPorTeclado()));
        }
	}
}
