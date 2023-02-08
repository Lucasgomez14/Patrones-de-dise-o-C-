/*
 * Created by SharpDevelop.
 * User: Lucas
 * Date: 3/6/2022
 * Time: 20:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica_4
{
	/// <summary>
	/// Description of FabricaDeVendedores.
	/// </summary>
	public  class FabricaDeVendedores: FabricaDePersonas
	{
//		const int vendedorTeclado=2;
//		const int vendedorRandom=1;
//		const int defecto=vendedorRandom;
//		
//		public static Vendedor CrearVendedorPorDefecto()
//        {
//        	return crearVendedor(defecto);
//        }
//        
//        public static Vendedor crearVendedor(int opcionNum)
//        {
//        	FabricaDeVendedores fabrica=new FabricaVendedorRandom();
//        	Vendedor VendedorGenerado=null;
//            switch(opcionNum)
//            {
//                case 1:	
//					VendedorGenerado=((Vendedor)fabrica.crearAleatorio());
//                    break;
//                case 2:
//                    VendedorGenerado=((Vendedor)fabrica.crearPorTeclado());
//                    break;
//   
//                default:
//                    Console.WriteLine("Opcion no válida, seleccione 1 o 2");
//                    break;
//            }
//            return VendedorGenerado;
//        }
//		
//		public Comparable crearAleatorio()
//		{
//			FabricaDeVendedores fabricaa= new FabricaVendedorRandom();
//        	return fabricaa.CrearVendedor();
//		}
//		
//		public Comparable crearPorTeclado()
//		{
//			FabricaDeVendedores fabricaa= new FabricaVendedorPorTeclado();
//			return fabricaa.CrearVendedor();
//		}
//		
//		public abstract Vendedor CrearVendedor();
//	}
//	
//	public class FabricaVendedorRandom: FabricaDeVendedores
//	{
//		public override Vendedor CrearVendedor()
//        {
//			GeneradorDeDatosAleatorios Generator= new GeneradorDeDatosAleatorios();
//            Console.Write("Ingrese el número máximo para todas las operaciones: ");
//            int max=int.Parse(Console.ReadLine());
//            return new Vendedor(new Numero(Generator.numeroAleatorio(max)), Generator.stringAleatorio(20), new Numero(Generator.numeroAleatorio(max)));
//        }
//	}
//	
//	public class FabricaVendedorPorTeclado: FabricaDeVendedores
//	{
//		public override Vendedor CrearVendedor()
//        {
//              LectorDeDatos Dato=new LectorDeDatos();
//              return new Vendedor(new Numero(Dato.numeroPorTeclado()),Dato.stringPorTeclado(),new Numero(Dato.numeroPorTeclado()));
//        }
//	}
		public override Comparable crearAleatorio()
        {
			return new Vendedor(new Numero(base.random.numeroAleatorio(1000000)),base.NombreAleatorio(),new Numero(base.DniAleatorio()));
        }
        public override Comparable crearPorTeclado()
        {
        	return new Vendedor(new Numero(base.porTeclado.numeroPorTeclado()),base.NombrePorTeclado(),new Numero(base.DniPorTeclado()));
        }
	}
}
