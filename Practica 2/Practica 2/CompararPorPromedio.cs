/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/11/2022
 * Time: 11:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of CompararPorPromedio.
	/// </summary>
	public class CompararPorPromedio: Comparacion
	{
		public bool sosIgual(Comparable c1, Comparable c2){ return ((Alumno)c1).Promedio.Valor == ((Alumno)c2).Promedio.Valor;}

		
		public bool sosMenor(Comparable c1, Comparable c2){ return ((Alumno)c1).Promedio.Valor < ((Alumno)c2).Promedio.Valor; }
		
		
		public bool sosMayor(Comparable c1, Comparable c2){ return ((Alumno)c1).Promedio.Valor > ((Alumno)c2).Promedio.Valor; }
	}
}
