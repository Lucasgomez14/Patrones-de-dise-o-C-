/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 7/6/2022
 * Time: 5:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_4
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public abstract class FabricaDeComparables: Fabrica
	{
		public static Comparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch(opcion)
            {
                case 1:
            			fabrica = new FabricaDeNumeros();
                		break;
                case 2: 
                		fabrica = new FabricaDeAlumnos();
                		break;
               	case 3: 
                		fabrica = new FabricaDeVendedores();
               			break;
               	case 4: 
               			fabrica = new FabricaDeAlumnoMuyEstudioso();
               			break;
                default:
               			fabrica = null;
                		break;
            }
            return fabrica.crearAleatorio();
        }
        public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch(opcion)
            {
                case 1: 
            		fabrica = new FabricaDeNumeros();
            		break;
                case 2: 
            		fabrica = new FabricaDeAlumnos();
            		break;
                case 3: 
            		fabrica = new FabricaDeVendedores();
            		break;
            	case 4: 
            		fabrica = new FabricaDeAlumnoMuyEstudioso();
            		break;
                default: 
            		fabrica = null;
            		break;
            }
            return fabrica.crearPorTeclado();
        }
        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
	}
}
	
