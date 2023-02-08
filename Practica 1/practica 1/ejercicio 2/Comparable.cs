/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 1/5/2022
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejercicio_2
{
	/// <summary>
	/// Description of Comparable.
	/// </summary>
	public interface Comparable
	{
		bool sosIgual(Comparable c);
		bool sosMenor(Comparable c);
		bool sosMayor(Comparable c);
	}
}
