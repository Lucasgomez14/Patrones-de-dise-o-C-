﻿/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 29/5/2022
 * Time: 23:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_3_2
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public interface FabricaDeComparables
	{
		 Comparable crearAleatorio();
         Comparable crearPorTeclado();
	}
}
