using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class ComputadorCentral
    {
        Recepcion r1 = new Recepcion(10);
        Almacenamiento a1 = new Almacenamiento(5);
        Ensamblaje en1 = new Ensamblaje(11);
        Verificacion v1 = new Verificacion(8);
        Empaque e1 = new Empaque(7);
        
        public ComputadorCentral(Recepcion r1, Almacenamiento a1, Ensamblaje en1, Verificacion v1, Empaque e1)
        {
            
        }
        
        public void EncenderMaquinas()
        {
            r1.Encender();
            a1.Encender();
            en1.Encender();
            v1.Encender();
            e1.Encender();
        }

        public void ApagarMaquinas()
        {
            r1.Apagar();
            a1.Apagar();
            en1.Apagar();
            v1.Apagar();
            e1.Apagar();
        }
        public void FuncionarMaquinas(int contador, int contador1, int contador2, int contador3, int contador4)
        {
            Console.WriteLine("La maquina de Recepcion usó " + (contador + 1) + " de memoria, le quedan " + (r1.memoria() - (contador + 1)));
            if ((contador + 1) == r1.memoria())
            {
                Console.WriteLine("La maquina de Recepción uso toda la memoria, la maquina se va a reiniciar");
                r1.Reiniciar();
            }
            Console.WriteLine("La maquina de Almacenamiento usó " + (contador1 + 1) + " de memoria, le quedan " + (a1.memoria() - (contador1 + 1)));
            if ((contador1 + 1) == a1.memoria())
            {
                Console.WriteLine("La maquina de Almacenamiento uso toda la memoria, la maquina se va a reiniciar");
                a1.Reiniciar();
            }
            Console.WriteLine("La maquina de Ensamblaje usó " + (contador2 + 1) + " de memoria, le quedan " + (en1.memoria() - (contador2 + 1)));
            if ((contador2 + 1) == en1.memoria())
            {
                Console.WriteLine("La maquina de Ensamblaje uso toda la memoria, la maquina se va a reiniciar");
                en1.Reiniciar();
            }
            Console.WriteLine("La maquina de Verificacion usó " + (contador3 + 1) + " de memoria, le quedan " + (v1.memoria() - (contador3 + 1)));
            if ((contador3 + 1) == v1.memoria())
            {
                Console.WriteLine("La maquina de Verificacion uso toda la memoria, la maquina se va a reiniciar");
                v1.Reiniciar();
            }

            Console.WriteLine("La maquina de Empaque usó " + (contador4 + 1) + " de memoria, le quedan " + (e1.memoria() - (contador4 + 1)));
            if ((contador4 + 1) == e1.memoria())
            {
                Console.WriteLine("La maquina de Empaque uso toda la memoria, la maquina se va a reiniciar");
                e1.Reiniciar();
            }

            
        }
      
    }
}
