/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/5/2022
 * Time: 8:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace ejercicio_14_20
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Comparable per1,per2;
			Numero num=new Numero(334432);
			Numero num2=new Numero(33434);
			per1 =new Persona("armando", num);
//			per2 =new Persona("hilario",num2);
			per2= new Persona("jose",num);
//			Console.WriteLine(per1.sosIgual(per2)); Funca
//			Console.WriteLine(per1.sosMenor(per2)); Funca
			Cola col= new Cola();
			Pila pil= new Pila();
			LlenarAlumnos(pil);
			Console.Clear();	//poniendo el clear me cambia los randoms, sino me quedan iguales.
			LlenarAlumnos(col);
			ColeccionMultiple colMul= new ColeccionMultiple(pil,col);
			Console.WriteLine("Informa pila");
			informar(pil);
			Console.WriteLine("Informa cola");
			informar(col);
			Console.WriteLine("Informa ColeccionMultiple");
			informar(colMul);
			
			

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void LlenarAlumnos(Coleccionable colec)
		{	
			ArrayList ListaNombres= new ArrayList();
			ListaNombres= CrearListaNombres(ListaNombres);
			string nombre;
			int index,numDni,numLegajo,numProm;
			Random random= new Random();
			for (int i = 0; i < 20; i++) 
			{
				index = random.Next(0,ListaNombres.Count-1);		//Forma de elegir un nombre random de la arraylist
				nombre=ListaNombres[index].ToString();
				
				
				numDni=random.Next(1,99999999);
				numLegajo=random.Next(1,99999);
				numProm=random.Next(1,10);
				Numero dni= new Numero(numDni);
				Numero legajo= new Numero(numLegajo);
				Numero promedio=new Numero(numProm);
				colec.agregar(new Alumno(legajo,promedio,nombre,dni));
			}							
		}
		
		public static void informar(Coleccionable c)
		{
			Console.WriteLine(c.cuantos()+ " cantidad");
			Console.WriteLine(c.minimo()+ " numero minimo");
			Console.WriteLine(c.maximo()+ " numero maximo");
			Console.WriteLine("Presione una tecla para continuar");
			string valor = Console.ReadLine();		// Para continuar
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
			return ListaNombres;
		}
	
	}
}