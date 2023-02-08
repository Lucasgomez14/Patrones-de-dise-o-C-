﻿/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 5:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of CompararPorDni.
	/// </summary>
	public class CompararPorDni:Comparacion
	{
		public  bool sosIgual(Comparable c1, Comparable c2){ return ((Alumno)c1).getDni().Valor == ((Alumno)c2).getDni().Valor;}

		
		public  bool sosMenor(Comparable c1, Comparable c2){ return ((Alumno)c1).getDni().Valor > ((Alumno)c2).getDni().Valor; }
		
		
		public  bool sosMayor(Comparable c1, Comparable c2){ return ((Alumno)c1).getDni().Valor < ((Alumno)c2).getDni().Valor; }
	}
}
