/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 10/4/2022
 * Time: 18:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


//EJERCICIOS DEL 1 AL 10
namespace practica_1
{
	
	
	
	class Program
	{
		public static void llenar(Coleccionable c)
		{
			Random random= new Random();
			for (int i = 0; i < 20; i++) 
			{
				c.agregar(new Numero(random.Next(100)));
			}
		}
		
		public static void informar(Coleccionable c)
		{
			Console.WriteLine(c.cuantos()+ " cantidad");
			Console.WriteLine(c.minimo()+ " numero minimo");
			Console.WriteLine(c.maximo()+ " numero maximo");
			string valor = Console.ReadLine();		// Para continuar
		}
		public static void Main(string[] args)
		{
			Comparable c1, c2, c3;

	        c1 = new Numero(4);
	        c2 = new Numero(7);
	        c3 = new Numero(4);
	
	        Console.WriteLine(c1.sosIgual(c3)); // true
	        Console.WriteLine(c1.sosMenor(c2)); // true
	        Console.WriteLine(c3.sosMayor(c2)); // flase
	
	        Coleccionable col = new Pila();
	
	        col.agregar(c1);
	        col.agregar(c2);
	
	        Console.WriteLine(col.cuantos());
	        Console.WriteLine(col.minimo());
	        Console.WriteLine(col.maximo());
	        Console.WriteLine(col.contiene(c3));
	
	
	        Pila pila = new Pila();
	        Cola cola = new Cola();
	        llenar(pila);
	        Console.Clear();
	        llenar(cola);
	        ColeccionMultiple colMul= new ColeccionMultiple(pila,cola);
	        informar(pila);
	        Console.WriteLine("termina pila");
	        informar(cola);
	        Console.WriteLine("termina cola");
	        informar(colMul);
	        Console.Write("Press any key to continue . . . ");
	        Console.Clear();
	        
			
	        Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
		
	}
}