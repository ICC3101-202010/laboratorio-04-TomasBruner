using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_4
{
    class Verificacion : Maquina 
    {
        private int memory;

        public Verificacion(int memory)
        {
            this.memory = memory;
        }

        public override void Reiniciar()
        {
            Console.WriteLine("La maquina de Verificacion se reinició");
        }

        public override void Encender()
        {
            Console.WriteLine("La maquina de Verificacion fue encendida");
        }

        public override void Apagar()
        {
            Console.WriteLine("La maquina de Vrificacion fue apagada");
        }

        public override int memoria()
        {
            return memory;
        }
    }
}
