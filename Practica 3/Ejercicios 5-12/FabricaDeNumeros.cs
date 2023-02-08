/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 29/5/2022
 * Time: 23:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicios_5_12
{
	/// <summary>
	/// Description of FabricaDeNumeros.
	/// </summary>
	public abstract class FabricaDeNumeros: FabricaDeComparables
    {
        public const int NumRandom= 1;
        public const int NumPorTeclado= 2; 
        public static int NumeroPorDefecto=NumRandom;
        public static Numero CrearNumeroPorDefecto()
        {
			return crearNumero(NumeroPorDefecto);
        }
       
        
        public static Numero crearNumero(int tipoNumero)
        {
        	FabricaDeNumeros fabrica=new FabricaNumeroRandom();
        	Numero numeroGenerado=null;
            switch(tipoNumero)
            {
                case NumRandom:	
//            		NumeroGenerado=Console.ReadLine();
					numeroGenerado=((Numero)fabrica.crearAleatorio());
                    break;
                case NumPorTeclado:
                    numeroGenerado=((Numero)fabrica.crearPorTeclado());
                    break;
                    
                default:
                    numeroGenerado=null;
                    break;
            }
            return numeroGenerado;
        }
        
        public Comparable crearAleatorio()
        {
            FabricaDeNumeros fabricaa= new FabricaNumeroRandom();
            return fabricaa.crearNumero();
        }
        public Comparable crearPorTeclado()
        {
            FabricaDeNumeros fabricaa= new FabricaDeNumeroPorTeclado();
            return fabricaa.crearNumero();
        }
             
        public abstract Numero crearNumero();
    }

	
	
	
	
	
    public class FabricaNumeroRandom:FabricaDeNumeros
    {
        public override Numero crearNumero()
        {
            GeneradorDeDatosAleatorios Generator= new GeneradorDeDatosAleatorios();
            Console.Write("Ingrese el número Máximo: ");
            int numMax=int.Parse(Console.ReadLine());
			return new Numero(Generator.numeroAleatorio(numMax));
			
        }
    }

    
    
    
    
    public class FabricaDeNumeroPorTeclado:FabricaDeNumeros
    {
        public override Numero crearNumero()
        {
            LectorDeDatos Dato=new LectorDeDatos(); 

            return new Numero(Dato.numeroPorTeclado());
        }
    }
}
