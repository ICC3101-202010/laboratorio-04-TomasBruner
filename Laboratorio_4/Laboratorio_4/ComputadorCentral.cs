using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class ComputadorCentral
    {

        Empaque e1 = new Empaque(7);
        
        public ComputadorCentral(Empaque e1)
        {
            
        }
        
        public void EncenderMaquinas()
        {
            e1.Encender();
        }

        public void ApagarMaquina()
        {
            e1.Apagar();
        }
        public void FuncionarMaquinas(int contador)
        {
            Console.WriteLine("La maquina de Empaque uso " + (contador + 1) + " de memoria, le quedan " + (e1.memoria() - (contador + 1)));
            if (contador == e1.memoria())
            {
                Console.WriteLine("La maquina de Empaque uso toda la memoria, la maquina se va a reiniciar");
                e1.Reiniciar();
                contador = contador + 1;
            }
            
        }
      
    }
}
