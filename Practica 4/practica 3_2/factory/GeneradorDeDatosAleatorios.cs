/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 29/5/2022
 * Time: 23:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_4
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorios.
	/// </summary>
	public class GeneradorDeDatosAleatorios
	{
		private Random random;
		public GeneradorDeDatosAleatorios()
		{
			random = new Random();
		}
		public int numeroAleatorio(int numMax)
        {
            return random.Next(0,numMax);
        }

        public string stringAleatorio(int cantCaracteres)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var CadenaTexto = new char[cantCaracteres];

            for (int i = 0; i < CadenaTexto.Length; i++)
            {
                CadenaTexto[i] = chars[random.Next(chars.Length)];
            }

            var Resultado = new String(CadenaTexto);
            return Resultado;
        }
        public Random getRandom()
        {
			return random;
		}
	}
}
