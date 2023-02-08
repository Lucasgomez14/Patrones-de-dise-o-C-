/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 29/5/2022
 * Time: 23:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicios_5_12
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorios.
	/// </summary>
	public class GeneradorDeDatosAleatorios
	{
		public int numeroAleatorio(int numMax)
        {
            int numeroRandom;
            Random random = new Random();
            numeroRandom=random.Next(0,numMax);
            return numeroRandom;
        }

        public string stringAleatorio(int cantCaracteres)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var CadenaTexto = new char[cantCaracteres];
            var random = new Random();

            for (int i = 0; i < CadenaTexto.Length; i++)
            {
                CadenaTexto[i] = chars[random.Next(chars.Length)];
            }

            var Resultado = new String(CadenaTexto);
            return Resultado;
        }
	}
}
