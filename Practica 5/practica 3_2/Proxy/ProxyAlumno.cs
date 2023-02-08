/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 14/7/2022
 * Time: 19:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of ProxyAlumno.
	/// </summary>
	public class ProxyAlumno: AdAlumno
	{
		protected AdAlumno alumnoReal = null;
		protected string nombre;
		protected Numero dni;
		protected Numero legajo;
		protected Numero promedio;
		protected int calificacion;
		
		public ProxyAlumno(Numero leg, Numero prom, string nom, Numero d)
		{
			nombre = nom;
			dni = d;
			legajo = leg;
			promedio = prom;
		}
		
		public string mostrarCalificacion()
		{
			if (alumnoReal != null){
				return alumnoReal.mostrarCalificacion();
			}
			else{
				return null;
			}
		}
		public void setCalificacion(int valor){
			
			if(alumnoReal == null){
				alumnoReal = FabricaDeAlumnos.crearAlumno(legajo,promedio,nombre,dni,1);
				alumnoReal.setCalificacion(valor);
			}
			else {
				alumnoReal.setCalificacion(valor);
			}
		}
		public virtual int responderPregunta(int pregunta){
			
			if(alumnoReal == null){
				alumnoReal = FabricaDeAlumnos.crearAlumno(legajo,promedio,nombre,dni,3);
				Console.WriteLine("Instancia de alumno real creada.");
				return alumnoReal.responderPregunta(pregunta);
			}
			else{
				return alumnoReal.responderPregunta(pregunta);
			}
		}
        public string getNombre()
        {
        	return nombre;
        }
        public Numero getLegajo()
        {
        	return legajo;
        }
        public Numero getPromedio()
        {
        	return promedio;
        }
        public Numero getDni()
        {
        	return dni;
        }
        public int getCalificacion(){
        	return calificacion;
        }
        public bool sosIgual(Comparable o)
        {
        	return alumnoReal.sosIgual(o);
        }
		public bool sosMayor(Comparable o)
		{
        	return alumnoReal.sosMayor(o);
        }
		public bool sosMenor(Comparable o)
		{
        	return alumnoReal.sosMenor(o);
        }
	}
}
