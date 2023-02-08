/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 9/7/2022
 * Time: 10:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_4
{
	/// <summary>
	/// Description of Decoradores.
	/// </summary>
	public class DecoradorLegajo: DecoradorAlumnos
	{
		public DecoradorLegajo(AdAlumno adicional) : base(adicional)
		{
			
		}
		public override string mostrarCalificacion(){
			
			string resultado = base.mostrarCalificacion();
			resultado += " " + getLegajo() + " ";
			
			return resultado;
		}
	}
	
	public class DecoradorLetras : DecoradorAlumnos
		
	{
		public DecoradorLetras(AdAlumno adicional) : base(adicional)
		{
			
		}
		public override string mostrarCalificacion(){
			
			string [] letras = new string[]{"CERO","UNO","DOS","TRES","CUATRO","CINCO","SEIS","SIETE","OCHO","NUEVE","DIEZ"};
			
			string resultado = base.mostrarCalificacion();
			
			resultado += "("+ letras[getCalificacion()] + ")";
			return resultado;
		}
	}
	public class DecoradorAsteriscos : DecoradorAlumnos
		
	{
		public DecoradorAsteriscos(AdAlumno adicional) : base(adicional)
		{
			
		}
		
		public override string mostrarCalificacion()
		{
			string resultado = "***************************************************************************";
			resultado += ("\n* "+base.mostrarCalificacion()+" *");
			resultado += "\n***************************************************************************";
			
			return resultado;
		}
	}
	
	public class DecoradorPromocion : DecoradorAlumnos
	{
		public DecoradorPromocion(AdAlumno adicional) : base(adicional)
		{
			
		}
		public override string mostrarCalificacion()
		{
			int nota = base.getCalificacion();
			string resultado = base.mostrarCalificacion();
			string aux= "";
			
			if (nota >= 7){
				
				aux = "(PROMOCION)";
			}
			
			else if (nota >= 4 && nota < 7 ){
				
				aux = "(APROBADO)";
			}
			
			else if(nota < 4){
				
				aux = "(DESAPROBADO)";
			}
			
			resultado += aux;
			return resultado;
	   }
	}
	public class DecoradorSecuencial : DecoradorAlumnos
	 {
		static int cont = 1;
		public DecoradorSecuencial(AdAlumno adicional) : base(adicional)
		{
			
		}
		public override string mostrarCalificacion()
		{
			string s = base.mostrarCalificacion();
            string modified = s.Insert(0,cont.ToString()+")");
            cont++;
            return modified;
			
		}
	 } 
		
}
	
	
	
	
	
	
