/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 15/7/2022
 * Time: 16:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of Ordenable.
	/// </summary>
	public interface Ordenable
	{
		void setOrdenInicio(OrdenEnAula1 o);
		void setOrdenLlegaAlumno(OrdenEnAula2 o);
		void setOrdenAulaLlena(OrdenEnAula1 o);
	}
}
