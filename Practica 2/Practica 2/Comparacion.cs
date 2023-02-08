/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/10/2022
 * Time: 8:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_2
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
