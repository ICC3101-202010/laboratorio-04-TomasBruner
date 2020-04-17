using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class Empaque : Maquina
    {
        private int memory;

        public Empaque(int memory)
        {
            this.memory = memory;
        }

        public override void Reiniciar()
        {
            Console.WriteLine("Se acabó la memoria de la maquina de Empaque, la maquina se reinició");
        }

        public override void Encender()
        {
            Console.WriteLine("La maquina de Empaque fue encendida");
        }

        public override void Apagar()
        {
            Console.WriteLine("La maquina de Empaque fue apagada");
        }

        public override int memoria()
        {
            return memory;
        }
    }
}
