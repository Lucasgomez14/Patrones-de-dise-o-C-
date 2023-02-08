/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 7/6/2022
 * Time: 7:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_4
{
	/// <summary>
	/// Description of AlumnoMuyEstudioso.
	/// </summary>
	public class AlumnoMuyEstudioso: Alumno
	{
		public AlumnoMuyEstudioso(Numero l, Numero p, string n, Numero d): base(l, p, n, d)
		{
		}
		
		public override int responderPregunta(int pregunta)
		{
			return pregunta%3;
		}
	}
}
