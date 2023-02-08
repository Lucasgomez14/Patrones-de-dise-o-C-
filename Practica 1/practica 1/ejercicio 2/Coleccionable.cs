/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 1/5/2022
 * Time: 20:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejercicio_2
{
	/// <summary>
	/// Description of Coleccionable.
	/// </summary>
	public interface Coleccionable
	{
		int cuantos();
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable c);
		bool contiene(Comparable c);
	}
}
