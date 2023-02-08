/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 10/4/2022
 * Time: 18:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

//EJERCICIOS DEL 10 AL 19
namespace ejercicio_2
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
			LlenarPersonas(pil);
			Console.Clear();	//desconozco el motivo, pero poniendo el clear me cambia los randoms, sino me quedan iguales.
			LlenarPersonas(col);
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
		
		public static void LlenarPersonas(Coleccionable colec)
		{	
			ArrayList ListaNombres= new ArrayList();
			ListaNombres= CrearListaNombres(ListaNombres);
			string nombre;
			int index,number;
			Random random= new Random();
			for (int i = 0; i < 15; i++) 
			{
				index = random.Next(0,ListaNombres.Count-1);
				nombre=ListaNombres[index].ToString();
				number=random.Next(1,99999999);
				Numero dni= new Numero(number);
				colec.agregar(new Persona(nombre,dni));
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
