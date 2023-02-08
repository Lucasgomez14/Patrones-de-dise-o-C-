/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 3/6/2022
 * Time: 19:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace practica_4
{
	class Program
	{
		public static void Main(string[] args)
		{
//			Cola col= new Cola();
//			Pila pil= new Pila();
//			Conjunto conj= new Conjunto();
//			Diccionario dic= new Diccionario();
//			Gerente geren=new Gerente();
//			
//			Console.Write("Creando Alumnos...");
//			LlenarAlumnos(pil);
//			Console.WriteLine("Informa pila");
//			informar(pil);
//			Console.Write("Presione una tecla para continuar ");
//			Console.ReadKey(true);
//			
//			Console.Clear();
//			
//			Console.Write("Creando Vendedores... ");
//			LlenarVendedores(col);
//			agregarObservador(col,geren);
//			jornadaDeVentas(col);
//			geren.cerrar();
			
			Teacher T = new Teacher();
			for (int i = 0; i < 10 ; i++){
				AdAlumno Alu = (Alumno)FabricaDeComparables.crearAleatorio(2);
				AdAlumno decorador = new DecoradorSecuencial(Alu);
				decorador = new DecoradorLetras(decorador);
				decorador = new DecoradorLegajo(decorador);
				decorador = new DecoradorPromocion(decorador);
				decorador= new DecoradorAsteriscos(decorador);
				T.goToClass(new AlumnoAdapter(decorador));
			}
			for (int j = 0; j < 10 ; j++){
				AdAlumno AluME = (AlumnoMuyEstudioso)FabricaDeComparables.crearAleatorio(4);
				AdAlumno decorador = new DecoradorSecuencial(AluME);
				decorador = new DecoradorLetras(decorador);
				decorador = new DecoradorLegajo(decorador);
				decorador = new DecoradorPromocion(decorador);
				AdAlumno decorador5 = new DecoradorAsteriscos(decorador);
				T.goToClass(new AlumnoAdapter(decorador5));
			}
			T.teachingAClass();


			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
		public static void jornadaDeVentas(Iterable listaVendedores)
		{
			IteradorColecciones iter = listaVendedores.crearIterador();
			Random random = new Random();
			Gerente g= new Gerente();
			
			while(!iter.fin())
            {
				for (int i = 0; i <= 20; i++)
				{
					Numero monto=new Numero(random.Next(1,7000));
               		Vendedor vendedorAux=(Vendedor)iter.actual();
               		vendedorAux.Venta(monto);
				}
               
                iter.siguiente();
            }
		}
		
		public static void LlenarAlumnos(Coleccionable colec)
		{	
			Comparable com=null;
			for (int i = 1; i < 21; i++)
			{
				com=FabricaDeComparables.crearAleatorio(2);
				Console.WriteLine("Alumno n°: "+i+ " creado");
				colec.agregar(com);
				com=null;
			}
										
		}
		
		public static void LlenarVendedores(Coleccionable colec)
		{
			Comparable com=null;
			for (int i = 1; i < 21; i++)
			{
				com=FabricaDeComparables.crearAleatorio(3);
				Console.WriteLine("Vendedor n°: "+i+ " creado");
				colec.agregar(com);
				com=null;
			}
		}
		
		public static void informar(Coleccionable c)
		{
			int opcion=2;
			Console.WriteLine(c.cuantos()+ " cantidad");
			Console.WriteLine(c.minimo()+ " numero minimo");
			Console.WriteLine(c.maximo()+ " numero maximo");
			Console.WriteLine("Presione una tecla para continuar");
			Console.ReadKey(true);
			
			Console.WriteLine("Verificador de existencia");
			Console.WriteLine("Ingrese por teclado para verificar si existe:");
			Comparable com = FabricaDeComparables.crearPorTeclado(opcion);
            if (c.contiene(com))
                Console.WriteLine("el numero leido esta en la coleccion");
            else
                Console.WriteLine("el numero leido NO esta en la coleccion");
				
					
		}
		
		
		
		public static void ImprimirElemento(Iterable Colec){
			
            IteradorColecciones iter = Colec.crearIterador();
            while(!iter.fin())
            {
                Console.WriteLine(iter.actual() + " ");
                iter.siguiente();
            }
		}
		
		public static void agregarObservador(Iterable coleccion, Observador o)
		{
			IteradorColecciones iter = coleccion.crearIterador();
			while(!iter.fin())
            {
				Vendedor v = (Vendedor)iter.actual();
				v.agregarObservador(o);
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