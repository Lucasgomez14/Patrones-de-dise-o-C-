/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/5/2022
 * Time: 8:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejercicio_14_20
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
