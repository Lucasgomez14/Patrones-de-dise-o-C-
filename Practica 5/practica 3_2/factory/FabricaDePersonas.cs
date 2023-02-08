/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 7/6/2022
 * Time: 5:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of FabricaDePersonas.
	/// </summary>
	public class FabricaDePersonas: FabricaDeComparables
	{
		string [] nom = new string[]{"José","Lucas","Joaquin","Iñigo","Armando","Rogelio","Teodoro","Hernesto","Juan","Matias","Rodrigo","Ruben","Mateo","Andres","Ignacio","Karim","Luka","Daniel","David","Ferland","Vinicius","Eden","Carlos","Tony","Eder","Thibout","Marcelo","Mariano"};
		protected GeneradorDeDatosAleatorios random = new GeneradorDeDatosAleatorios();
		static Random ran = new Random();
		protected LectorDeDatos porTeclado = new LectorDeDatos();
		
		public override Comparable crearAleatorio()
		{
			return new Persona(random.stringAleatorio(10),new Numero(random.numeroAleatorio(10000)));
		}
		
		public override Comparable crearPorTeclado()
		{
			return new Persona(porTeclado.stringPorTeclado(),new Numero(porTeclado.numeroPorTeclado()));
		}
		
		public string NombreAleatorio(){
			
			return (nom[ran.Next(0,(nom.Length-1))]);
			                        	
		}
		
		public int DniAleatorio(){
			
			return random.numeroAleatorio(10000);
		}
		
		public int DniPorTeclado(){
			
			return porTeclado.numeroPorTeclado();
		}
		
		public string NombrePorTeclado(){
			
			return porTeclado.stringPorTeclado();
		}
		public override Comparable crearProxy()
		{
			return new Persona(NombreAleatorio(),new Numero(DniAleatorio()));
		}
	}
}
