using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class Almacenamiento : Maquina
    {
        private int memory;

        public Almacenamiento(int memory)
        {
            this.memory = memory;
        }

        public override void Reiniciar()
        {
            Console.WriteLine("La maquina de Almacenamiento se reinició");
        }

        public override void Encender()
        {
            Console.WriteLine("La maquina de Almacenamiento fue encendida");
        }

        public override void Apagar()
        {
            Console.WriteLine("La maquina de Almacenamiento fue apagada");
        }

        public override int memoria()
        {
            return memory;
        }
    }
}
