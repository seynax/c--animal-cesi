using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesiAnimal.animal
{
    internal class Sheep : Animal
    {
        public Sheep()
        {
            this.Name = "Sheep";
        }

        public override void cry()
        {
            Console.WriteLine("Bee Bee !");
        }
    }
}
