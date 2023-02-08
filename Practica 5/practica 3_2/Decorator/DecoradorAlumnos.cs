/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 9/7/2022
 * Time: 10:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_5
{
	/// <summary>
	/// Description of DecoradorAlumnos.
	/// </summary>
	public abstract class DecoradorAlumnos: AdAlumno
	{
		private AdAlumno adicional;
		public DecoradorAlumnos(AdAlumno adicional)
		{
			this.adicional = adicional;
		}
		
		 public virtual string mostrarCalificacion()
        {
            return this.adicional.mostrarCalificacion();
        }
        public virtual int getCalificacion()
        {
            return this.adicional.getCalificacion();
        }
        public virtual void setCalificacion(int valor)
        {
                adicional.setCalificacion(valor);
        }
        public virtual int responderPregunta(int pregunta)
        {
            return this.adicional.responderPregunta(pregunta);
        }
        public virtual string getNombre()
        {
            return this.adicional.getNombre();
        }
        public virtual Numero getPromedio()
        {
        	return this.adicional.getPromedio();
        }
        
        public Numero getDni(){
        	
        	return adicional.getDni();
        }
        public virtual Numero getLegajo()
        {
            return this.adicional.getLegajo();
        }
        public virtual bool sosIgual(Comparable c)
        {
            return this.adicional.sosIgual(c);
        }

        public virtual bool sosMenor(Comparable c)
        {
            return this.adicional.sosMenor(c);
        }

        public virtual bool sosMayor(Comparable c)
        {
            return this.adicional.sosMayor(c);
        }
	}
		
}
