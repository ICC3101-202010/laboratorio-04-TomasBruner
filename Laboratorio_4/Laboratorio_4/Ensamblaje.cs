using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class Ensamblaje : Maquina
    { 
       
        private int memory;

        public Ensamblaje(int memory)
        {
            this.memory = memory;
        }

        public override void Reiniciar()
        {
            Console.WriteLine("La maquina de Ensamblaje se reinició");
        }

        public override void Encender()
        {
            Console.WriteLine("La maquina de Ensamblaje fue encendida");
        }

        public override void Apagar()
        {
            Console.WriteLine("La maquina de Ensamblaje fue apagada");
        }

        public override int memoria()
        {
            return memory;
        }
    
    }
}
