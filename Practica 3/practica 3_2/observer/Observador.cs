/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 4/6/2022
 * Time: 12:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_3_2
{
	/// <summary>
	/// Description of observador.
	/// </summary>
	public interface Observador
	{
		void actualizar(Observado o);
	}
}
