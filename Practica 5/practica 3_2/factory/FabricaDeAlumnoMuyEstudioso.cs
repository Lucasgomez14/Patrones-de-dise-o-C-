/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 9/7/2022
 * Time: 10:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of FabricaDeAlumnoMuyEstudioso.
	/// </summary>
	public class FabricaDeAlumnoMuyEstudioso: FabricaDeAlumnos
	{
		public override Comparable crearAleatorio()
		{
			return new AlumnoMuyEstudioso(new Numero(base.CrearLegajoAleatorio()),new Numero(base.CrearPromedioAleatorio()),base.NombreAleatorio(),new Numero(base.DniAleatorio()));
		}
		
		public override Comparable crearPorTeclado()
		{
			return new AlumnoMuyEstudioso(new Numero(base.crearLegajoPorTeclado()),new Numero(base.crearPromedioPorTeclado()),base.NombrePorTeclado(),new Numero(base.DniPorTeclado()));
		}
		public override Comparable crearProxy()
		{
			return new ProxyAlumnoEstudioso(new Numero(CrearLegajoAleatorio()),new Numero(CrearPromedioAleatorio()),base.NombreAleatorio(),new Numero(base.DniAleatorio()));
		 }
	}
}
