/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 30/5/2022
 * Time: 16:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos: FabricaDePersonas
	{
		static Random ran = new Random();
		public override Comparable crearAleatorio()
		{
			return new Alumno(new Numero(base.random.numeroAleatorio(10000)),new Numero(base.random.numeroAleatorio(10)), base.NombreAleatorio(),new Numero(base.DniAleatorio()));
		}
		
		public override Comparable crearPorTeclado()
		{
			return new Alumno(new Numero(base.porTeclado.numeroPorTeclado()),new Numero(base.porTeclado.numeroPorTeclado()),base.NombrePorTeclado(),new Numero(base.DniPorTeclado()));
		}
		public int CrearLegajoAleatorio(){
			
			return ran.Next(0,50000);
		}
		public int CrearPromedioAleatorio(){
			
			return ran.Next(1,10);
		}
		public int crearPromedioPorTeclado(){
			
			return porTeclado.numeroPorTeclado();
		}
		public int crearLegajoPorTeclado(){
			
			return porTeclado.numeroPorTeclado();
		}
		
		public static AdAlumno crearAlumno(Numero legajo, Numero promedio, string nombre, Numero dni,int TipoDeAlumno)
        {
            switch(TipoDeAlumno)
            {
                case 1: return new Alumno(legajo,promedio,nombre,dni);
                case 2: return new AlumnoMuyEstudioso(legajo,promedio,nombre,dni);
                case 3:
                    AdAlumno x = new Alumno(legajo,promedio,nombre,dni);
                    AdAlumno dec = new DecoradorSecuencial(x);
                    dec = new DecoradorLetras(dec);
                    dec = new DecoradorLegajo(dec);
                    dec = new DecoradorPromocion(dec);
                    dec = new DecoradorAsteriscos(dec);
                    return dec;
                    
                case 4:
                    AdAlumno AlumnoEstudioso = new AlumnoMuyEstudioso(legajo,promedio,nombre,dni);
                    AdAlumno decorador = new DecoradorSecuencial(AlumnoEstudioso);
                    decorador = new DecoradorLetras(decorador);
                    decorador = new DecoradorLegajo(decorador);
                    decorador = new DecoradorPromocion(decorador);
                    decorador = new DecoradorAsteriscos(decorador);
                    return decorador;
                default: return null;
            }
        }
		 public override Comparable crearProxy(){
		 	
			return new ProxyAlumno(new Numero(CrearLegajoAleatorio()),new Numero(CrearPromedioAleatorio()),base.NombreAleatorio(),new Numero(base.DniAleatorio()));
		 }
		
		
	}
}
