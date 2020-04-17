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
            Recepcion r1 = new Recepcion(10);
            Empaque e1 = new Empaque(7);
            Almacenamiento a1 = new Almacenamiento(5);
            Ensamblaje en1 = new Ensamblaje(11);
            Verificacion v1 = new Verificacion(8);
            

            ComputadorCentral c1 = new ComputadorCentral(r1, a1, en1, v1, e1);

            bool apagadas = true;

            Console.WriteLine("Bienvenido a la fabrica de objetos");
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1. Encender las maquinas");
            Console.WriteLine("2. Hacer funcionar las maquinas");
            Console.WriteLine("3. Apagar las maquinas");
            Console.WriteLine("4. Salir de la fabrica");
            int respuesta = Convert.ToInt32(Console.ReadLine());
            int contador = 0;
            int contador1 = 0;
            int contador2 = 0;
            int contador3 = 0;
            int contador4 = 0;
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
                        c1.FuncionarMaquinas(contador, contador1, contador2, contador3, contador4);
                        contador = contador + 1;
                        contador1 = contador1 + 1;
                        contador2 = contador2 + 1;
                        contador3 = contador3 + 1;
                        contador4 = contador4 + 1;

                        if (contador == r1.memoria())
                        {
                            contador = 0;
                        }
                        if (contador1 == a1.memoria())
                        {
                            contador1 = 0;
                        }
                        if (contador2 == en1.memoria())
                        {
                            contador2 = 0;
                        }
                        if (contador3 == v1.memoria())
                        {
                            contador3 = 0;
                        }
                        if (contador4 == e1.memoria())
                        {
                            contador4 = 0;
                        }
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
                        c1.ApagarMaquinas();
                        apagadas = true;
                    }
                    
                }
                else if (respuesta == 4)
                {
                    Console.WriteLine("Verificando que las maquinas estén apagadas");
                    if (apagadas == true)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Las maquinas estan apagadas, hasta luego!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Las maquinas estan encendidas");
                        Console.WriteLine("Se apagaran las maquinas para cerrar");
                        c1.ApagarMaquinas();
                        Console.WriteLine(" ");
                        Console.WriteLine("Hastaluego!");
                        break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Valor no valido, vuelva a ingresar su respuesta");
                    Console.WriteLine(" ");
                    Console.WriteLine("¿Que desea hacer?");
                    Console.WriteLine(" ");
                    Console.WriteLine("1. Encender las maquinas");
                    Console.WriteLine("2. Hacer funcionar las maquinas");
                    Console.WriteLine("3. Apagar las maquinas");
                    Console.WriteLine("4. Salir de la fabrica");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine(" ");
                Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine(" ");
                Console.WriteLine("1. Encender las maquinas");
                Console.WriteLine("2. Hacer funcionar las maquinas");
                Console.WriteLine("3. Apagar las maquinas");
                Console.WriteLine("4. Salir de la fabrica");
                respuesta = Convert.ToInt32(Console.ReadLine());
            }
            


            Console.ReadKey();
        }
    }
}
