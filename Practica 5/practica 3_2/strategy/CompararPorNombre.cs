/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 5:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of CompararPorNombre.
	/// </summary>
	public class CompararPorNombre: Comparacion
	{
		public bool sosIgual(Comparable c1, Comparable c2)
		{
			return ((Alumno)c1).getNombre().Length.Equals(((Alumno)c2).getNombre().Length);
		}			
		
		public bool sosMenor(Comparable c1, Comparable c2)
		{
			int LetrasNombre1, LetrasNombre2;
			for (LetrasNombre1 = 0; LetrasNombre1 < ((Alumno)c1).getNombre().Length; LetrasNombre1++) {
				LetrasNombre1++;
			}
			for (LetrasNombre2 = 0; LetrasNombre2 < ((Alumno)c2).getNombre().Length; LetrasNombre2++) {
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
			for (LetrasNombre1 = 0; LetrasNombre1 < ((Alumno)c1).getNombre().Length; LetrasNombre1++) {LetrasNombre1++;}
			for (LetrasNombre2 = 0; LetrasNombre2 < ((Alumno)c2).getNombre().Length; LetrasNombre2++) {LetrasNombre2++;}
			
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
