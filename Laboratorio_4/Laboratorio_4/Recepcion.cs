using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class Recepcion : Maquina
    {
        private int memory;

        public Recepcion(int memory)
        {
            this.memory = memory;
        }

        public override void Reiniciar()
        {
            Console.WriteLine("La maquina de Recepcion se reinició");
        }

        public override void Encender()
        {
            Console.WriteLine("La maquina de Recepción fue encendida");
        }

        public override void Apagar()
        {
            Console.WriteLine("La maquina de Recepción fue apagada");
        }

        public override int memoria()
        {
            return memory;
        }
    }

}
