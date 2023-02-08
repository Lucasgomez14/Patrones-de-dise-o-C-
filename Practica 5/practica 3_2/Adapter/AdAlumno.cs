/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 7/6/2022
 * Time: 8:07 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of AdAlumno.
	/// </summary>
	public interface AdAlumno: Comparable
	{
		string mostrarCalificacion();
        void setCalificacion(int valor);
        int responderPregunta(int pregunta);
        string getNombre();
        int getCalificacion();
        Numero getLegajo();
        Numero getPromedio();
        Numero getDni();
	}
}
