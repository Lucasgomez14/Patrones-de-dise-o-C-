/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 15/7/2022
 * Time: 16:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of Aula.
	/// </summary>
	public class Aula
	{
		private Teacher teacher;
		public void comenzar()
        {
            Console.WriteLine("¡¡¡Comenzamos!!!");
            teacher = new Teacher();
        }
        public void nuevoAlumno(AdAlumno alumno)
        {
            teacher.goToClass(new AlumnoAdapter(alumno));
        }
        public void claseLista()
        {
            teacher.teachingAClass();
        }
	}
	
	public class AulaInicio : OrdenEnAula1
	{
		private Aula aula;
		
		public AulaInicio(Aula a)
		{
			aula = a;
		}
		public void ejecutar()
		{
			aula.comenzar();
		}
		
	}
	
	public class AulaLlena : OrdenEnAula1
	{
		private Aula aula;
		
		public AulaLlena(Aula a)
		{
			aula = a;
		}
		public void ejecutar()
		{
			aula.claseLista();
		}
		
	}
	public class LlegaAlumno : OrdenEnAula2
	{
		private Aula aula;
		
		public LlegaAlumno(Aula a)
		{
			aula = a;
		}
		
		public void ejecutar(Comparable o)
		{
			aula.nuevoAlumno((AdAlumno)o);
		}
	}
}
