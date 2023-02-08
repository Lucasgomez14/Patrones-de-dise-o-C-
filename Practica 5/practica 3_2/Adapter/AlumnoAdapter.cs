/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 7/6/2022
 * Time: 8:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of AlumnoAdapter.
	/// </summary>
	public class AlumnoAdapter : Student, Comparable
	{
		AdAlumno alumno;
		public AlumnoAdapter(AdAlumno a)
		{
			alumno = a;
		}
		
		public string getName(){
			return alumno.getNombre();
		}
		public AdAlumno getAlumno(){
			
			return alumno;
		}
		
		public int yourAnswerIs(int question){
			return alumno.responderPregunta(question);
		}
		public void setScore(int score){
			
			alumno.setCalificacion(score);
		}
		public string showResult(){
			
			return alumno.mostrarCalificacion();
		}
		public bool equals(Student student){
			
			return alumno.sosIgual(((AlumnoAdapter)student).getAlumno());
		}
		public bool lessThan(Student student){
			
			return alumno.sosMenor(((AlumnoAdapter)student).getAlumno());
		}
		public bool greaterThan(Student student){
			
			return alumno.sosMayor(((AlumnoAdapter)student).getAlumno());
			
		}
		public bool sosIgual(Comparable c)
        {
            throw new NotImplementedException();
        }
        public bool sosMayor(Comparable c)
        {
            throw new NotImplementedException();
        }
        public bool sosMenor(Comparable c)
        {
            throw new NotImplementedException();
        }
		
	}
}
