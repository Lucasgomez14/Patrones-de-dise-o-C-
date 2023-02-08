/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 4/6/2022
 * Time: 12:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of Observado.
	/// </summary>
	public interface Observado
	{
		void agregarObservador(Observador o);
		void eliminarObservador(Observador o);
		void notificar();
	}
}
