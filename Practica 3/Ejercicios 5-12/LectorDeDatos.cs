/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 29/5/2022
 * Time: 23:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicios_5_12
{
	/// <summary>
	/// Description of LectorDeDatos.
	/// </summary>
	public  class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            int numero;
            Console.Write("Ingrese el número: ");
            numero=int.Parse(Console.ReadLine());
            return numero;
        }

        public string stringPorTeclado()
        {
            Console.WriteLine("Ingrese la palabra/nombre: ");
            return Console.ReadLine();
        }
    }
}
