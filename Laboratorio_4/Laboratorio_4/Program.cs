using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Empaque e1 = new Empaque(7);

            ComputadorCentral c1 = new ComputadorCentral(e1);

            bool apagadas = true;

            Console.WriteLine("Bienvenido a la fabrica de objetos");
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1. Encender las maquinas");
            Console.WriteLine("2. Hacer funcionar las maquinas");
            Console.WriteLine("3. Apagar las maquinas");
            Console.WriteLine("4. Salir de la fabrica");
            int respuesta = Convert.ToInt32(Console.ReadLine());
            int contador = 0;
            while (respuesta == 1 || respuesta == 2 || respuesta == 3 || respuesta == 4)
            {
                if (respuesta == 1)
                {
                    if (apagadas == true)
                    {
                        c1.EncenderMaquinas();
                        apagadas = false;
                    }
                    else
                    {
                        Console.WriteLine("Las maquinas ya están encendidas");
                    }
                }
                else if (respuesta == 2)
                {
                    if (apagadas == false)
                    {
                        c1.FuncionarMaquinas(contador);
              

                      
                    }
                    else
                    {
                        Console.WriteLine("Primero debe encender las maquinas");
                    }
                }
                else if (respuesta == 3)
                {
                    if (apagadas == true)
                    {
                        Console.WriteLine("Las maquinas ya están apagadas");
                    }
                    else
                    {
                        c1.ApagarMaquina();
                        apagadas = true;
                    }
                    
                }
                else if (respuesta == 4)
                {
                    Console.WriteLine("Verificando que las maquinas estén apagadas");
                    if (apagadas == true)
                    {
                        Console.WriteLine("Las maquinas estan apagadas, hasta luego!");
                    }
                    else
                    {
                        Console.WriteLine("Las maquinas estan encendidas");
                        Console.WriteLine("Se apagaran las maquinas para cerrar");
                        c1.ApagarMaquina();
                        Console.WriteLine("Hastaluego!");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Valor no valido, vuelva a ingresar su respuesta");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                }
                respuesta = Convert.ToInt32(Console.ReadLine());
            }
            


            Console.ReadKey();
        }
    }
}
