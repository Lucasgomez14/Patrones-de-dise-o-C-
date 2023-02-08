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
			LlenarAlumnos(pil);
			Console.Clear();	//poniendo el clear me cambia los randoms, sino me quedan iguales.
			LlenarAlumnos(col);
			Console.Clear();
			LlenarAlumnos(conj);
			Console.Clear();
			LlenarAlumnos(dic);
			Console.Write("Presione para iniciar");
			Console.ReadKey(true);
			ColeccionMultiple colMul= new ColeccionMultiple(pil,col);
			Console.WriteLine("Informa pila");
			informar(pil);
			Console.WriteLine("");
			
			Console.WriteLine("Informa cola");
			informar(col);
			Console.WriteLine("");
			
			Console.WriteLine("Informa ColeccionMultiple");
			informar(colMul);
			Console.WriteLine("");
			
			Console.Clear();
			
			Console.WriteLine("Imprimir todos los elementos de cola");
			ImprimirElemento(col);
			Console.Write("Presione para continuar");
			Console.ReadKey(true);
			Console.Clear();
			
			Console.WriteLine("Imprimir todos los elementos de pila");
			ImprimirElemento(pil);
			Console.Write("Presione para continuar");
			Console.ReadKey(true);
			Console.Clear();
			
			Console.WriteLine("Imprimir todos los elementos de conjunto");
			ImprimirElemento(conj);
			Console.Write("Presione para continuar");
			Console.ReadKey(true);
			Console.Clear();
			
			Console.WriteLine("Imprimir todos los elementos de diccionario");
			ImprimirElemento(dic);
			Console.Clear();
			
			Console.WriteLine("Estrategy por nombre");
			CambiarEstrategia(pil,new CompararPorNombre());
			informar(pil);
			Console.WriteLine("");
			
			Console.WriteLine("Estrategy por legajo");
			CambiarEstrategia(pil,new CompararPorLegajo());
			informar(pil);
			Console.WriteLine("");
			
			
			Console.WriteLine("Estrategy por promedio");
			CambiarEstrategia(pil,new CompararPorPromedio());
			informar(pil);
			Console.WriteLine("");
			
			Console.WriteLine("Estrategy por dni");
			CambiarEstrategia(pil,new CompararPorDni());
			informar(pil);
			Console.WriteLine("");
			
					
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
			Console.WriteLine("cantidad: "+ c.cuantos());
			Console.WriteLine("numero minimo: "+c.minimo());
			Console.WriteLine("numero maximo: "+c.maximo());
			Console.WriteLine("Presione una tecla para continuar");
			Console.ReadKey(true);
		}
		
		public static void ImprimirElemento(Iterable Colec){
			
            IteradorColecciones iter = Colec.crearIterador();
            int i=1;
            while(!iter.fin())
            {
            	Console.WriteLine(i.ToString()+": "+iter.actual() + " ");
                iter.siguiente();
                i++;
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