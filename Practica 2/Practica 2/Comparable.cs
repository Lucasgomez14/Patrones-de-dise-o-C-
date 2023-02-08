/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/10/2022
 * Time: 8:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_2
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
