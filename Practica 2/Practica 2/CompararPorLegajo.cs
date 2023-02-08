/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/11/2022
 * Time: 11:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of CompararPorLegajo.
	/// </summary>
	public class CompararPorLegajo: Comparacion
	{
		public bool sosIgual(Comparable c1, Comparable c2){ return ((Alumno)c1).Legajo.Valor == ((Alumno)c2).Legajo.Valor;}

		
		public bool sosMenor(Comparable c1, Comparable c2){ return ((Alumno)c1).Legajo.Valor < ((Alumno)c2).Legajo.Valor; }
		
		
		public bool sosMayor(Comparable c1, Comparable c2){ return ((Alumno)c1).Legajo.Valor > ((Alumno)c2).Legajo.Valor; }
	}
}
