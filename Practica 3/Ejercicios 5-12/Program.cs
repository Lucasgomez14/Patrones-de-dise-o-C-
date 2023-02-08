/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/13/2022
 * Time: 4:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Ejercicios_5_12
{
	class Program
	{
		public static void Main(string[] args)
		{
			Cola col= new Cola();
			Pila pil= new Pila();
			Conjunto conj= new Conjunto();
			Diccionario dic= new Diccionario();
//			LlenarAlumnos(pil);
//			Console.Clear();	//poniendo el clear me cambia los randoms, sino me quedan iguales.
//			LlenarAlumnos(col);
//			Console.Clear();
//			LlenarAlumnos(conj);
//			Console.Clear();
//			LlenarAlumnos(dic);
//			Console.Write("Presione para iniciar");
//			Console.ReadKey(true);
//			ColeccionMultiple colMul= new ColeccionMultiple(pil,col);
//			Console.WriteLine("Informa pila");
//			informar(pil);
//			Console.WriteLine("Informa cola");
//			informar(col);
//			Console.WriteLine("Informa ColeccionMultiple");
//			informar(colMul);
//			Console.Clear();
//			
//			Console.WriteLine("Imprimir todos los elementos de cola");
//			ImprimirElemento(col);
//			Console.Write("Presione para continuar");
//			Console.ReadKey(true);
//			Console.Clear();
//			
//			Console.WriteLine("Imprimir todos los elementos de pila");
//			ImprimirElemento(pil);
//			Console.Write("Presione para continuar");
//			Console.ReadKey(true);
//			Console.Clear();
//			
//			Console.WriteLine("Imprimir todos los elementos de conjunto");
//			ImprimirElemento(conj);
//			Console.Write("Presione para continuar");
//			Console.ReadKey(true);
//			Console.Clear();
//			
//			Console.WriteLine("Imprimir todos los elementos de diccionario");
//			ImprimirElemento(dic);
			
//			Practica 3 probando cosas
			
//			
//			Numero nene= FabricaDeNumeros.crearNumero(2);
//			Console.WriteLine(nene);
//			nene= FabricaDeNumeros.CrearNumeroPorDefecto();
//			Console.WriteLine(nene);
//			nene= FabricaDeNumeros.crearNumero(1);
//			Console.WriteLine(nene);
			
//			Alumno tato= FabricaDeAlumnos.crearAlumno(1);
//			Console.WriteLine(tato);
//			Alumno teto= FabricaDeAlumnos.crearAlumno(2);
//			Console.WriteLine(teto);
//			Alumno tito= FabricaDeAlumnos.CrearAlumnoPorDefecto();
//			Console.WriteLine(tito);
			Console.Write("Ingrese la opcion 1 o 2 para crear alumnos : ");
			LlenarAlumnos(pil,int.Parse(Console.ReadLine()));
			Console.WriteLine("Informa pila");
			informar(pil,2);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void LlenarAlumnos(Coleccionable colec,int opcion)
		{	
			Comparable com=null;
			for (int i = 0; i < 2; i++)
			{
				if (opcion==1) 
				{
					com= FabricaDeAlumnos.crearAlumno(1);
				}
				
				if (opcion==2) 
				{
					com= FabricaDeAlumnos.crearAlumno(2);
				}
				if (com==null) 
				{
					com= FabricaDeAlumnos.CrearAlumnoPorDefecto();
				}
				colec.agregar(com);
			}
										
		}
		
		public static void informar(Coleccionable c, int opcion)
		{
			Console.WriteLine(c.cuantos()+ " cantidad");
			Console.WriteLine(c.minimo()+ " numero minimo");
			Console.WriteLine(c.maximo()+ " numero maximo");
			Console.WriteLine("Presione una tecla para continuar");
			Console.ReadKey(true);
			Console.WriteLine("Ingrese por teclado para verificar si existe");
			Comparable com= FabricaDeAlumnos.crearAlumno(2);					
				if(c.contiene(com))
				{
					Console.WriteLine("El elemento leído está en la colección");
				}
				else
				{
					Console.WriteLine("El elemento leído no está en la colección");
				}
				
					
		}
		
		public static void ImprimirElemento(Iterable Colec){
			
            IteradorColecciones iter = Colec.crearIterador();
            while(!iter.fin())
            {
                Console.WriteLine(iter.actual() + " ");
                iter.siguiente();
            }
		}
	

		
		public static void CambiarEstrategia(Iterable Coleccion, Comparacion estrategia){
			
			IteradorColecciones iter = Coleccion.crearIterador();
			while(!iter.fin()){
				
				object alu = iter.actual();
                ((Alumno)alu).CambiarEstrategia(estrategia);
                iter.siguiente();
			}
		}
		
		public static ArrayList CrearListaNombres(ArrayList ListaNombres)
		{
			ListaNombres.Add("José");
			ListaNombres.Add("Lucas");
			ListaNombres.Add("Joaquin");
			ListaNombres.Add("Iñigo");
			ListaNombres.Add("Armando");
			ListaNombres.Add("Rogelio");
			ListaNombres.Add("Teodoro");
			ListaNombres.Add("Hernesto");
			ListaNombres.Add("Juan");
			ListaNombres.Add("Matias");
			ListaNombres.Add("Rodrigo");
			ListaNombres.Add("Ruben");
			ListaNombres.Add("Mateo");
			ListaNombres.Add("Andres");
			ListaNombres.Add("Ignacio");
			ListaNombres.Add("Karim");
			ListaNombres.Add("Luka");
			ListaNombres.Add("Daniel");
			ListaNombres.Add("David");
			ListaNombres.Add("Ferland");
			ListaNombres.Add("Vinicius");
			ListaNombres.Add("Eden");
			ListaNombres.Add("Carlos");
			ListaNombres.Add("Tony");
			ListaNombres.Add("Eder");
			ListaNombres.Add("Thibout");
			ListaNombres.Add("Carlos");
			ListaNombres.Add("Marcelo");
			ListaNombres.Add("Mariano");
			ListaNombres.Add("Kyllian");
			return ListaNombres;
		}
	
	}
}