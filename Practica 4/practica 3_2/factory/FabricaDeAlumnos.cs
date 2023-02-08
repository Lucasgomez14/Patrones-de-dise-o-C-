/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 30/5/2022
 * Time: 16:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_4
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos: FabricaDePersonas
	{
		static Random ran = new Random();
		public override Comparable crearAleatorio()
		{
			return new Alumno(new Numero(base.random.numeroAleatorio(10000)),new Numero(base.random.numeroAleatorio(10)), base.NombreAleatorio(),new Numero(base.DniAleatorio()));
		}
		
		public override Comparable crearPorTeclado()
		{
			return new Alumno(new Numero(base.porTeclado.numeroPorTeclado()),new Numero(base.porTeclado.numeroPorTeclado()),base.NombrePorTeclado(),new Numero(base.DniPorTeclado()));
		}
		public int crearLegajoAleatorio(){
			
			return ran.Next(0,50000);
		}
		public int crearPromedioAleatorio(){
			
			return ran.Next(1,10);
		}
		public int crearPromedioPorTeclado(){
			
			return porTeclado.numeroPorTeclado();
		}
		public int crearLegajoPorTeclado(){
			
			return porTeclado.numeroPorTeclado();
		}
		
		
	}
}
