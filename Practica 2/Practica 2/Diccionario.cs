/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 5/12/2022
 * Time: 7:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Practica_2
{
	/// <summary>
	/// Description of Diccionario.
	/// </summary>
	public class Diccionario: Coleccionable
	{
		public Diccionario()
		{
			listaDiccionario=new List<ClaveValor>();
		}
		
		List<ClaveValor> listaDiccionario;
		
		public List<ClaveValor> ListaDiccionario {
			get { return listaDiccionario; }
			set { listaDiccionario = value; }
		}
		
		public void Anadir(Comparable clave, Object valor)
		{
			ClaveValor CValor=new ClaveValor(clave,valor);
			listaDiccionario.Add(CValor);
		}
		
		public Object valorDe(Comparable clav)
		{
			foreach (ClaveValor clave in listaDiccionario) 
			{
				if (clave.Equals(clav)) {
					return clave.Valor;
				}
			}
			return null;
		}
		
		public int cuantos()
		{
			return listaDiccionario.Count;
		}
		
		public Comparable minimo()
		{
			ClaveValor menor=new ClaveValor();
			Comparable menorr;
//			Comparable menorDefinitivo=new Comparable();
			foreach (ClaveValor elemento in listaDiccionario) 
			{
				menorr=(Comparable)menor.Valor;
				if (((Comparable)elemento).sosMenor(menorr))
				{
				    	menor=elemento;
				}
			}
        	return (Comparable)menor.Valor;
		}
		public Comparable maximo()
		{
			ClaveValor mayor=new ClaveValor();
			Comparable mayorr;
//			Comparable menorDefinitivo=new Comparable();
			foreach (ClaveValor elemento in listaDiccionario) 
			{
				mayorr=(Comparable)mayor.Valor;
				if (((Comparable)elemento).sosMayor(mayorr))
				{
				    	mayor=elemento;
				}
			}
        	return (Comparable)mayor.Valor;
		}
//En el método agregar puede usar una clave única por defecto, que maneja el propio diccionario para ir agregando los valores asociados a esas claves únicas.

		public void agregar(Comparable c)
		{
			Comparable p= new Alumno();
			Anadir(p,c);
		}
		public bool contiene(Comparable c)
		{
			foreach (ClaveValor ClavedeValor in listaDiccionario) {
				if (ClavedeValor.Valor.Equals(c)) 
				{
					return true;
				}
			}
			return false;
		}
	}
}
