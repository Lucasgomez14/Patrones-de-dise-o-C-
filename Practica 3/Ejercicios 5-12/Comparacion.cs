/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 5:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicios_5_12
{
	/// <summary>
	/// Description of Comparacion.
	/// </summary>
	public interface Comparacion
	{
		bool sosIgual(Comparable c1, Comparable c2);
		bool sosMenor(Comparable c1, Comparable c2);
		bool sosMayor(Comparable c1, Comparable c2);
	}
}
