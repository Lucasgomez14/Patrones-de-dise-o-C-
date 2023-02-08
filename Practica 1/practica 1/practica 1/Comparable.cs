/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 10/4/2022
 * Time: 19:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_1
{
	public interface Comparable		//La interfaz no lleva código. Solo métodos
	{
		bool sosIgual(Comparable c);
		bool sosMenor(Comparable c);
		bool sosMayor(Comparable c);
		
	}
}
