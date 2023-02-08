/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 29/5/2022
 * Time: 23:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_3_2
{
	/// <summary>
	/// Description of LectorDeDatos.
	/// </summary>
	public  class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            Console.Write("Ingrese el número: ");
            return int.Parse(Console.ReadLine());
        }

        public string stringPorTeclado()
        {
            Console.WriteLine("Ingrese la palabra/nombre: ");
            return Console.ReadLine();
        }
    }
}
