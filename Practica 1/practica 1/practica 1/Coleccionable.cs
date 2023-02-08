/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 4/15/2022
 * Time: 2:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_1
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
