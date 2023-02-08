/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 19/5/2022
 * Time: 18:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicios_5_12
{
	/// <summary>
	/// Description of IteradorColaYPila.
	/// </summary>
	public interface IteradorColecciones
	{
		void primero();
        void siguiente();
        bool fin();
        object actual();
	}
}
