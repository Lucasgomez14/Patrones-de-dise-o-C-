/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 14/7/2022
 * Time: 19:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of ProxyAlumnoEstudioso.
	/// </summary>
	public class ProxyAlumnoEstudioso: ProxyAlumno
	{
		public ProxyAlumnoEstudioso(Numero legajo, Numero promedio, string nombre, Numero dni): base(legajo,promedio,nombre,dni)
		{}
		
		public override int responderPregunta(int pregunta)
		{
			if (alumnoReal == null)
			{
				alumnoReal = FabricaDeAlumnos.crearAlumno(legajo,promedio,nombre,dni,4);
				Console.WriteLine("Instancia de Alumno Muy Estudioso creada.");
			}
			
			return alumnoReal.responderPregunta(pregunta);
		}
	}
}
