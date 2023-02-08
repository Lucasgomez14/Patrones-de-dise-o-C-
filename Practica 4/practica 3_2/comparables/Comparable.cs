/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 5:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_4
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
