/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 5:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_4
{
	/// <summary>
	/// Description of CompararPorLegajo.
	/// </summary>
	public class CompararPorLegajo: Comparacion
	{
		public bool sosIgual(Comparable c1, Comparable c2){ return ((Alumno)c1).getLegajo().Valor == ((Alumno)c2).getLegajo().Valor;}

		
		public bool sosMenor(Comparable c1, Comparable c2){ return ((Alumno)c1).getLegajo().Valor > ((Alumno)c2).getLegajo().Valor; }
		
		
		public bool sosMayor(Comparable c1, Comparable c2){ return ((Alumno)c1).getLegajo().Valor < ((Alumno)c2).getLegajo().Valor; }
	}
}
