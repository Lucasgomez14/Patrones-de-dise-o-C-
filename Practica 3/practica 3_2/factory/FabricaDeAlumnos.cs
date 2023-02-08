/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 30/5/2022
 * Time: 16:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_3_2
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public abstract class FabricaDeAlumnos: FabricaDeComparables
	{
		public const int AlumnoRandom= 1;
        public const int AlumnoPorTeclado= 2; 
        public static int AlumnoPorDefecto=AlumnoRandom;
        
        public static Alumno CrearAlumnoPorDefecto()
        {
        	return crearAlumno(AlumnoPorDefecto);
        }
        
        public static Alumno crearAlumno(int opcionNum)
        {
        	FabricaDeAlumnos fabrica=new FabricaAlumnoRandom();
        	Alumno AlumnoGenerado=null;
            switch(opcionNum)
            {
                case AlumnoRandom:	
					AlumnoGenerado=((Alumno)fabrica.crearAleatorio());
                    break;
                case AlumnoPorTeclado:
                    AlumnoGenerado=((Alumno)fabrica.crearPorTeclado());
                    break;
                    
                default:
                    AlumnoGenerado=null;
                    break;
            }
            return AlumnoGenerado;
        }
        public Comparable crearAleatorio()
        {
        	FabricaDeAlumnos fabricaa= new FabricaAlumnoRandom();
        	return fabricaa.CrearAlumno();
        }
        public Comparable crearPorTeclado()
        {
        	FabricaDeAlumnos fabricaa= new FabricaAlumnoPorTeclado();
        	return fabricaa.CrearAlumno();
        }
        
        public abstract Alumno CrearAlumno();
	}
	
	
	public class FabricaAlumnoRandom: FabricaDeAlumnos
	{
		public override Alumno CrearAlumno()
        {
			GeneradorDeDatosAleatorios Generator= new GeneradorDeDatosAleatorios();
            Console.Write("Ingrese el número máximo para todas las operaciones: ");
            int max=int.Parse(Console.ReadLine());

			return new Alumno (new Numero(Generator.numeroAleatorio(max)),new Numero(Generator.numeroAleatorio(max)),Generator.stringAleatorio(20),new Numero(Generator.numeroAleatorio(max)));
        }
	}
	
	public class FabricaAlumnoPorTeclado: FabricaDeAlumnos
	{
		public override Alumno CrearAlumno()
        {
              LectorDeDatos Dato=new LectorDeDatos();

              return new Alumno (new Numero(Dato.numeroPorTeclado()),new Numero(Dato.numeroPorTeclado()),Dato.stringPorTeclado(),new Numero(Dato.numeroPorTeclado()));
        }
	}
}
