/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/10/2022
 * Time: 8:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of CompararPorNombre.
	/// </summary>
	public class CompararPorNombre: Comparacion
	{
		public bool sosIgual(Comparable c1, Comparable c2)
		{
			return ((Alumno)c1).Nombre.Length.Equals(((Alumno)c2).Nombre.Length);	
		}			
		
		public bool sosMenor(Comparable c1, Comparable c2)
		{
			int LetrasNombre1, LetrasNombre2;
			for (LetrasNombre1 = 0; LetrasNombre1 < ((Alumno)c1).Nombre.Length; LetrasNombre1++) {
				LetrasNombre1++;
			}
			for (LetrasNombre2 = 0; LetrasNombre2 < ((Alumno)c2).Nombre.Length; LetrasNombre2++) {
				LetrasNombre2++;
			}
			if (LetrasNombre1 < LetrasNombre2) {
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool sosMayor(Comparable c1, Comparable c2)
		{
			int LetrasNombre1, LetrasNombre2;
			for (LetrasNombre1 = 0; LetrasNombre1 < ((Alumno)c1).Nombre.Length; LetrasNombre1++) {LetrasNombre1++;}
			for (LetrasNombre2 = 0; LetrasNombre2 < ((Alumno)c2).Nombre.Length; LetrasNombre2++) {LetrasNombre2++;}
			
			if (LetrasNombre1 > LetrasNombre2) {
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
