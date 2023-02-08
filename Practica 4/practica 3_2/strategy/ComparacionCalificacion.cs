/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 13/7/2022
 * Time: 16:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_4
{
	/// <summary>
	/// Description of ComparacionCalificacion.
	/// </summary>
	public class ComparacionCalificacion: Comparacion
	{
		public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((AdAlumno)c1).getCalificacion() == ((AdAlumno)c2).getCalificacion();
        }
        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((AdAlumno)c1).getCalificacion() < ((AdAlumno)c2).getCalificacion();
        }
        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((AdAlumno)c1).getCalificacion() > ((AdAlumno)c2).getCalificacion();
        }
	}
}
