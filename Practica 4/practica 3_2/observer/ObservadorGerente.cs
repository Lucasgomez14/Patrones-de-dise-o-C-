/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 15/6/2022
 * Time: 17:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_4
{
	/// <summary>
	/// Description of ObservadorGerente.
	/// </summary>
	public interface ObservadorGerente: Observador
	{
		void actualizar(Observado o);
	}
}
